using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System.Globalization;

namespace CareerCanvas.Forms.InputDialogs;

public partial class AddJobForm : MaterialForm
{
    private readonly List<Employment> _refMasterList;

    public AddJobForm(List<Employment> masterList)
    {
        InitializeComponent();

        _refMasterList = masterList;

        var materialSkinManager1 = MaterialSkinManager.Instance;

        // Set this to false to disable backcolor enforcing on non-materialSkin components
        // This HAS to be set before the AddFormToManage()
        materialSkinManager1.EnforceBackcolorOnAllComponents = true;

        // MaterialSkinManager properties
        materialSkinManager1.AddFormToManage(this);
        materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

        materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
        Globals.AppLogger.Debug("Applied global color scheme to AddJobForm: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());
    }

    private void AddJobForm_Load(object sender, EventArgs e)
    {
    }

    private void AddJobForm_Shown(object sender, EventArgs e)
    {
    }

    private void flowLayoutPanel1_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    private void AddJobForm_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    private void discardButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void addJobButton_Click(object sender, EventArgs e)
    {
        if (companyBox.Text == "" || jobTitleBox.Text == "" || startDateBox.Text == "" || endDateBox.Text == "")
        {
            MessageBox.Show("Please fill out all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DateTime startDate;
        DateTime endDate;
        try
        {
            startDate = DateTime.ParseExact(startDateBox.Text, "MM/yyyy", CultureInfo.InvariantCulture);
            endDate = DateTime.ParseExact(endDateBox.Text, "MM/yyyy", CultureInfo.InvariantCulture);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Invalid date format. Please use MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var newJob = new Employment
        {
            StartDate = startDate,
            EndDate = endDate,
            CompanyName = companyBox.Text,
            JobTitle = jobTitleBox.Text,
            City = cityBox.Text,
            State = stateBox.Text,
            JobDescription = jobDescriptionBox.Text
        };
        Globals.AppLogger.Information("Created new job class with title: {JobTitle}", newJob.JobTitle);
        _refMasterList.Add(newJob);
        Close();
    }

    private void AddJobForm_FormClosing(object sender, FormClosingEventArgs e)
    {
    }
}