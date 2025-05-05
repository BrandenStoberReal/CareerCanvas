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
using CareerCanvas.Forms.InputDialogs;

namespace CareerCanvas.Forms.Workspaces
{
    public partial class CoverLetterWorkspace : MaterialForm
    {
        private ProfessionalIdentity _identity;
        private Industry _industry;
        private CoverLetterInfo _coverLetterInfo = new CoverLetterInfo();
        private string _currentTemplateName = string.Empty;

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
            this.WindowState = FormWindowState.Minimized;
            CoverLetterInfoForm coverLetterInfoForm = new CoverLetterInfoForm(ref _coverLetterInfo);
            coverLetterInfoForm.ShowDialog();
            this.WindowState = FormWindowState.Normal;

            // Load the HTML content into the WebView2 control
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(File.ReadAllText("./templates/coverletter/default.html"));
            _currentTemplateName = "default";
            CoverLetterUtils.FillDocumentData(doc, _identity, _coverLetterInfo);

            cvWebView.NavigateToString(doc.DocumentNode.OuterHtml);
        }

        private void CoverLetterWorkspace_Load(object sender, EventArgs e)
        {
            cvWebView.EnsureCoreWebView2Async();
        }
    }
}
