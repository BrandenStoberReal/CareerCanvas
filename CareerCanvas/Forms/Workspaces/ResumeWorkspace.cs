using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Forms.InputDialogs;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System.ComponentModel;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Forms.Workspaces;

public partial class ResumeWorkspace : MaterialForm
{
    private ProfessionalIdentity Identity { get; set; }
    private Industry Industry { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public HtmlDocument Template { get; set; }

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
}