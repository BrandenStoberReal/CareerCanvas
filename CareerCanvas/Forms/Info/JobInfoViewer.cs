using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Info;

public partial class JobInfoViewer : MaterialForm
{
    private readonly Employment _job;

    /// <summary>
    ///     Initializes a new instance of the JobInfoViewer class.
    ///     This constructor sets up the form's appearance and behavior using MaterialSkinManager.
    /// </summary>
    /// <param name="job">An Employment object containing job information to be displayed in the viewer.</param>
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

        _job = job;
    }

    /// <summary>
    ///     Event handler for the Load event of the JobInfoViewer form.
    ///     Initializes the text fields with job information from the _job object.
    ///     If any field in the _job object is empty, it displays "None provided." instead.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void JobInfoViewer_Load(object sender, EventArgs e)
    {
        jobTitleBox.Text = _job.JobTitle == string.Empty ? "None provided." : _job.JobTitle;
        employerBox.Text = _job.CompanyName == string.Empty ? "None provided." : _job.CompanyName;
        cityBox.Text = _job.City == string.Empty ? "None provided." : _job.City;
        stateBox.Text = _job.State == string.Empty ? "None provided." : _job.State;
        startDateBox.Text = _job.StartDate.ToShortDateString() == string.Empty
            ? "None provided."
            : _job.StartDate.ToShortDateString();
        endDateBox.Text = _job.EndDate.ToShortDateString() == string.Empty
            ? "None provided."
            : _job.EndDate.ToShortDateString();
        jobDescriptionBox.Text = _job.JobDescription == string.Empty ? "None provided." : _job.JobDescription;
    }

    /// <summary>
    ///     Event handler for the Shown event of the JobInfoViewer form.
    ///     This method is called when the form is displayed to the user.
    ///     It sets the ActiveControl property to null, which removes focus from any control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void JobInfoViewer_Shown(object sender, EventArgs e)
    {
        ActiveControl = null;
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
        ActiveControl = null;
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
        ActiveControl = null;
    }
}