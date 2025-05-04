using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CareerCanvas.Classes.Main.Protobuf;
using ReaLTaiizor.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Classes.Main.Misc;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Workspaces
{
    public partial class CoverLetterWorkspace : MaterialForm
    {
        private ProfessionalIdentity _identity;
        private Industry _industry;

        public CoverLetterWorkspace(ProfessionalIdentity identity, Industry industry)
        {
            InitializeComponent();
            _identity = identity;
            _industry = industry;

            var materialSkinManager1 = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager1.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager1.AddFormToManage(this);
            materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
            Globals.AppLogger.Debug("Applied global color scheme to CoverLetterWorkspace: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());
        }

        private void cvWebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // Load the HTML content into the WebView2 control
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(File.ReadAllText("./templates/coverletter/default.html"));
            CoverLetterUtils.FillDocumentData(doc, _identity, new CoverLetterInfo
            {
                CompanyName = "Example Company",
                JobTitle = "Software Engineer",
                CompanyAddress = "123 Example St.",
                CompanyCity = "Example City",
                CompanyState = "EX",
                CompanyZip = "12345",
                RecipientName = "John Doe",
                RecipientPrefix = "Mr."
            });

            cvWebView.NavigateToString(doc.DocumentNode.OuterHtml);
        }

        private void CoverLetterWorkspace_Load(object sender, EventArgs e)
        {
            cvWebView.EnsureCoreWebView2Async();
        }
    }
}
