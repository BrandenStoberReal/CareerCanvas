using CareerCanvas.Classes.Main.Protobuf;
using ReaLTaiizor.Forms;

namespace CareerCanvas.Forms.Workspaces;

public partial class ResumeWorkspace : MaterialForm
{
    public ResumeWorkspace(ProfessionalIdentity identity, Industry industry, HtmlDocument template)
    {
        InitializeComponent();

        Identity = identity;
        Industry = industry;
        Template = template;
    }

    private ProfessionalIdentity Identity { get; set; }
    private Industry Industry { get; set; }
    private HtmlDocument Template { get; set; }

    private void ResumeWorkspace_Load(object sender, EventArgs e)
    {
        // Load the webview runtime
        resumeViewer.EnsureCoreWebView2Async();
    }
}