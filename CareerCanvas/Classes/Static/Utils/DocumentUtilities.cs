using System.Diagnostics;
using PuppeteerSharp;
using PuppeteerSharp.Media;
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
        /// <param name="defaultFilename"></param>
        /// <param name="defaultScale"></param>
        public static async Task SaveToPdfAsync(HtmlDocument document, bool background, bool optimize, bool useShadows, bool rescale, string defaultFilename = "output.pdf", decimal defaultScale = 0.95M)
        {
            Globals.AppLogger.Debug("Exporting document to PDF with background: {Background}, optimize: {Optimize}, useShadows: {UseShadows}, rescale: {Rescale}, defaultFilename: {DefaultFilename}, defaultScale: {DefaultScale}",
                background, optimize, useShadows, rescale, defaultFilename, defaultScale);

            if (document == null)
            {
                Globals.AppLogger.Error("Incoming document is null. Cannot export to PDF.");
                MessageBox.Show("Error exporting document: Document is null.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                Globals.AppLogger.Debug("Temporary HTML file path: {TempHtmlPath}", tempHtmlPath);

                // Save HTML content to temporary file
                Globals.AppLogger.Debug("Saving HTML content to temporary file...");
                File.WriteAllText(tempHtmlPath, document.DocumentNode.OuterHtml);
                Globals.AppLogger.Debug("Temporary HTML file written successfully.");

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
                    {
                        Globals.AppLogger.Debug("User canceled the PDF export operation.");
                        if (File.Exists(tempHtmlPath))
                        {
                            File.Delete(tempHtmlPath); // Clean up temporary HTML file
                        }
                        if (Directory.Exists(tempDir))
                        {
                            Directory.Delete(tempDir, true); // Clean up temporary directory
                        }
                        return;
                    }

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
                    progressForm.Icon = SystemIcons.Application; // Set a default icon
                    Globals.AppLogger.Debug("Progress form instantiated successfully.");

                    var progressBar = new ProgressBar
                    {
                        Dock = DockStyle.Fill,
                        Style = ProgressBarStyle.Marquee,
                        MarqueeAnimationSpeed = 50,
                        Margin = new Padding(10)
                    };
                    Globals.AppLogger.Debug("Progress bar control instantiated successfully.");

                    progressForm.Controls.Add(progressBar);
                    progressForm.Show();
                    Globals.AppLogger.Debug("Progress form shown to user.");

                    Globals.AppLogger.Debug("Triggering application events...");
                    Application.DoEvents(); // Ensure UI is updated
                    Globals.AppLogger.Debug("Application events queue complete.");

                    // Download Chromium browser if not already present
                    Globals.AppLogger.Debug("Downloading Chromium...");
                    var browserFetcher = new BrowserFetcher();
                    await browserFetcher.DownloadAsync().ConfigureAwait(false);
                    Globals.AppLogger.Debug("Chromium download complete.");

                    // Launch headless browser instance with optimized settings
                    Globals.AppLogger.Debug("Launching headless Chromium instance...");
                    browser = await Puppeteer.LaunchAsync(new LaunchOptions
                    {
                        Headless = true,
                        Args = new[] { "--no-sandbox", "--disable-setuid-sandbox", "--disable-dev-shm-usage" }
                    }).ConfigureAwait(false);
                    Globals.AppLogger.Debug("Headless Chromium instance successfully launched.");

                    // Create a new page in the browser
                    Globals.AppLogger.Debug("Setting up Chromium env...");
                    var page = await browser.NewPageAsync().ConfigureAwait(false);

                    // Set viewport size to match US Letter size (8.5 x 11 inches at 96 DPI)
                    await page.SetViewportAsync(new ViewPortOptions
                    {
                        Width = 816, // 8.5 inches * 96 DPI
                        Height = 1056 // 11 inches * 96 DPI
                    }).ConfigureAwait(false);
                    Globals.AppLogger.Debug("Chromium enviornment build complete.");

                    // Navigate to the temporary HTML file with a timeout
                    Globals.AppLogger.Debug("Navigating to temporary HTML file...");
                    await page.GoToAsync($"file://{Path.GetFullPath(tempHtmlPath)}",
                        new NavigationOptions { Timeout = 60000, WaitUntil = new[] { WaitUntilNavigation.Networkidle0 } })
                        .ConfigureAwait(false);
                    Globals.AppLogger.Debug("HTML file successfully loaded inside Chromium..");

                    // Extract background color from the document using JavaScript
                    Globals.AppLogger.Debug("Applying Javascript tweaks...");
                    if (background)
                    {
                        Globals.AppLogger.Debug("Applying colormatch Javascript code...");
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
                            Globals.AppLogger.Debug("Colormatch Javascript code successfully injected.");
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Color matching script not found: {0}", jsFilePath);
                        }
                    }

                    // Apply final document optimizations before PDF generation
                    if (optimize)
                    {
                        Globals.AppLogger.Debug("Applying Javascript PDF optimization code...");
                        string jsFilePath = Path.GetFullPath("./js/finalize.js");
                        if (File.Exists(jsFilePath))
                        {
                            string optimizationCode = File.ReadAllText(jsFilePath);
                            await page.EvaluateFunctionAsync(optimizationCode).ConfigureAwait(false);
                            Globals.AppLogger.Debug("Javascript PDF optimization code successfully injected.");
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Optimization script not found: {0}", jsFilePath);
                        }
                    }

                    // Remove shadows from elements to prevent rendering issues
                    if (!useShadows)
                    {
                        Globals.AppLogger.Debug("Applying shadow removal Javascript code...");
                        string jsFilePath = Path.GetFullPath("./js/noshadows.js");
                        if (File.Exists(jsFilePath))
                        {
                            string removeShadowsCode = File.ReadAllText(jsFilePath);
                            await page.EvaluateFunctionAsync(removeShadowsCode).ConfigureAwait(false);
                            Globals.AppLogger.Debug("Shadow removal code successfully injected.");
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
                        Globals.AppLogger.Debug("Applying HTML->PDF rescale code (scale: {Scale})...", optimizedScale);
                        string jsFilePath = Path.GetFullPath("./js/rescale.js");
                        if (File.Exists(jsFilePath))
                        {
                            string scaleCode = File.ReadAllText(jsFilePath);
                            optimizedScale = await page.EvaluateFunctionAsync<decimal>(scaleCode).ConfigureAwait(false);

                            Globals.AppLogger.Debug("Rescale code successfully injected. Newly optimized scale: {OptimizedScale}", optimizedScale);
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Rescaling script not found: {0}", jsFilePath);
                        }
                    }

                    // Generate the PDF with optimized formatting
                    Globals.AppLogger.Debug("Generating PDF file...");
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
                        PreferCSSPageSize = false,
                        Scale = optimizedScale
                    }).ConfigureAwait(false);
                    Globals.AppLogger.Debug("PDF file generated successfully.");

                    progressForm.Invoke(() =>
                    {
                         progressForm.WindowState = FormWindowState.Minimized;
                    });

                    // Log success and notify user
                    Globals.AppLogger.Information("Document exported to PDF: {0}", saveFileDialog.FileName);
                    DialogResult open = MessageBox.Show("Document exported to PDF successfully. Open File?", "Export Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (open == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe", saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log and display any errors that occur during the export process
                Globals.AppLogger.Error(ex, "Error exporting document to PDF");
                MessageBox.Show($"Error exporting document: {ex.Message}", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close progress form if it still exists.
                if (progressForm != null && !progressForm.IsDisposed)
                {
                    var form = progressForm;
                    progressForm = null;

                    form.BeginInvoke((MethodInvoker)(() =>
                    {
                        try
                        {
                            if (form.IsDisposed) return;

                            Globals.AppLogger.Debug("Closing progress form...");
                            form.Close();
                            form.Dispose();
                            Globals.AppLogger.Debug("Progress form closed successfully.");
                        }
                        catch (Exception ex)
                        {
                            Globals.AppLogger.Error(ex, "Error closing progress form.");
                        }
                    }));
                }

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
                DialogResult open = MessageBox.Show("Document exported to HTML file successfully. Open File?", "Export Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (open == DialogResult.Yes)
                {
                    Process.Start("explorer.exe", saveFileDialog.FileName);
                }
            }
        }
    }
}
