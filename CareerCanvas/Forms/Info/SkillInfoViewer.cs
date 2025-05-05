using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Info;

public partial class SkillInfoViewer : MaterialForm
{
    private readonly ProfessionalSkill _skill;

    /// <summary>
    ///     Initializes a new instance of the JobInfoViewer class.
    ///     This constructor sets up the form's appearance and behavior using MaterialSkinManager.
    /// </summary>
    /// <param name="job">An Employment object containing job information to be displayed in the viewer.</param>
    public SkillInfoViewer(ProfessionalSkill skill)
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
        Globals.AppLogger.Debug("Applied global color scheme to JobInfoViewer: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());

        _skill = skill;
    }

    /// <summary>
    ///     Event handler for the Load event of the JobInfoViewer form.
    ///     Initializes the text fields with job information from the _job object.
    ///     If any field in the _job object is empty, it displays "None provided." instead.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void SkillInfoViewer_Load(object sender, EventArgs e)
    {
        skillNameBox.Text = _skill.SkillName == string.Empty ? "None provided." : _skill.SkillName;
        yearsBox.Text = _skill.YearsExperience.ToString() == string.Empty ? "None provided." : _skill.YearsExperience.ToString();
    }

    /// <summary>
    ///     Event handler for the Shown event of the JobInfoViewer form.
    ///     This method is called when the form is displayed to the user.
    ///     It sets the ActiveControl property to null, which removes focus from any control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void SkillInfoViewer_Shown(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    ///     Event handler for the Click event of the textBox control.
    ///     This method is called when the textBox is clicked.
    ///     It sets the ActiveControl property to null, which removes focus from any control.
    /// </summary>
    /// <param name="sender">The source of the event, typically the textBox that was clicked.</param>
    /// <param name="e">The event data containing information about the click event.</param>
    private void textBox_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    ///     Event handler for the Enter event of the textBox control.
    ///     This method is called when the textBox gains focus.
    ///     It sets the ActiveControl property to null, which removes focus from any control.
    /// </summary>
    /// <param name="sender">The source of the event, typically the textBox that gained focus.</param>
    /// <param name="e">The event data containing information about the Enter event.</param>
    private void textBox_Enter(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }
}