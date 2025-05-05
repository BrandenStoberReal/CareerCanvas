using CareerCanvas.Classes.Main.Misc;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Forms.Workspaces;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Forms.InputDialogs
{
    public partial class ChangeCVTemplateForm : MaterialForm
    {
        private CoverLetterWorkspace parentForm;
        private ProfessionalIdentity identity;
        private HtmlDocument parentDoc;
        private CoverLetterInfo coverLetterInfo;
        public ChangeCVTemplateForm(CoverLetterWorkspace parent, ProfessionalIdentity identity, ref HtmlDocument doc, CoverLetterInfo info)
        {
            InitializeComponent();

            parentForm = parent;
            this.identity = identity;
            this.coverLetterInfo = info;

            var materialSkinManager1 = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager1.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager1.AddFormToManage(this);
            materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
            Globals.AppLogger.Debug("Applied global color scheme to ChangeCVTemplateForm: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());

            // Set the parent document
            parentDoc = doc;
        }

        private void ChangeResumeTemplateForm_Load(object sender, EventArgs e)
        {
            // Ensure previewer is loaded
            previewWebView.EnsureCoreWebView2Async();

            // Load templates into list
            foreach (string file in Directory.GetFiles("./templates/coverletter"))
            {
                if (file.EndsWith(".html"))
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    MaterialListBoxItem item = new MaterialListBoxItem(Globals.textInfo.ToTitleCase(fileName).Replace("_", " "));
                    item.Tag = fileName;
                    templateListBox.Items.Add(item);
                }
            }

            // Select the current template
            foreach (MaterialListBoxItem item in templateListBox.Items)
            {
                if (item.Tag.ToString() == parentForm._currentTemplateName)
                {
                    templateListBox.SelectedItem = item;
                    break;
                }
            }
        }

        private void templateListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            // Load the selected template
            string templatePath = Path.Combine("./templates/coverletter", selectedItem.Tag.ToString() + ".html");
            HtmlDocument template = new HtmlDocument();
            template.LoadHtml(File.ReadAllText(templatePath));
            // Fill the document with identity data
            CoverLetterUtils.FillDocumentData(template, identity, coverLetterInfo);
            // Load the filled template into the webview
            previewWebView.NavigateToString(template.DocumentNode.OuterHtml);
        }

        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            // Load the selected template
            string templatePath = Path.Combine("./templates/coverletter", templateListBox.SelectedItem.Tag.ToString() + ".html");
            parentDoc.LoadHtml(File.ReadAllText(templatePath));
            CoverLetterUtils.FillDocumentData(parentDoc, identity, coverLetterInfo);

            parentForm._currentTemplateName = Path.GetFileNameWithoutExtension(templatePath);
            Close();
        }

        private void previewWebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            previewWebView.NavigateToString(parentDoc.DocumentNode.OuterHtml);
        }

        private void materialCard1_Click(object sender, EventArgs e)
        {
        }
    }
}