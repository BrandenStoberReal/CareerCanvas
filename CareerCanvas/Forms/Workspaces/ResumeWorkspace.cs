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

                // Navigate to the temporary HTML file
                await page.GoToAsync(Path.GetFullPath(tempHtmlPath));

                // Extract background color from the document using JavaScript
                // The function tries to find the most appropriate background color from various elements
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

                // Add custom CSS to ensure consistent PDF rendering
                // This CSS handles page formatting, prevents awkward page breaks,
                // and maintains consistent styling across different templates
                await page.AddStyleTagAsync(new AddTagOptions
                {
                    Content = $@"
                    /* Ensure consistent background color */
                    @page {{
                        size: letter;
                        margin: 0.3in;
                        background-color: {backgroundColor};
                    }}

                    body {{
                        font-size: 11px;
                        line-height: 1.3;
                        background-color: {backgroundColor} !important;
                        margin: 0;
                        padding: 0.4in;
                    }}

                    /* Ensure the html element has the background as well */
                    html {{
                        background-color: {backgroundColor} !important;
                    }}

                    /* Universal selectors to prevent page breaks within elements */
                    div, section, article, aside, nav, header, footer {{
                        page-break-inside: avoid;
                    }}

                    /* Headings should keep content with them */
                    h1, h2, h3, h4, h5, h6 {{
                        page-break-after: avoid;
                        margin-top: 5px;
                        margin-bottom: 5px;
                    }}

                    /* Paragraphs and list items should not break */
                    p, li, dt, dd, tr, th, td {{
                        page-break-inside: avoid;
                    }}

                    /* Lists should stay with their headers */
                    ul, ol, dl, table {{
                        page-break-before: avoid;
                        page-break-inside: avoid;
                    }}

                    /* Anchor common resume section containers by common attributes */
                    [class*='section'], [class*='entry'], [class*='item'],
                    [id*='section'], [id*='entry'], [id*='item'],
                    [class*='experience'], [class*='education'], [class*='skill'], [class*='certificate'],
                    [id*='experience'], [id*='education'], [id*='skill'], [id*='certificate'] {{
                        page-break-inside: avoid;
                    }}

                    /* Images should not break */
                    img {{
                        page-break-inside: avoid;
                    }}
                "
                });

                // Apply additional dynamic styles using JavaScript
                // This ensures consistent background color and helps identify and format resume sections
                await page.EvaluateFunctionAsync($@"() => {{
                // Apply consistent background color to all top-level elements
                document.body.style.backgroundColor = '{backgroundColor}';
                document.documentElement.style.backgroundColor = '{backgroundColor}';

                // Apply page-break-inside: avoid to all div elements with children
                document.querySelectorAll('div').forEach(div => {{
                    if (div.children.length > 0 && div.children.length < 5) {{
                        div.style.pageBreakInside = 'avoid';
                    }}
                }});

                // Find resume sections by identifying groups of elements
                const sections = Array.from(document.body.children).filter(el =>
                    el.tagName !== 'SCRIPT' &&
                    el.tagName !== 'STYLE' &&
                    el.offsetHeight > 10);

                sections.forEach(section => {{
                    section.style.pageBreakInside = 'avoid';
                }});
            }}");

                // Generate the PDF with specific formatting options
                await page.PdfAsync(saveFileDialog.FileName, new PdfOptions
                {
                    Format = PaperFormat.Letter,
                    PrintBackground = true,
                    MarginOptions = new MarginOptions
                    {
                        Left = "0.5in",
                        Top = "0.5in",
                        Bottom = "0.5in",
                        Right = "0.5in"
                    },
                    PreferCSSPageSize = true,
                    Scale = 0.95M  // Slightly scale down to ensure content fits
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