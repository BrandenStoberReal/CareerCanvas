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

    /// <summary>
    /// Initializes a new instance of the <see cref="ResumeWorkspace"/> class.
    /// </summary>
    /// <param name="identity"></param>
    /// <param name="industry"></param>
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
    /// Event handler for the ResumeWorkspace form load event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ResumeWorkspace_Load(object sender, EventArgs e)
    {
        // Load the webview runtime
        resumeViewer.EnsureCoreWebView2Async();
        Globals.AppLogger.Debug("WebView2 runtime loaded asyncronously in ResumeWorkspace.");

        // Set up tooltips
        ToolTip toolTip = new ToolTip();

        toolTip.SetToolTip(loadTemplateButton, "Change the active resume template.");
        toolTip.SetToolTip(openTemplateFolderButton, "Open the template folder in Windows explorer.");
        toolTip.SetToolTip(exportHtmlButton, "Export the resume to HTML format.");
        toolTip.SetToolTip(exportPdfButton, "Export the resume to PDF format.");
        toolTip.SetToolTip(backgroundToggle, "Enable or disable background color matching in the PDF.");
        toolTip.SetToolTip(optimizeToggle, "Enable or disable final document optimizations. (EXPERIMENTAL)");
        toolTip.SetToolTip(scaleToggle, "Enable or disable automatic scaling of the resume to fit the page.");
        toolTip.SetToolTip(useShadowsToggle, "Enable or disable shadows in the resume template.");

        Globals.AppLogger.Debug("Tooltips successfully bound in ResumeWorkspace.");
    }

    /// <summary>
    /// Event handler for the open template folder button click event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void openTemplateFolderButton_Click(object sender, EventArgs e)
    {
        FolderUtils.OpenFolder(Path.GetFullPath("./templates/resume"));
        Globals.AppLogger.Debug("Opened template folder in ResumeWorkspace.");
    }

    /// <summary>
    /// Event handler for the WebView2 initialization completed event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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

    /// <summary>
    /// Event handler for material card clicking.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void materialCard1_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    /// Event handler for material card clicking.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void materialCard2_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    /// Event handler for the load template button click event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void loadTemplateButton_Click(object sender, EventArgs e)
    {
        Globals.AppLogger.Information("User requested to change the active resume template.");
        ChangeResumeTemplateForm changeResumeTemplateForm = new ChangeResumeTemplateForm(this, Identity, Industry);
        changeResumeTemplateForm.ShowDialog();

        Globals.AppLogger.Information("User selected a new resume template. Refreshing WebView2 to reflect changes.");
        resumeViewer.NavigateToString(Template.DocumentNode.OuterHtml);
    }

    /// <summary>
    /// Event handler for the export HTML button click event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void exportHtmlButton_Click(object sender, EventArgs e)
    {
        DocumentUtilities.SaveToFile(Template, "resume.html");
        Globals.AppLogger.Information("User exported resume to HTML format.");
    }

    /// <summary>
    /// Event handler for the export PDF button click event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void exportPdfButton_Click(object sender, EventArgs e)
    {
        DocumentUtilities.SaveToPdfAsync(Template, backgroundToggle.Checked, optimizeToggle.Checked, useShadowsToggle.Checked, scaleToggle.Checked, "resume.pdf");
        Globals.AppLogger.Information("User exported resume to PDF format.");
    }

    /// <summary>
    /// Event handler for the table layout click event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tableLayoutPanel1_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    /// Event handler for the table layout click event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tableLayoutPanel2_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }
}