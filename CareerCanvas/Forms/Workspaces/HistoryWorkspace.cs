using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using CareerCanvas.Forms.InputDialogs;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CareerCanvas.Forms
{
    public partial class HistoryWorkspace : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        private readonly List<Employment> jobHistory = new List<Employment>();
        private readonly List<Education> educationHistory = new List<Education>();
        private readonly List<CertificateProgram> certificateHistory = new List<CertificateProgram>();

        public HistoryWorkspace()
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
        }

        private void HistoryWorkspace_Load(object sender, EventArgs e)
        {
        }

        private void HistoryWorkspace_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void addEmploymentButton_Click(object sender, EventArgs e)
        {
            AddJobForm addJobForm = new AddJobForm(jobHistory);
            addJobForm.Show();
        }

        private void addEducationButton_Click(object sender, EventArgs e)
        {
            AddEducationForm addEducationForm = new AddEducationForm(educationHistory);
            addEducationForm.Show();
        }

        private void addCertificateButton_Click(object sender, EventArgs e)
        {
            AddCertificateForm addCertificateForm = new AddCertificateForm(certificateHistory);
            addCertificateForm.Show();
        }

        private void updateJobsTimer_Tick(object sender, EventArgs e)
        {
            // Save some CPU cycles and only update if count changes
            if (employmentListBox.Items.Count != jobHistory.Count)
            {
                employmentListBox.Items.Clear();
                foreach (Employment job in jobHistory)
                {
                    employmentListBox.AddItem(job.CompanyName + " - " + job.JobTitle);
                }
                employmentListBox.Refresh();
            }
        }

        private void updateEducationTimer_Tick(object sender, EventArgs e)
        {
            // Save some CPU cycles and only update if count changes
            if (educationListBox.Items.Count != educationHistory.Count)
            {
                educationListBox.Items.Clear();
                foreach (Education education in educationHistory)
                {
                    educationListBox.AddItem(education.SchoolName + " - " + EnumUtils.GetEnumDescription(education.Degree));
                }
                educationListBox.Refresh();
            }
        }

        private void updateCertificatesTimer_Tick(object sender, EventArgs e)
        {
            // Save some CPU cycles and only update if count changes
            if (certificatesListBox.Items.Count != certificateHistory.Count)
            {
                certificatesListBox.Items.Clear();
                foreach (CertificateProgram program in certificateHistory)
                {
                    certificatesListBox.AddItem(program.IssuingOrganization + " - " + program.Certificate.CertificateName);
                }
                certificatesListBox.Refresh();
            }
        }

        private void HistoryWorkspace_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void employmentListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (employmentListBox.SelectedItem != null)
            {
                removeJobButton.Enabled = true;
            }
        }

        private void educationListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (educationListBox.SelectedItem != null)
            {
                removeEducationButton.Enabled = true;
            }
        }

        private void certificatesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (certificatesListBox.SelectedItem != null)
            {
                removeCertificateButton.Enabled = true;
            }
        }

        private void removeJobButton_Click(object sender, EventArgs e)
        {
            if (employmentListBox.SelectedItem != null)
            {
                jobHistory.RemoveAt(employmentListBox.SelectedIndex);
                employmentListBox.Items.RemoveAt(employmentListBox.SelectedIndex);
                removeJobButton.Enabled = false;
            }
        }

        private void removeEducationButton_Click(object sender, EventArgs e)
        {
            if (educationListBox.SelectedItem != null)
            {
                educationHistory.RemoveAt(educationListBox.SelectedIndex);
                educationListBox.Items.RemoveAt(educationListBox.SelectedIndex);
                removeEducationButton.Enabled = false;
                educationListBox.SelectedItem = null;
            }
        }

        private void removeCertificateButton_Click(object sender, EventArgs e)
        {
            if (certificatesListBox.SelectedItem != null)
            {
                certificateHistory.RemoveAt(certificatesListBox.SelectedIndex);
                certificatesListBox.Items.RemoveAt(certificatesListBox.SelectedIndex);
                removeCertificateButton.Enabled = false;
                certificatesListBox.SelectedItem = null;
            }
        }
    }
}