using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Info
{
    public partial class JobInfoViewer : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Employment job;

        public JobInfoViewer(Employment job)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = Globals.AppConfig.ColorScheme;

            this.job = job;
        }

        private void JobInfoViewer_Load(object sender, EventArgs e)
        {
            jobTitleBox.Text = job.JobTitle == String.Empty ? "None provided." : job.JobTitle;
            employerBox.Text = job.CompanyName == String.Empty ? "None provided." : job.CompanyName;
            cityBox.Text = job.City == String.Empty ? "None provided." : job.City;
            stateBox.Text = job.State == String.Empty ? "None provided." : job.State;
            startDateBox.Text = job.StartDate.ToShortDateString() == String.Empty ? "None provided." : job.StartDate.ToShortDateString();
            endDateBox.Text = job.EndDate.ToShortDateString() == String.Empty ? "None provided." : job.EndDate.ToShortDateString();
            jobDescriptionBox.Text = job.JobDescription == String.Empty ? "None provided." : job.JobDescription;
        }

        private void JobInfoViewer_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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