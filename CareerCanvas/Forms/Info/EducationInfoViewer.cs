using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CareerCanvas.Forms.Info
{
    public partial class EducationInfoViewer : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Education education;

        public EducationInfoViewer(Education education)
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

            this.education = education;
        }

        private void EducationInfoViewer_Load(object sender, EventArgs e)
        {
            schoolNameBox.Text = education.SchoolName == String.Empty ? "None provided." : education.SchoolName;
            cityBox.Text = education.City == String.Empty ? "None provided." : education.City;
            stateBox.Text = education.State == String.Empty ? "None provided." : education.State;
            degreeBox.Text = EnumUtils.GetEnumDescription(education.Degree) == String.Empty ? "None provided." : EnumUtils.GetEnumDescription(education.Degree);
            startDateBox.Text = education.StartDate.ToShortDateString() == String.Empty ? "None provided." : education.StartDate.ToShortDateString();
            endDateBox.Text = education.EndDate.ToShortDateString() == String.Empty ? "None provided." : education.EndDate.ToShortDateString();
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