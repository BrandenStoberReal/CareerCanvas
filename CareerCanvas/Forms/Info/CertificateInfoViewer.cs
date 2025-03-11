using CareerCanvas.Classes.Main.History;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CareerCanvas.Forms.Info
{
    public partial class CertificateInfoViewer : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private CertificateProgram certificateProgram;

        public CertificateInfoViewer(CertificateProgram certificateProgram)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);

            this.certificateProgram = certificateProgram;
        }

        private void CertificateInfoViewer_Load(object sender, EventArgs e)
        {
            certificateNameBox.Text = certificateProgram.Certificate.CertificateName == String.Empty ? "None provided." : certificateProgram.Certificate.CertificateName;
            issuerBox.Text = certificateProgram.IssuingOrganization == String.Empty ? "None provided." : certificateProgram.IssuingOrganization;
            issueDateBox.Text = certificateProgram.Certificate.IssueDate.ToShortDateString() == String.Empty ? "None provided." : certificateProgram.Certificate.IssueDate.ToShortDateString();
            programNameBox.Text = certificateProgram.ProgramName == String.Empty ? "None provided." : certificateProgram.ProgramName;
            startDateBox.Text = certificateProgram.StartDate.ToShortDateString() == String.Empty ? "None provided." : certificateProgram.StartDate.ToShortDateString();
            endDateBox.Text = certificateProgram.EndDate.ToShortDateString() == String.Empty ? "None provided." : certificateProgram.EndDate.ToShortDateString();
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}