using System.Globalization;
using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.InputDialogs;

public partial class AddCertificateForm : MaterialForm
{
    private readonly List<CertificateProgram> _masterList;

    public AddCertificateForm(List<CertificateProgram> masterList)
    {
        InitializeComponent();

        _masterList = masterList;

        var materialSkinManager1 = MaterialSkinManager.Instance;

        // Set this to false to disable backcolor enforcing on non-materialSkin components
        // This HAS to be set before the AddFormToManage()
        materialSkinManager1.EnforceBackcolorOnAllComponents = true;

        // MaterialSkinManager properties
        materialSkinManager1.AddFormToManage(this);
        materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

        materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
    }

    private void AddCertificateForm_Load(object sender, EventArgs e)
    {
    }

    private void addJobButton_Click(object sender, EventArgs e)
    {
        if (programNameBox.Text == "" || issuerBox.Text == "" || certificateIssueDateBox.Text == "" ||
            certificateTitleBox.Text == "" || programStartDateBox.Text == "" || programEndDateBox.Text == "")
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
            var result =
                MessageBox.Show(
                    "The issue date of the certificate is not the same as the end date of the program. Proceed anyway?",
                    "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
        }

        var certificateProgram = new CertificateProgram
        {
            ProgramName = programNameBox.Text,
            IssuingOrganization = issuerBox.Text,
            StartDate = startDate,
            EndDate = endDate
        };

        var certificate = new Certificate
        {
            CertificateName = certificateTitleBox.Text,
            IssueDate = issueDate
        };

        certificateProgram.Certificate = certificate;
        _masterList.Add(certificateProgram);
        Close();
    }

    private void discardButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void flowLayoutPanel1_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void AddCertificateForm_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void AddCertificateForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Changes not saved! Exit anyway?", "Warning", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
        if (result == DialogResult.No) e.Cancel = true;
    }
}