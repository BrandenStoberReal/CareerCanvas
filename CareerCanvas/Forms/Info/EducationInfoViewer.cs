using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Info;

public partial class EducationInfoViewer : MaterialForm
{
    private readonly Education _education;

    public EducationInfoViewer(Education education)
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
        Globals.AppLogger.Debug("Applied global color scheme to EducationInfoViewer: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());

        _education = education;
    }

    private void EducationInfoViewer_Load(object sender, EventArgs e)
    {
        schoolNameBox.Text = _education.SchoolName == string.Empty ? "None provided." : _education.SchoolName;
        cityBox.Text = _education.City == string.Empty ? "None provided." : _education.City;
        stateBox.Text = _education.State == string.Empty ? "None provided." : _education.State;
        degreeBox.Text = EnumUtils.GetEnumDescription(_education.Degree) == string.Empty
            ? "None provided."
            : EnumUtils.GetEnumDescription(_education.Degree);
        startDateBox.Text = _education.StartDate.ToShortDateString() == string.Empty
            ? "None provided."
            : _education.StartDate.ToShortDateString();
        endDateBox.Text = _education.EndDate.ToShortDateString() == string.Empty
            ? "None provided."
            : _education.EndDate.ToShortDateString();
    }

    private void textBox_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    private void textBox_Enter(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }
}