using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Forms.Info;
using CareerCanvas.Forms.InputDialogs;
using ProtoBuf;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Workspaces
{
    public partial class HistoryWorkspace : MaterialForm
    {
        private List<Employment> _jobHistory = new List<Employment>();
        private List<Education> _educationHistory = new List<Education>();
        private List<CertificateProgram> _certificateHistory = new List<CertificateProgram>();

        public HistoryWorkspace(string? filepath = null)
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

            if (filepath != null)
            {
                LoadIndustry(filepath);
            }
        }

        private void DisableJobButtons()
        {
            removeJobButton.Enabled = false;
            jobInfoButton.Enabled = false;
        }

        private void DisableEducationButtons()
        {
            removeEducationButton.Enabled = false;
            educationInfoButton.Enabled = false;
        }

        private void DisableCertificateButtons()
        {
            removeCertificateButton.Enabled = false;
            certificateInfoButton.Enabled = false;
        }

        private void EnableJobButtons()
        {
            removeJobButton.Enabled = true;
            jobInfoButton.Enabled = true;
        }

        private void EnableEducationButtons()
        {
            removeEducationButton.Enabled = true;
            educationInfoButton.Enabled = true;
        }

        private void EnableCertificateButtons()
        {
            removeCertificateButton.Enabled = true;
            certificateInfoButton.Enabled = true;
        }

        private void SaveIndustry()
        {
            // Flush class to disk
            Industry industry = new Industry
            {
                Jobs = _jobHistory,
                Schooling = _educationHistory,
                Certificates = _certificateHistory,
                Description = descriptionBox.Text
            };

            string industryPath = Path.Combine("./data/industries", titleBox.Text.ToLower().Replace(" ", "_") + ".industry");

            using var file = File.Create(industryPath);
            Serializer.Serialize(file, industry);
        }

        private void LoadIndustry(string filepath)
        {
            Industry industry;

            // Load binary data
            using (FileStream file = File.OpenRead(filepath))
            {
                industry = Serializer.Deserialize<Industry>(file);
            }

            // Load data into workspace
            titleBox.Text = Globals.textInfo.ToTitleCase(Path.GetFileNameWithoutExtension(filepath).Replace("_", " "));
            _jobHistory = industry.Jobs;
            _educationHistory = industry.Schooling;
            _certificateHistory = industry.Certificates;
            descriptionBox.Text = industry.Description;
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
            AddJobForm addJobForm = new AddJobForm(_jobHistory);
            addJobForm.Show();
        }

        private void addEducationButton_Click(object sender, EventArgs e)
        {
            AddEducationForm addEducationForm = new AddEducationForm(_educationHistory);
            addEducationForm.Show();
        }

        private void addCertificateButton_Click(object sender, EventArgs e)
        {
            AddCertificateForm addCertificateForm = new AddCertificateForm(_certificateHistory);
            addCertificateForm.Show();
        }

        private void updateJobsTimer_Tick(object sender, EventArgs e)
        {
            // Save some CPU cycles and only update if count changes
            if (employmentListBox.Items.Count != _jobHistory.Count)
            {
                employmentListBox.Items.Clear();
                foreach (Employment job in _jobHistory)
                {
                    employmentListBox.AddItem(job.CompanyName + " - " + job.JobTitle);
                }
                employmentListBox.Refresh();
            }
        }

        private void updateEducationTimer_Tick(object sender, EventArgs e)
        {
            // Save some CPU cycles and only update if count changes
            if (educationListBox.Items.Count != _educationHistory.Count)
            {
                educationListBox.Items.Clear();
                foreach (Education education in _educationHistory)
                {
                    educationListBox.AddItem(education.SchoolName + " - " + EnumUtils.GetEnumDescription(education.Degree));
                }
                educationListBox.Refresh();
            }
        }

        private void updateCertificatesTimer_Tick(object sender, EventArgs e)
        {
            // Save some CPU cycles and only update if count changes
            if (certificatesListBox.Items.Count != _certificateHistory.Count)
            {
                certificatesListBox.Items.Clear();
                foreach (CertificateProgram program in _certificateHistory)
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
                EnableJobButtons();
            }
        }

        private void educationListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (educationListBox.SelectedItem != null)
            {
                EnableEducationButtons();
            }
        }

        private void certificatesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (certificatesListBox.SelectedItem != null)
            {
                EnableCertificateButtons();
            }
        }

        private void removeJobButton_Click(object sender, EventArgs e)
        {
            if (employmentListBox.SelectedItem != null)
            {
                _jobHistory.RemoveAt(employmentListBox.SelectedIndex);
                employmentListBox.Items.RemoveAt(employmentListBox.SelectedIndex);
                DisableJobButtons();
                employmentListBox.SelectedItem = null;
            }
        }

        private void removeEducationButton_Click(object sender, EventArgs e)
        {
            if (educationListBox.SelectedItem != null)
            {
                _educationHistory.RemoveAt(educationListBox.SelectedIndex);
                educationListBox.Items.RemoveAt(educationListBox.SelectedIndex);
                DisableEducationButtons();
                educationListBox.SelectedItem = null;
            }
        }

        private void removeCertificateButton_Click(object sender, EventArgs e)
        {
            if (certificatesListBox.SelectedItem != null)
            {
                _certificateHistory.RemoveAt(certificatesListBox.SelectedIndex);
                certificatesListBox.Items.RemoveAt(certificatesListBox.SelectedIndex);
                DisableCertificateButtons();
                certificatesListBox.SelectedItem = null;
            }
        }

        private void jobInfoButton_Click(object sender, EventArgs e)
        {
            if (employmentListBox.SelectedItem != null)
            {
                JobInfoViewer jobInfoViewer = new JobInfoViewer(_jobHistory[employmentListBox.SelectedIndex]);
                DisableJobButtons();
                employmentListBox.SelectedItem = null;
                jobInfoViewer.Show();
            }
        }

        private void educationInfoButton_Click(object sender, EventArgs e)
        {
            if (educationListBox.SelectedItem != null)
            {
                EducationInfoViewer educationInfoViewer = new EducationInfoViewer(_educationHistory[educationListBox.SelectedIndex]);
                DisableEducationButtons();
                educationListBox.SelectedItem = null;
                educationInfoViewer.Show();
            }
        }

        private void certificateInfoButton_Click(object sender, EventArgs e)
        {
            if (certificatesListBox.SelectedItem != null)
            {
                CertificateInfoViewer certificateInfoViewer = new CertificateInfoViewer(_certificateHistory[certificatesListBox.SelectedIndex]);
                DisableCertificateButtons();
                certificatesListBox.SelectedItem = null;
                certificateInfoViewer.Show();
            }
        }

        private void HistoryWorkspace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (titleBox.Text == "")
            {
                DialogResult discardChanges = MessageBox.Show("No industry name found! Discard changes?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (discardChanges == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else if (discardChanges == DialogResult.Yes)
                {
                    return;
                }
            }

            SaveIndustry();
        }
    }
}