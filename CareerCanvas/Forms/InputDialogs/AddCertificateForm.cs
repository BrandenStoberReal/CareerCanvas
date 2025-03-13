using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
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

            materialSkinManager.ColorScheme = Globals.AppColorScheme;
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

            if (endDate != issueDate)
            {
                DialogResult result = MessageBox.Show("The issue date of the certificate is not the same as the end date of the program. Proceed anyway?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            CertificateProgram certificateProgram = new CertificateProgram();
            certificateProgram.ProgramName = programNameBox.Text;
            certificateProgram.IssuingOrganization = issuerBox.Text;
            certificateProgram.StartDate = startDate;
            certificateProgram.EndDate = endDate;

            Certificate certificate = new Certificate();
            certificate.CertificateName = certificateTitleBox.Text;
            certificate.IssueDate = issueDate;

            certificateProgram.Certificate = certificate;
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

        private void AddCertificateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Changes not saved! Exit anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}