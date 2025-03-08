using CareerCanvas.Classes.Main;
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
            addJobForm.ShowDialog();
        }

        private void updateJobsTimer_Tick(object sender, EventArgs e)
        {
            // Save some CPU cycles and only update if count changes
            if (employmentListBox.Items.Count != jobHistory.Count)
            {
                employmentListBox.Items.Clear();
                foreach (Employment job in jobHistory)
                {
                    MaterialListBoxItem item = new MaterialListBoxItem
                    {
                        Text = job.CompanyName + " - " + job.JobTitle + " (" + job.StartDate.ToShortDateString() + " - " + job.EndDate.ToShortDateString() + ")"
                    };
                    employmentListBox.Items.Add(item);
                }
                employmentListBox.Refresh();
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

        private void removeJobButton_Click(object sender, EventArgs e)
        {
            if (employmentListBox.SelectedItem != null)
            {
                jobHistory.RemoveAt(employmentListBox.SelectedIndex);
                employmentListBox.Items.RemoveAt(employmentListBox.SelectedIndex);
                removeJobButton.Enabled = false;
            }
        }
    }
}