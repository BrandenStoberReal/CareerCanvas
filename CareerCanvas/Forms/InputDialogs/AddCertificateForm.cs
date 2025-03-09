using CareerCanvas.Classes.Main.History;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Globalization;

namespace CareerCanvas.Forms.InputDialogs
{
    public partial class AddCertificateForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public List<CertificateProgram> masterList = new List<CertificateProgram>();

        public AddCertificateForm(List<CertificateProgram> masterList)
        {
            InitializeComponent();

            this.masterList = masterList;

            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);
        }

        private void AddCertificateForm_Load(object sender, EventArgs e)
        {
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            if (programNameBox.Text == "" || issuerBox.Text == "" || certificateIssueDateBox.Text == "" || certificateTitleBox.Text == "" || programStartDateBox.Text == "" || programEndDateBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields before adding a certificate program.");
                return;
            }

            DateTime startDate;
            DateTime endDate;
            DateTime issueDate;
            try
            {
                startDate = DateTime.ParseExact(programStartDateBox.Text, "MM/yyyy", CultureInfo.InvariantCulture);
                endDate = DateTime.ParseExact(programEndDateBox.Text, "MM/yyyy", CultureInfo.InvariantCulture);
                issueDate = DateTime.ParseExact(certificateIssueDateBox.Text, "MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid date format. Please use MM/yyyy.");
                return;
            }

            CertificateProgram certificateProgram = new CertificateProgram(programNameBox.Text, issuerBox.Text, startDate, endDate);
            Certificate certificate = new Certificate(certificateProgram, certificateTitleBox.Text, issueDate);
            masterList.Add(certificateProgram);
            this.Close();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void AddCertificateForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}