using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Info;

public partial class CertificateInfoViewer : MaterialForm
{
    private readonly CertificateProgram _certificateProgram;

    public CertificateInfoViewer(CertificateProgram certificateProgram)
    {
        InitializeComponent();

        var materialSkinManager1 = MaterialSkinManager.Instance;

        // Set this to false to disable backcolor enforcing on non-materialSkin components
        // This HAS to be set before the AddFormToManage()
        materialSkinManager1.EnforceBackcolorOnAllComponents = true;

        // MaterialSkinManager properties
        materialSkinManager1.AddFormToManage(this);
        materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

        materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
        Globals.AppLogger.Debug("Applied global color scheme to CertificateInfoViewer: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());

        _certificateProgram = certificateProgram;
    }

    private void CertificateInfoViewer_Load(object sender, EventArgs e)
    {
        certificateNameBox.Text = _certificateProgram.Certificate.CertificateName == string.Empty
            ? "None provided."
            : _certificateProgram.Certificate.CertificateName;
        issuerBox.Text = _certificateProgram.IssuingOrganization == string.Empty
            ? "None provided."
            : _certificateProgram.IssuingOrganization;
        issueDateBox.Text = _certificateProgram.Certificate.IssueDate.ToShortDateString() == string.Empty
            ? "None provided."
            : _certificateProgram.Certificate.IssueDate.ToShortDateString();
        programNameBox.Text = _certificateProgram.ProgramName == string.Empty
            ? "None provided."
            : _certificateProgram.ProgramName;
        startDateBox.Text = _certificateProgram.StartDate.ToShortDateString() == string.Empty
            ? "None provided."
            : _certificateProgram.StartDate.ToShortDateString();
        endDateBox.Text = _certificateProgram.EndDate.ToShortDateString() == string.Empty
            ? "None provided."
            : _certificateProgram.EndDate.ToShortDateString();
    }

    private void textBox_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    private void textBox_Enter(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }
}