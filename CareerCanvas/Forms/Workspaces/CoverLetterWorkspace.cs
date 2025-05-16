using CareerCanvas.Classes.Main.Misc;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Forms.InputDialogs;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Forms.Workspaces
{
    public partial class CoverLetterWorkspace : MaterialForm
    {
        private ProfessionalIdentity _identity;
        private Industry _industry;
        private CoverLetterInfo _coverLetterInfo = new CoverLetterInfo();
        public string _currentTemplatePath = string.Empty;
        public HtmlDocument _currentDocument = new HtmlDocument();
        private bool _webViewInitialized = false;

        /// <summary>
        /// Constructor for the CoverLetterWorkspace.
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="industry"></param>
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

        /// <summary>
        /// Shows the Cover Letter Info dialog.
        /// </summary>
        private void ShowCoverLetterInfoDialog()
        {
            // Now show the dialog separately from WebView2 initialization
            this.WindowState = FormWindowState.Minimized;

            CoverLetterInfoForm coverLetterInfoForm = new CoverLetterInfoForm(ref _coverLetterInfo);
            coverLetterInfoForm.ShowDialog();

            this.WindowState = FormWindowState.Normal;

            // Update the WebView with the data
            if (_webViewInitialized)
            {
                CoverLetterUtils.FillDocumentData(_currentDocument, _identity, _coverLetterInfo);
                cvWebView.NavigateToString(_currentDocument.DocumentNode.OuterHtml);
            }
        }

        /// <summary>
        /// Handles the WebView2 initialization completed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cvWebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // Only handle the WebView2 initialization part here
            if (e.IsSuccess)
            {
                // Load the HTML content into the WebView2 control
                _currentDocument.LoadHtml(File.ReadAllText("./templates/coverletter/default.html"));
                _currentTemplatePath = Path.GetFullPath("./templates/coverletter/default.html");

                // Mark initialization as complete
                _webViewInitialized = true;

                // Trigger UI update on the main thread
                BeginInvoke(new Action(ShowCoverLetterInfoDialog));
            }
            else
            {
                MessageBox.Show("Failed to initialize WebView2: " + e.InitializationException.Message);
            }
        }

        /// <summary>
        /// Handles the form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoverLetterWorkspace_Load(object sender, EventArgs e)
        {
            cvWebView.EnsureCoreWebView2Async();
        }

        /// <summary>
        /// Handles the edit info button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editInfoButton_Click(object sender, EventArgs e)
        {
            CoverLetterInfoForm coverLetterInfoForm = new CoverLetterInfoForm(ref _coverLetterInfo);
            coverLetterInfoForm.ShowDialog();
            InputUtils.ClearActiveControl(this);
        }

        /// <summary>
        /// Handles the change template button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeTemplateButton_Click(object sender, EventArgs e)
        {
            ChangeCVTemplateForm changeTemplateForm = new ChangeCVTemplateForm(this, _identity, ref _currentDocument, _coverLetterInfo);
            changeTemplateForm.ShowDialog();
            cvWebView.NavigateToString(_currentDocument.DocumentNode.OuterHtml);
            InputUtils.ClearActiveControl(this);
        }

        private void exportToPdfButton_Click(object sender, EventArgs e)
        {
            DocumentUtilities.SaveToPdfAsync(_currentDocument, backgroundToggle.Checked, optimizeToggle.Checked, useShadowsToggle.Checked, scaleToggle.Checked, "cover_letter.pdf");
            InputUtils.ClearActiveControl(this);
        }

        private void exportToHtmlButton_Click(object sender, EventArgs e)
        {
            DocumentUtilities.SaveToFile(_currentDocument, "cover_letter.html");
            InputUtils.ClearActiveControl(this);
        }

        private void paragraphsSlider_onValueChanged(object sender, int newValue)
        {
            if (newValue < 1)
            {
                paragraphsSlider.Value = 1;
            }
        }
    }
}
