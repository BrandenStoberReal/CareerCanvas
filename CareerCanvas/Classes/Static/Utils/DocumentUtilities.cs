using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppeteerSharp.Media;
using PuppeteerSharp;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Static.Utils
{
    public static class DocumentUtilities
    {
        /// <summary>
        /// Exports a HTML document to a PDF file.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="background"></param>
        /// <param name="optimize"></param>
        /// <param name="useShadows"></param>
        /// <param name="rescale"></param>
        /// <param name="defaultfilename"></param>
        /// <param name="defaultscale"></param>
        public static async Task SaveToPdfAsync(HtmlDocument document, bool background, bool optimize, bool useShadows, bool rescale, string defaultFilename = "output.pdf", decimal defaultScale = 0.95M)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));

            // Create a unique temporary directory with a GUID to avoid conflicts
            var tempDir = Path.Combine(Path.GetTempPath(), $"pdftmp_{Guid.NewGuid()}");
            var tempHtmlPath = string.Empty;
            Form? progressForm = null;
            IBrowser? browser = null;

            try
            {
                // Create a temporary directory to store the HTML file
                Directory.CreateDirectory(tempDir);
                tempHtmlPath = Path.Combine(tempDir, "pdftmp.html");

                // Save HTML content to temporary file
                File.WriteAllText(tempHtmlPath, document.DocumentNode.OuterHtml);

                // Configure save file dialog
                using (var saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*",
                    DefaultExt = "pdf",
                    Title = "Export to PDF",
                    FileName = defaultFilename,
                    InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                })
                {
                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    // Create and show progress form to indicate PDF generation is in process
                    progressForm = new Form
                    {
                        Text = "Generating PDF...",
                        Size = new System.Drawing.Size(300, 100),
                        StartPosition = FormStartPosition.CenterParent,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        MaximizeBox = false,
                        MinimizeBox = false,
                        ControlBox = false,
                        ShowInTaskbar = false
                    };

                    var progressBar = new ProgressBar
                    {
                        Dock = DockStyle.Fill,
                        Style = ProgressBarStyle.Marquee,
                        MarqueeAnimationSpeed = 50,
                        Margin = new Padding(10)
                    };

                    progressForm.Controls.Add(progressBar);
                    progressForm.Show();
                    Application.DoEvents(); // Ensure UI is updated

                    // Download Chromium browser if not already present
                    var browserFetcher = new BrowserFetcher();
                    await browserFetcher.DownloadAsync().ConfigureAwait(false);

                    // Launch headless browser instance with optimized settings
                    browser = await Puppeteer.LaunchAsync(new LaunchOptions
                    {
                        Headless = true,
                        Args = new[] { "--no-sandbox", "--disable-setuid-sandbox", "--disable-dev-shm-usage" }
                    }).ConfigureAwait(false);

                    // Create a new page in the browser
                    var page = await browser.NewPageAsync().ConfigureAwait(false);

                    // Set viewport size to match US Letter size (8.5 x 11 inches at 96 DPI)
                    await page.SetViewportAsync(new ViewPortOptions
                    {
                        Width = 816, // 8.5 inches * 96 DPI
                        Height = 1056 // 11 inches * 96 DPI
                    }).ConfigureAwait(false);

                    // Navigate to the temporary HTML file with a timeout
                    await page.GoToAsync($"file://{Path.GetFullPath(tempHtmlPath)}",
                        new NavigationOptions { Timeout = 60000, WaitUntil = new[] { WaitUntilNavigation.Networkidle0 } })
                        .ConfigureAwait(false);

                    // Extract background color from the document using JavaScript
                    if (background)
                    {
                        string jsFilePath = Path.GetFullPath("./js/colormatch.js");
                        if (File.Exists(jsFilePath))
                        {
                            string colormatchCode = File.ReadAllText(jsFilePath);
                            var backgroundColor = await page.EvaluateFunctionAsync<string>(colormatchCode).ConfigureAwait(false);

                            // Add custom CSS for optimal PDF rendering
                            await page.AddStyleTagAsync(new AddTagOptions
                            {
                                Content = $@"
                                @page {{
                                    size: letter;
                                    margin: 0.25in;
                                    background-color: {backgroundColor} !important;
                                }}
                                html {{
                                    background-color: {backgroundColor} !important;
                                    margin: 0;
                                    padding: 0;
                                }}
                                h1, h2, h3, h4, h5, h6 {{
                                    margin-top: 0.3em;
                                    margin-bottom: 0.3em;
                                }}
                                ul, ol {{
                                    margin-bottom: 0.2em;
                                    padding-left: 1.8em;
                                }}
                            "
                            }).ConfigureAwait(false);
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Color matching script not found: {0}", jsFilePath);
                        }
                    }

                    // Apply final document optimizations before PDF generation
                    if (optimize)
                    {
                        string jsFilePath = Path.GetFullPath("./js/finalize.js");
                        if (File.Exists(jsFilePath))
                        {
                            string optimizationCode = File.ReadAllText(jsFilePath);
                            await page.EvaluateFunctionAsync(optimizationCode).ConfigureAwait(false);
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Optimization script not found: {0}", jsFilePath);
                        }
                    }

                    // Remove shadows from elements to prevent rendering issues
                    if (!useShadows)
                    {
                        string jsFilePath = Path.GetFullPath("./js/noshadows.js");
                        if (File.Exists(jsFilePath))
                        {
                            string removeShadowsCode = File.ReadAllText(jsFilePath);
                            await page.EvaluateFunctionAsync(removeShadowsCode).ConfigureAwait(false);
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Shadow removal script not found: {0}", jsFilePath);
                        }
                    }

                    // Analyze content and calculate optimal scale to maximize use of page
                    var optimizedScale = defaultScale;

                    if (rescale)
                    {
                        string jsFilePath = Path.GetFullPath("./js/rescale.js");
                        if (File.Exists(jsFilePath))
                        {
                            string scaleCode = File.ReadAllText(jsFilePath);
                            optimizedScale = await page.EvaluateFunctionAsync<decimal>(scaleCode).ConfigureAwait(false);

                            // Ensure the scale is within reasonable bounds
                            optimizedScale = Math.Max(0.5M, Math.Min(1.5M, optimizedScale));
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Rescaling script not found: {0}", jsFilePath);
                        }
                    }

                    // Generate the PDF with optimized formatting
                    await page.PdfAsync(saveFileDialog.FileName, new PdfOptions
                    {
                        Format = PaperFormat.Letter,
                        PrintBackground = true,
                        MarginOptions = new MarginOptions
                        {
                            Left = "0.25in",
                            Top = "0.25in",
                            Bottom = "0.25in",
                            Right = "0.25in"
                        },
                        PreferCSSPageSize = true,
                        Scale = optimizedScale
                    }).ConfigureAwait(false);

                    // Close the progress indicator BEFORE showing the success message
                    if (progressForm != null && !progressForm.IsDisposed)
                    {
                        var formToClose = progressForm; // Create a local copy that won't be modified
                        formToClose.BeginInvoke(new Action(() => {
                            try
                            {
                                if (!formToClose.IsDisposed)
                                {
                                    formToClose.Close();
                                    formToClose.Dispose();
                                }
                            }
                            catch (Exception ex)
                            {
                                Globals.AppLogger.Error(ex, "Error closing progress form");
                            }
                        }));
                        progressForm = null; // Now it's safe to null the original reference
                    }

                    // Log success and notify user
                    Globals.AppLogger.Information("Document exported to PDF: {0}", saveFileDialog.FileName);
                    MessageBox.Show("Document exported to PDF successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Close the progress form even in case of error
                if (progressForm != null && !progressForm.IsDisposed)
                {
                    progressForm.BeginInvoke(new Action(() =>
                    {
                        progressForm.Close();
                        progressForm.Dispose();
                    }));
                    progressForm = null;
                }

                // Log and display any errors that occur during the export process
                Globals.AppLogger.Error(ex, "Error exporting document to PDF");
                MessageBox.Show($"Error exporting document: {ex.Message}", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the browser if it was opened
                if (browser != null)
                {
                    await browser.CloseAsync().ConfigureAwait(false);
                }

                // Final safety check for progress form disposal
                if (progressForm != null && !progressForm.IsDisposed)
                {
                    progressForm.BeginInvoke(new Action(() =>
                    {
                        progressForm.Close();
                        progressForm.Dispose();
                    }));
                }

                // Clean up temporary directory regardless of success or failure
                try
                {
                    if (Directory.Exists(tempDir))
                    {
                        Directory.Delete(tempDir, true);
                    }
                }
                catch (Exception ex)
                {
                    Globals.AppLogger.Error(ex, "Error cleaning temporary directory: {0}", tempDir);
                }
            }
        }

        /// <summary>
        /// Exports a HTML document to a file.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="defaultfilename"></param>
        public static void SaveToFile(HtmlDocument document, string defaultfilename = "output.html")
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "HTML Files (*.html)|*.html|All Files (*.*)|*.*",
                DefaultExt = "html",
                Title = "Export to HTML",
                FileName = defaultfilename,
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, document.DocumentNode.OuterHtml);
                Globals.AppLogger.Information($"Document exported to HTML file: {saveFileDialog.FileName}");
                MessageBox.Show("Document exported to HTML file successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
