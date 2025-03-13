using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System.Globalization;

namespace CareerCanvas.Forms.InputDialogs
{
    public partial class AddEducationForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private List<Education> masterList = new List<Education>();

        public AddEducationForm(List<Education> masterList)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = Globals.AppColorScheme;

            this.masterList = masterList;
        }

        private void AddEducationForm_Load(object sender, EventArgs e)
        {
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(schoolNameBox.Text))
            {
                MessageBox.Show("Please enter a school name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(startDateBox.Text))
            {
                MessageBox.Show("Please enter a start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(endDateBox.Text))
            {
                MessageBox.Show("Please enter an end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (degreeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a degree type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Education newEducation = new Education();
            newEducation.StartDate = startDate;
            newEducation.EndDate = endDate;
            newEducation.SchoolName = schoolNameBox.Text;
            newEducation.Degree = (DegreeType)degreeComboBox.SelectedIndex;
            newEducation.City = cityBox.Text;
            newEducation.State = stateBox.Text;
            masterList.Add(newEducation);
            Close();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void AddEducationForm_Shown(object sender, EventArgs e)
        {
        }

        private void AddEducationForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void AddEducationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Changes not saved! Exit anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}