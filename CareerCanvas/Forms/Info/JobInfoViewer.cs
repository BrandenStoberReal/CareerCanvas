using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Info
{
    public partial class JobInfoViewer : MaterialForm
    {
        private readonly Employment _job;

        public JobInfoViewer(Employment job)
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

            this._job = job;
        }

        private void JobInfoViewer_Load(object sender, EventArgs e)
        {
            jobTitleBox.Text = _job.JobTitle == String.Empty ? "None provided." : _job.JobTitle;
            employerBox.Text = _job.CompanyName == String.Empty ? "None provided." : _job.CompanyName;
            cityBox.Text = _job.City == String.Empty ? "None provided." : _job.City;
            stateBox.Text = _job.State == String.Empty ? "None provided." : _job.State;
            startDateBox.Text = _job.StartDate.ToShortDateString() == String.Empty ? "None provided." : _job.StartDate.ToShortDateString();
            endDateBox.Text = _job.EndDate.ToShortDateString() == String.Empty ? "None provided." : _job.EndDate.ToShortDateString();
            jobDescriptionBox.Text = _job.JobDescription == String.Empty ? "None provided." : _job.JobDescription;
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