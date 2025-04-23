using System.Globalization;
using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.InputDialogs;

public partial class AddSkillForm : MaterialForm
{
    private readonly List<ProfessionalSkill> _refMasterList;

    public AddSkillForm(List<ProfessionalSkill> masterList)
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

    private void AddSkillForm_Load(object sender, EventArgs e)
    {
    }

    private void AddSkillForm_Shown(object sender, EventArgs e)
    {
    }

    private void flowLayoutPanel1_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void AddSkillForm_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void discardButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void addSkillButton_Click(object sender, EventArgs e)
    {
        if (yearsBox.Text == "" || skillNameBox.Text == "")
        {
            MessageBox.Show("Please fill out all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(yearsBox.Text, out var years))
        {
            MessageBox.Show("Please enter a valid number of years.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var newSkill = new ProfessionalSkill
        {
            SkillName = skillNameBox.Text,
            YearsExperience = years
        };
        Globals.AppLogger.Information("Created new skill class with title: {SkillTitle}", newSkill.SkillName);
        _refMasterList.Add(newSkill);
        Close();
    }

    private void AddSkillForm_FormClosing(object sender, FormClosingEventArgs e)
    {
    }
}