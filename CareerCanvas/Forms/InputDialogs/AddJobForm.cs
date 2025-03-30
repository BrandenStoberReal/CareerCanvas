using System.Globalization;
using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.InputDialogs
{
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
        }

        private void AddJobForm_Load(object sender, EventArgs e)
        {
        }

        private void AddJobForm_Shown(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void AddJobForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            if (companyBox.Text == "" || jobTitleBox.Text == "" || startDateBox.Text == "" || endDateBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields.");
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
                MessageBox.Show("Invalid date format. Please use MM/yyyy.");
                return;
            }

            Employment newJob = new Employment
            {
                StartDate = startDate,
                EndDate = endDate,
                CompanyName = companyBox.Text,
                JobTitle = jobTitleBox.Text,
                City = cityBox.Text,
                State = stateBox.Text
            };
            _refMasterList.Add(newJob);
            this.Close();
        }

        private void AddJobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Changes not saved! Exit anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}