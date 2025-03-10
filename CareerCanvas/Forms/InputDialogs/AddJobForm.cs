using CareerCanvas.Classes.Main.History;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Globalization;

namespace CareerCanvas.Forms
{
    public partial class AddJobForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private List<Employment> refMasterList = new List<Employment>();

        public AddJobForm(List<Employment> masterList)
        {
            InitializeComponent();

            refMasterList = masterList;

            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);
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

            Employment newJob = new Employment();
            newJob.StartDate = startDate;
            newJob.EndDate = endDate;
            newJob.CompanyName = companyBox.Text;
            newJob.JobTitle = jobTitleBox.Text;
            refMasterList.Add(newJob);
            this.Close();
        }
    }
}