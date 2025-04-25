using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Forms.InputDialogs;
using Microsoft.VisualBasic.FileIO;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System.ComponentModel;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Forms.Workspaces;

public partial class ResumeWorkspace : MaterialForm
{
    private ProfessionalIdentity Identity { get; set; }
    private Industry Industry { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public HtmlDocument Template { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string TemplatePath { get; set; } = Path.Combine("./templates/resume", "default.html");

    public ResumeWorkspace(ProfessionalIdentity identity, Industry industry)
    {
        InitializeComponent();

        Identity = identity;
        Industry = industry;

        var materialSkinManager1 = MaterialSkinManager.Instance;

        // Set this to false to disable backcolor enforcing on non-materialSkin components
        // This HAS to be set before the AddFormToManage()
        materialSkinManager1.EnforceBackcolorOnAllComponents = true;

        // MaterialSkinManager properties
        materialSkinManager1.AddFormToManage(this);
        materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

        materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
        Globals.AppLogger.Debug("Applied global color scheme to ResumeWorkspace: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());
    }

    /// <summary>
    /// Exports the current resume to an HTML file.
    /// </summary>
    /// <remarks>
    /// This method opens a save file dialog allowing the user to choose a location and filename
    /// for the exported HTML file. If the user confirms the dialog, the method writes the current
    /// HTML template content to the specified file. Success or failure is logged and the user is
    /// notified via a message box.
    /// </remarks>
    private void ExportToHtml()
    {
        // Create and configure the save file dialog
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "HTML Files (*.html;*.htm)|*.html;*.htm|All Files (*.*)|*.*";
        saveFileDialog.DefaultExt = "html";
        saveFileDialog.Title = "Export Resume to HTML";
        saveFileDialog.FileName = "resume.html";
        // Set default save location to the user's Downloads folder
        saveFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        // Show the dialog and proceed if the user clicks OK
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                // Get the HTML content from the template
                string htmlContent = Template.DocumentNode.OuterHtml;

                // Write the HTML content to the selected file
                File.WriteAllText(saveFileDialog.FileName, htmlContent);

                // Log the successful export
                Globals.AppLogger.Information($"Resume exported to HTML: {saveFileDialog.FileName}");

                // Notify the user of successful export
                MessageBox.Show("Resume exported to HTML successfully.", "Export Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Log any errors that occur during export
                Globals.AppLogger.Error($"Error exporting resume to HTML: {ex.Message}");

                // Display error message to the user
                MessageBox.Show($"Error exporting resume: {ex.Message}", "Export Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    /// <summary>
    /// Exports the current resume template to a PDF file.
    /// This method handles the entire export process from converting HTML to PDF,
    /// including temporary file management, background color extraction, and PDF styling.
    /// </summary>
    /// <remarks>
    /// The method uses Puppeteer Sharp to render HTML content as PDF with consistent formatting.
    /// It creates temporary files during the process and cleans them up afterward.
    /// </remarks>
    private async void ExportToPDF()
    {
        // Create a temporary directory to store the HTML file
        var tempDir = Path.GetFullPath("./resumetmp");
        Directory.CreateDirectory(tempDir);
        var tempHtmlPath = Path.Combine(tempDir, "resumetmp.html");

        // Save HTML content to temporary file
        File.WriteAllText(tempHtmlPath, Template.DocumentNode.OuterHtml);

        // Configure and display save file dialog
        var saveFileDialog = new SaveFileDialog
        {
            Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*",
            DefaultExt = "pdf",
            Title = "Export Resume to PDF",
            FileName = "resume.pdf",
            InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                // Create and show progress form to indicate PDF generation is in process
                var progressForm = new Form
                {
                    Text = "Generating PDF...",
                    Size = new System.Drawing.Size(250, 80),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };
                progressForm.Controls.Add(new ProgressBar { Dock = DockStyle.Fill, Style = ProgressBarStyle.Marquee });
                progressForm.Show();

                // Download Chromium browser if not already present (required by Puppeteer)
                var browserFetcher = new BrowserFetcher();
                await browserFetcher.DownloadAsync();

                // Launch headless browser instance
                var browser = await Puppeteer.LaunchAsync(new LaunchOptions
                {
                    Headless = true
                });

                // Create a new page in the browser
                var page = await browser.NewPageAsync();

                // Set viewport size to match US Letter size (8.5 x 11 inches at 96 DPI)
                await page.SetViewportAsync(new ViewPortOptions
                {
                    Width = 816, // 8.5 inches * 96 DPI
                    Height = 1056 // 11 inches * 96 DPI
                });

                // Navigate to the temporary HTML file
                await page.GoToAsync(Path.GetFullPath(tempHtmlPath));

                // Extract background color from the document using JavaScript
                var backgroundColor = await page.EvaluateFunctionAsync<string>(@"() => {
                    // Try to get the background color from various elements
                    const bodyBg = window.getComputedStyle(document.body).backgroundColor;
                    if (bodyBg && bodyBg !== 'rgba(0, 0, 0, 0)' && bodyBg !== 'transparent') {
                        return bodyBg;
                    }

                    // Check if there's a main container with background
                    const mainContainers = document.querySelectorAll('main, .container, .content, #content, #main');
                    for (const container of mainContainers) {
                        const containerBg = window.getComputedStyle(container).backgroundColor;
                        if (containerBg && containerBg !== 'rgba(0, 0, 0, 0)' && containerBg !== 'transparent') {
                            return containerBg;
                        }
                    }

                    // Default to white if no background found
                    return 'rgb(255, 255, 255)';
                }");

                // Add custom CSS for optimal PDF rendering while preserving original styling
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
                });

                // Apply final document optimizations before PDF generation
                await page.EvaluateFunctionAsync(@"
                    () => {
                        // Get header element once
                        const header = document.querySelector('header');
        
                        // Remove all shadow effects throughout the document
                        document.querySelectorAll('*').forEach(element => {
                            // Remove box-shadow from all elements
                            element.style.boxShadow = 'none';
            
                            // Remove text-shadow from all elements
                            element.style.textShadow = 'none';
            
                            // Remove filter shadows (drop-shadow)
                            if (element.style.filter) {
                                element.style.filter = element.style.filter.replace(/drop-shadow\([^)]*\)/g, '');
                            }
            
                            // Remove -webkit-box-shadow for Safari compatibility
                            element.style.webkitBoxShadow = 'none';
                        });
        
                        // Ensure the header and page container have no shadows
                        if (header) {
                            header.style.boxShadow = 'none';
                            header.style.webkitBoxShadow = 'none';
                        }
        
                        document.querySelectorAll('.page, .container, main, .content').forEach(container => {
                            container.style.boxShadow = 'none';
                            container.style.webkitBoxShadow = 'none';
                        });
        
                        // Remove any shadow-related classes
                        document.querySelectorAll('.shadow, .box-shadow, .card-shadow').forEach(element => {
                            element.classList.remove('shadow', 'box-shadow', 'card-shadow');
                        });
        
                        // Special handling for elegant_cards template
                        const isElegantCardsTemplate = document.body.innerHTML.includes('elegant_cards') || 
                                                      document.querySelector('link[href*=""elegant_cards""]') !== null ||
                                                      document.documentElement.outerHTML.includes('elegant_cards');
        
                        // Fix header spacing issues - using the already declared header variable
                        if (header) {
                            header.style.marginBottom = isElegantCardsTemplate ? '0' : '5px';
                            header.style.paddingBottom = isElegantCardsTemplate ? '0' : '5px';
                            header.style.pageBreakAfter = 'avoid';
                        }

                        // For elegant_cards template, directly select main content container
                        if (isElegantCardsTemplate) {
                            // Specific targeting for elegant_cards template
                            const mainContent = document.querySelector('.resume-body, .content-area, main');
                            if (mainContent) {
                                mainContent.style.marginTop = '0';
                                mainContent.style.paddingTop = '0';
                                // Use negative margin to eliminate any gap
                                mainContent.style.marginTop = '-10px';
                                mainContent.style.pageBreakBefore = 'avoid';
                            }
            
                            // Target card elements in elegant_cards template
                            document.querySelectorAll('.card, .section-card, .content-card').forEach(card => {
                                card.style.marginBottom = '8px';
                                card.style.pageBreakInside = 'avoid';
                            });
                        } else {
                            // Standard handling for other templates
                            const firstSectionSelectors = [
                                '.main-content:first-child', 
                                '.section:first-child',
                                'main > section:first-child',
                                'main > div:first-child',
                                '.container > section:first-child',
                                '.container > div:first-child',
                                'body > section:first-child',
                                'body > div:not(header):first-of-type'
                            ];
            
                            firstSectionSelectors.forEach(selector => {
                                const element = document.querySelector(selector);
                                if (element) {
                                    element.style.marginTop = '5px';
                                    element.style.paddingTop = '5px';
                                }
                            });
                        }

                        // Aggressive gap reduction for all templates
                        document.querySelectorAll('section, article, div, main').forEach(element => {
                            // Skip elements with position:absolute as they don't affect normal flow
                            const position = window.getComputedStyle(element).position;
                            if (position === 'absolute' || position === 'fixed') {
                                return;
                            }
            
                            // Reduce excessive margins and paddings
                            if (parseFloat(window.getComputedStyle(element).marginTop) > 15) {
                                element.style.marginTop = isElegantCardsTemplate ? '5px' : '10px';
                            }
                            if (parseFloat(window.getComputedStyle(element).marginBottom) > 15) {
                                element.style.marginBottom = isElegantCardsTemplate ? '5px' : '10px';
                            }
                            if (parseFloat(window.getComputedStyle(element).paddingTop) > 20) {
                                element.style.paddingTop = isElegantCardsTemplate ? '10px' : '15px';
                            }
                            if (parseFloat(window.getComputedStyle(element).paddingBottom) > 20) {
                                element.style.paddingBottom = isElegantCardsTemplate ? '10px' : '15px';
                            }
                        });

                        // Real-time gap detection and fixing
                        const allVisibleElements = Array.from(document.body.querySelectorAll('*')).filter(el => {
                            const style = window.getComputedStyle(el);
                            return style.display !== 'none' && 
                                   style.visibility !== 'hidden' && 
                                   style.opacity !== '0' &&
                                   el.offsetParent !== null;
                        });
        
                        // Sort elements by their vertical position
                        allVisibleElements.sort((a, b) => {
                            return a.getBoundingClientRect().top - b.getBoundingClientRect().top;
                        });
        
                        // Check for gaps between consecutive elements
                        for (let i = 0; i < allVisibleElements.length - 1; i++) {
                            const current = allVisibleElements[i];
                            const next = allVisibleElements[i + 1];
            
                            // Skip elements that are not in the normal flow
                            if (window.getComputedStyle(current).position === 'absolute' || 
                                window.getComputedStyle(next).position === 'absolute') {
                                continue;
                            }
            
                            const currentRect = current.getBoundingClientRect();
                            const nextRect = next.getBoundingClientRect();
            
                            // Check if next element is actually below and not a child
                            if (nextRect.top > currentRect.bottom && !current.contains(next) && !next.contains(current)) {
                                const gap = nextRect.top - currentRect.bottom;
                
                                // If gap is excessive (>20px), reduce it
                                if (gap > 20) {
                                    // Apply margin adjustment based on computed styles
                                    const currentMarginBottom = parseFloat(window.getComputedStyle(current).marginBottom);
                                    const nextMarginTop = parseFloat(window.getComputedStyle(next).marginTop);
                    
                                    if (currentMarginBottom > 0) {
                                        current.style.marginBottom = Math.max(0, currentMarginBottom - (gap/2)) + 'px';
                                    }
                                    if (nextMarginTop > 0) {
                                        next.style.marginTop = Math.max(0, nextMarginTop - (gap/2)) + 'px';
                                    }
                                }
                            }
                        }

                        // Make sure all images have appropriate sizing
                        document.querySelectorAll('img').forEach(img => {
                            img.style.maxWidth = '100%';
                            img.style.height = 'auto';
                        });

                        // Page break controls that work with any template
                        document.querySelectorAll('section, article, .card, .section-card, .content-card').forEach(element => {
                            if (element.textContent.trim().length > 0 || element.querySelector('img')) {
                                element.style.pageBreakInside = 'avoid';
                            }
                        });
        
                        // Keep headings with their content
                        document.querySelectorAll('h1, h2, h3, h4, h5, h6').forEach(heading => {
                            heading.style.pageBreakAfter = 'avoid';
            
                            // Also ensure the next element stays with its heading
                            const nextElement = heading.nextElementSibling;
                            if (nextElement) {
                                nextElement.style.pageBreakBefore = 'avoid';
                            }
                        });
                    }
                ");


                // Analyze content and calculate optimal scale to maximize use of page
                var optimizedScale = await page.EvaluateFunctionAsync<decimal>(@"
                    () => {
                        // Get the content dimensions
                        const body = document.body;
                        const html = document.documentElement;
                        const contentHeight = Math.max(body.scrollHeight, body.offsetHeight, html.clientHeight, html.scrollHeight, html.offsetHeight);
                        const contentWidth = Math.max(body.scrollWidth, body.offsetWidth, html.clientWidth, html.scrollWidth, html.offsetWidth);

                        // Letter size dimensions in pixels at 96 DPI
                        const letterHeight = 1056; // 11 inches
                        const letterWidth = 816; // 8.5 inches

                        // Account for margins (0.25 inch on each side)
                        const marginPixels = 24; // 0.25 inches * 96 DPI
                        const availableHeight = letterHeight - (marginPixels * 2);
                        const availableWidth = letterWidth - (marginPixels * 2);

                        // Vertical and horizontal scaling factor
                        const heightScale = availableHeight / contentHeight;
                        const widthScale = availableWidth / contentWidth;

                        // Use the smaller scale to ensure content fits in both dimensions
                        let optimalScale = Math.min(heightScale, widthScale);

                        // Cap the scale to reasonable limits
                        optimalScale = Math.min(1.0, optimalScale); // Don't scale up beyond 100%
                        optimalScale = Math.max(0.75, optimalScale); // Don't scale down below 75%
        
                        return optimalScale;
                    }
                ");


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
                });

                // Clean up browser resources
                await browser.CloseAsync();

                // Close the progress indicator
                progressForm.Close();

                // Log success and notify user
                Globals.AppLogger.Information($"Resume exported to PDF: {saveFileDialog.FileName}");
                MessageBox.Show("Resume exported to PDF successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Log and display any errors that occur during the export process
                Globals.AppLogger.Error($"Error exporting resume to PDF: {ex.Message}");
                MessageBox.Show($"Error exporting resume: {ex.Message}", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up temporary directory regardless of success or failure
                try { Directory.Delete(tempDir, true); }
                catch (Exception ex) { Globals.AppLogger.Error($"Error cleaning temporary directory: {ex.Message}"); }
            }
        }
    }


    private void ResumeWorkspace_Load(object sender, EventArgs e)
    {
        // Load the webview runtime
        resumeViewer.EnsureCoreWebView2Async();
        Globals.AppLogger.Debug("WebView2 runtime loaded asyncronously in ResumeWorkspace.");
    }

    private void openTemplateFolderButton_Click(object sender, EventArgs e)
    {
        FolderUtils.OpenFolder(Path.GetFullPath("./templates/resume"));
        Globals.AppLogger.Debug("Opened template folder in ResumeWorkspace.");
    }

    private void resumeViewer_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
    {
        // Load default template
        Template = new HtmlDocument();
        Template.LoadHtml(File.ReadAllText("./templates/resume/default.html"));
        Globals.AppLogger.Information("Loaded default resume template into HtmlAgilityPack.");

        // Replace placeholders with identity data
        ResumeUtils.FillDocumentData(Template, Identity, Industry);
        Globals.AppLogger.Information("Filled placeholder resume template with identity data.");

        // Load the template into the webview
        resumeViewer.NavigateToString(Template.DocumentNode.OuterHtml);
        Globals.AppLogger.Information("Loaded resume template into WebView2.");
    }

    private void materialCard1_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void materialCard2_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void loadTemplateButton_Click(object sender, EventArgs e)
    {
        Globals.AppLogger.Information("User requested to change the active resume template.");
        ChangeResumeTemplateForm changeResumeTemplateForm = new ChangeResumeTemplateForm(this, Identity, Industry);
        changeResumeTemplateForm.ShowDialog();

        Globals.AppLogger.Information("User selected a new resume template. Refreshing WebView2 to reflect changes.");
        resumeViewer.NavigateToString(Template.DocumentNode.OuterHtml);
    }

    private void exportHtmlButton_Click(object sender, EventArgs e)
    {
        ExportToHtml();
        Globals.AppLogger.Information("User exported resume to HTML format.");
    }

    private void exportPdfButton_Click(object sender, EventArgs e)
    {
        ExportToPDF();
        Globals.AppLogger.Information("User exported resume to PDF format.");
    }
}