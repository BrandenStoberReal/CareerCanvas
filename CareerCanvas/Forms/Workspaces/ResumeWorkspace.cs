using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Forms.Workspaces;

public partial class ResumeWorkspace : MaterialForm
{
    private ProfessionalIdentity Identity { get; set; }
    private Industry Industry { get; set; }
    private HtmlDocument Template { get; set; }

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
    }

    private void ResumeWorkspace_Load(object sender, EventArgs e)
    {
        // Load the webview runtime
        resumeViewer.EnsureCoreWebView2Async();
    }

    private void openTemplateFolderButton_Click(object sender, EventArgs e)
    {
        FolderUtils.OpenFolder(Path.GetFullPath("./templates/resume"));
    }

    private void resumeViewer_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
    {
        // Load default template
        Template = new HtmlDocument();
        Template.LoadHtml(File.ReadAllText("./templates/resume/default.html"));

        // Replace placeholders with identity data
        Template.GetElementbyId("name").InnerHtml = $"{Identity.FirstName} {Identity.MiddleName} {Identity.LastName}";

        // Address fill
        if (Identity.Address != String.Empty)
        {
            Template.GetElementbyId("address").InnerHtml = "Address: " + Identity.Address;
        }
        else
        {
            Template.GetElementbyId("address").Remove();
        }

        // Email fill
        if (Identity.Email != String.Empty)
        {
            Template.GetElementbyId("email").InnerHtml = "Email: " + Identity.Email;
        }
        else
        {
            Template.GetElementbyId("email").Remove();
        }

        // Phone number fill
        if (Identity.PhoneNumber != String.Empty)
        {
            Template.GetElementbyId("phonenumber").InnerHtml = "Phone: " + Identity.PhoneNumber;
        }
        else
        {
            Template.GetElementbyId("phonenumber").Remove();
        }

        // Linkedin fill
        if (Identity.LinkedIn != String.Empty)
        {
            Template.GetElementbyId("linkedin").InnerHtml = "LinkedIn: " + Identity.LinkedIn;
        }
        else
        {
            Template.GetElementbyId("linkedin").Remove();
        }

        // Load the template into the webview
        resumeViewer.NavigateToString(Template.DocumentNode.OuterHtml);
    }

    private void materialCard1_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void materialCard2_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }
}