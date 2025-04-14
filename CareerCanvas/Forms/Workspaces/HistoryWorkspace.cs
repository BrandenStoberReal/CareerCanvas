using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Forms.Info;
using CareerCanvas.Forms.InputDialogs;
using ProtoBuf;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Workspaces;

public partial class HistoryWorkspace : MaterialForm
{
    private List<CertificateProgram> _certificateHistory = new();
    private List<Education> _educationHistory = new();
    private List<Employment> _jobHistory = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="HistoryWorkspace"/> class.
    /// </summary>
    /// <param name="filepath">An optional parameter that specifies the path to a file containing industry data.
    /// If provided, the data will be loaded into the workspace.</param>
    /// <remarks>
    /// This constructor sets up the user interface components and configures the MaterialSkinManager
    /// for the form. It enforces a consistent backcolor on all components, applies a dark theme,
    /// and sets the color scheme based on the application configuration. If a valid file path is
    /// provided, the <see cref="LoadIndustry"/> method is called to load the industry data from the specified file.
    /// </remarks>
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
        Globals.AppLogger.Debug("Applied global color scheme to HistoryWorkspace: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());

        if (filepath != null) LoadIndustry(filepath);
    }

    /// <summary>
    /// Disables the job-related buttons in the user interface.
    /// </summary>
    /// <remarks>
    /// This method sets the <see cref="removeJobButton"/> and <see cref="jobInfoButton"/>
    /// to be disabled, preventing user interaction with these buttons.
    /// This is typically used when a job is no longer available or when
    /// the user should not be able to perform actions related to jobs.
    /// </remarks>
    private void DisableJobButtons()
    {
        removeJobButton.Enabled = false;
        jobInfoButton.Enabled = false;
    }

    /// <summary>
    /// Disables the education-related buttons in the user interface.
    /// </summary>
    /// <remarks>
    /// This method sets the <see cref="removeEducationButton"/> and <see cref="educationInfoButton"/>
    /// to be disabled, preventing user interaction with these buttons.
    /// This is typically used when the education options are no longer available
    /// or when the user should not be able to perform actions related to education.
    /// </remarks>
    private void DisableEducationButtons()
    {
        removeEducationButton.Enabled = false;
        educationInfoButton.Enabled = false;
    }

    /// <summary>
    /// Disables the certificate-related buttons in the user interface.
    /// </summary>
    /// <remarks>
    /// This method sets the <see cref="removeCertificateButton"/> and <see cref="certificateInfoButton"/>
    /// to be disabled, preventing user interaction with these buttons.
    /// This is typically used when the certificate options are no longer available
    /// or when the user should not be able to perform actions related to certificates.
    /// </remarks>
    private void DisableCertificateButtons()
    {
        removeCertificateButton.Enabled = false;
        certificateInfoButton.Enabled = false;
    }

    /// <summary>
    /// Enables the job-related buttons in the user interface.
    /// </summary>
    /// <remarks>
    /// This method sets the <see cref="removeJobButton"/> and <see cref="jobInfoButton"/>
    /// to be enabled, allowing user interaction with these buttons.
    /// This is typically used when a job is available or when
    /// the user should be able to perform actions related to jobs.
    /// </remarks>
    private void EnableJobButtons()
    {
        removeJobButton.Enabled = true;
        jobInfoButton.Enabled = true;
    }

    /// <summary>
    /// Enables the education-related buttons in the user interface.
    /// </summary>
    /// <remarks>
    /// This method sets the <see cref="removeEducationButton"/> and <see cref="educationInfoButton"/>
    /// to be enabled, allowing user interaction with these buttons.
    /// This is typically used when education options are available or when
    /// the user should be able to perform actions related to education.
    /// </remarks>
    private void EnableEducationButtons()
    {
        removeEducationButton.Enabled = true;
        educationInfoButton.Enabled = true;
    }

    /// <summary>
    /// Enables the certificate-related buttons in the user interface.
    /// </summary>
    /// <remarks>
    /// This method sets the <see cref="removeCertificateButton"/> and <see cref="certificateInfoButton"/>
    /// to be enabled, allowing user interaction with these buttons.
    /// This is typically used when certificate options are available or when
    /// the user should be able to perform actions related to certificates.
    /// </remarks>
    private void EnableCertificateButtons()
    {
        removeCertificateButton.Enabled = true;
        certificateInfoButton.Enabled = true;
    }

    /// <summary>
    /// Saves the current industry data to a file on disk.
    /// </summary>
    /// <remarks>
    /// This method creates an instance of the <see cref="Industry"/> class, populates it with job history,
    /// education history, certificate history, and a description from the UI. It then serializes this
    /// instance to a file located in the "./data/industries" directory, using the title provided in
    /// the titleBox as the filename (converted to lowercase and spaces replaced with underscores).
    /// </remarks>
    private void SaveIndustry()
    {
        // Flush class to disk
        var industry = new Industry
        {
            Jobs = _jobHistory,
            Schooling = _educationHistory,
            Certificates = _certificateHistory,
            Description = descriptionBox.Text
        };

        var industryPath = Path.Combine("./data/industries", titleBox.Text.ToLower().Replace(" ", "_") + ".industry");

        using var file = File.Create(industryPath);
        Serializer.Serialize(file, industry);
        Globals.AppLogger.Information("Saved industry {Industry} to {Path}.", titleBox.Text, industryPath);
    }

    /// <summary>
    /// Loads industry data from a specified file and populates the UI components with the loaded data.
    /// </summary>
    /// <param name="filepath">The path to the file containing the industry data in binary format.</param>
    /// <remarks>
    /// This method opens the specified file, deserializes the binary data into an instance of the <see cref="Industry"/> class,
    /// and updates the UI elements with the relevant information such as job history, education history, certificates,
    /// and a description. The title of the industry is also formatted and displayed in the titleBox.
    /// </remarks>
    private void LoadIndustry(string filepath)
    {
        Industry industry;

        // Load binary data
        using (var file = File.OpenRead(filepath))
        {
            industry = Serializer.Deserialize<Industry>(file);
        }

        // Load data into workspace
        titleBox.Text = Globals.textInfo.ToTitleCase(Path.GetFileNameWithoutExtension(filepath).Replace("_", " "));
        _jobHistory = industry.Jobs;
        _educationHistory = industry.Schooling;
        _certificateHistory = industry.Certificates;
        descriptionBox.Text = industry.Description;
        Globals.AppLogger.Information("Loaded industry {Industry} from {Path}.", titleBox.Text, filepath);
    }

    /// <summary>
    /// Event handler for the Load event of the HistoryWorkspace form.
    /// </summary>
    /// <param name="sender">The source of the event, typically the form itself.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method is called when the HistoryWorkspace form is loaded.
    /// Currently, it does not contain any implementation, but it can be used
    /// to initialize components or load data when the form is displayed.
    /// </remarks>
    private void HistoryWorkspace_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Event handler for the Shown event of the HistoryWorkspace form.
    /// </summary>
    /// <param name="sender">The source of the event, typically the form itself.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method is called when the HistoryWorkspace form is displayed.
    /// It sets the active control to null, which effectively removes focus
    /// from any control on the form when it is shown.
    /// </remarks>
    private void HistoryWorkspace_Shown(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    /// <summary>
    /// Event handler for the Click event of the add employment button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method creates an instance of the <see cref="AddJobForm"/> class,
    /// passing the job history as a parameter. It then displays the form to
    /// allow the user to add a new job entry to their employment history.
    /// </remarks>
    private void addEmploymentButton_Click(object sender, EventArgs e)
    {
        Globals.AppLogger.Debug("User requested to add a new job to their industry.");
        var addJobForm = new AddJobForm(_jobHistory);
        addJobForm.Show();
    }

    /// <summary>
    /// Event handler for the Click event of the add education button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method creates an instance of the <see cref="AddEducationForm"/> class,
    /// passing the education history as a parameter. It then displays the form to
    /// allow the user to add a new education entry to their education history.
    /// </remarks>
    private void addEducationButton_Click(object sender, EventArgs e)
    {
        Globals.AppLogger.Debug("User requested to add a new education to their industry.");
        var addEducationForm = new AddEducationForm(_educationHistory);
        addEducationForm.Show();
    }

    /// <summary>
    /// Event handler for the Click event of the add certificate button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method creates an instance of the <see cref="AddCertificateForm"/> class,
    /// passing the certificate history as a parameter. It then displays the form to
    /// allow the user to add a new certificate entry to their certificate history.
    /// </remarks>
    private void addCertificateButton_Click(object sender, EventArgs e)
    {
        Globals.AppLogger.Debug("User requested to add a new certificate to their industry.");
        var addCertificateForm = new AddCertificateForm(_certificateHistory);
        addCertificateForm.Show();
    }

    /// <summary>
    /// Event handler for the Tick event of the jobs update timer.
    /// </summary>
    /// <param name="sender">The source of the event, typically the timer that triggered the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if the number of items in the employment list box
    /// differs from the count of jobs in the job history. If they are different,
    /// it clears the current items in the list box and repopulates it with
    /// the updated job information from the job history. This optimization
    /// helps save CPU cycles by avoiding unnecessary updates when the count
    /// remains the same.
    /// </remarks>
    private void updateJobsTimer_Tick(object sender, EventArgs e)
    {
        // Save some CPU cycles and only update if count changes
        if (employmentListBox.Items.Count != _jobHistory.Count)
        {
            Globals.AppLogger.Debug("Updating job list box with {Count} items.", _jobHistory.Count);
            employmentListBox.Items.Clear();
            foreach (var job in _jobHistory) employmentListBox.AddItem(job.CompanyName + " - " + job.JobTitle);
            employmentListBox.Refresh();
        }
    }

    /// <summary>
    /// Event handler for the Tick event of the education update timer.
    /// </summary>
    /// <param name="sender">The source of the event, typically the timer that triggered the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if the number of items in the education list box
    /// differs from the count of education entries in the education history.
    /// If they are different, it clears the current items in the list box
    /// and repopulates it with the updated education information from the
    /// education history. This optimization helps save CPU cycles by
    /// avoiding unnecessary updates when the count remains the same.
    /// </remarks>
    private void updateEducationTimer_Tick(object sender, EventArgs e)
    {
        // Save some CPU cycles and only update if count changes
        if (educationListBox.Items.Count != _educationHistory.Count)
        {
            Globals.AppLogger.Debug("Updating education list box with {Count} items.", _educationHistory.Count);
            educationListBox.Items.Clear();
            foreach (var education in _educationHistory)
                educationListBox.AddItem(education.SchoolName + " - " + EnumUtils.GetEnumDescription(education.Degree));
            educationListBox.Refresh();
        }
    }

    /// <summary>
    /// Event handler for the Tick event of the certificates update timer.
    /// </summary>
    /// <param name="sender">The source of the event, typically the timer that triggered the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if the number of items in the certificates list box
    /// differs from the count of certificates in the certificate history. If they are different,
    /// it clears the current items in the list box and repopulates it with
    /// the updated certificate information from the certificate history. This optimization
    /// helps save CPU cycles by avoiding unnecessary updates when the count
    /// remains the same.
    /// </remarks>
    private void updateCertificatesTimer_Tick(object sender, EventArgs e)
    {
        Globals.AppLogger.Debug("Updating certificates list box with {Count} items.", _certificateHistory.Count);
        // Save some CPU cycles and only update if count changes
        if (certificatesListBox.Items.Count != _certificateHistory.Count)
        {
            certificatesListBox.Items.Clear();
            foreach (var program in _certificateHistory)
                certificatesListBox.AddItem(program.IssuingOrganization + " - " + program.Certificate.CertificateName);
            certificatesListBox.Refresh();
        }
    }

    /// <summary>
    /// Event handler for the Click event of the history workspace.
    /// </summary>
    /// <param name="sender">The source of the event, typically the control that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method sets the <see cref="ActiveControl"/> to null, effectively
    /// clearing the current active control in the user interface. This is
    /// typically used to deselect any currently focused control when the
    /// history workspace is clicked.
    /// </remarks>
    private void HistoryWorkspace_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    /// <summary>
    /// Event handler for the SelectedIndexChanged event of the employment list box.
    /// </summary>
    /// <param name="sender">The source of the event, typically the employment list box.</param>
    /// <param name="selectedItem">The item that was selected in the employment list box.</param>
    /// <remarks>
    /// This method checks if an item is selected in the employment list box.
    /// If an item is selected, it enables the job-related buttons, allowing
    /// the user to interact with them. This is typically used to ensure that
    /// the buttons are only enabled when there is a valid selection.
    /// </remarks>
    private void employmentListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
    {
        if (employmentListBox.SelectedItem != null) EnableJobButtons();
    }

    /// <summary>
    /// Event handler for the SelectedIndexChanged event of the education list box.
    /// </summary>
    /// <param name="sender">The source of the event, typically the education list box that triggered the event.</param>
    /// <param name="selectedItem">The currently selected item in the education list box.</param>
    /// <remarks>
    /// This method checks if there is a selected item in the education list box.
    /// If an item is selected, it enables the education-related buttons, allowing
    /// the user to interact with them. This is typically used to ensure that
    /// the buttons are only enabled when there is a valid selection.
    /// </remarks>
    private void educationListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
    {
        if (educationListBox.SelectedItem != null) EnableEducationButtons();
    }

    /// <summary>
    /// Event handler for the SelectedIndexChanged event of the certificates list box.
    /// </summary>
    /// <param name="sender">The source of the event, typically the list box that triggered the event.</param>
    /// <param name="selectedItem">The currently selected item in the certificates list box.</param>
    /// <remarks>
    /// This method is invoked when the selected index of the certificates list box changes.
    /// If there is a selected item, it enables the certificate-related buttons, allowing
    /// the user to interact with them. This is typically used to ensure that the buttons
    /// are only enabled when a valid certificate is selected.
    /// </remarks>
    private void certificatesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
    {
        if (certificatesListBox.SelectedItem != null) EnableCertificateButtons();
    }

    /// <summary>
    /// Event handler for the Click event of the remove job button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if an item is selected in the employment list box.
    /// If an item is selected, it removes the corresponding job from the job history
    /// and updates the employment list box accordingly. It also disables the job
    /// buttons and clears the selected item in the list box to reflect the removal.
    /// </remarks>
    private void removeJobButton_Click(object sender, EventArgs e)
    {
        if (employmentListBox.SelectedItem != null)
        {
            Globals.AppLogger.Debug("Removing job {Job} from job history.", _jobHistory[employmentListBox.SelectedIndex].JobTitle);
            _jobHistory.RemoveAt(employmentListBox.SelectedIndex);
            employmentListBox.Items.RemoveAt(employmentListBox.SelectedIndex);
            DisableJobButtons();
            employmentListBox.SelectedItem = null;
        }
    }

    /// <summary>
    /// Event handler for the Click event of the remove education button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if an item is selected in the education list box.
    /// If an item is selected, it removes the corresponding entry from the
    /// education history and the list box. It then disables the education
    /// buttons and clears the selection in the list box to prevent further
    /// actions on a non-selected item.
    /// </remarks>
    private void removeEducationButton_Click(object sender, EventArgs e)
    {
        if (educationListBox.SelectedItem != null)
        {
            Globals.AppLogger.Debug("Removing education {Education} from education history.", _educationHistory[educationListBox.SelectedIndex].SchoolName);
            _educationHistory.RemoveAt(educationListBox.SelectedIndex);
            educationListBox.Items.RemoveAt(educationListBox.SelectedIndex);
            DisableEducationButtons();
            educationListBox.SelectedItem = null;
        }
    }

    /// <summary>
    /// Event handler for the Click event of the remove certificate button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if a certificate is selected in the certificates list box.
    /// If a certificate is selected, it removes the corresponding entry from the
    /// certificate history and the list box. It then disables the certificate-related
    /// buttons and clears the selection in the list box, ensuring that no certificate
    /// remains selected after removal.
    /// </remarks>
    private void removeCertificateButton_Click(object sender, EventArgs e)
    {
        if (certificatesListBox.SelectedItem != null)
        {
            Globals.AppLogger.Debug("Removing certificate {Certificate} from certificate history.", _certificateHistory[certificatesListBox.SelectedIndex].Certificate.CertificateName);
            _certificateHistory.RemoveAt(certificatesListBox.SelectedIndex);
            certificatesListBox.Items.RemoveAt(certificatesListBox.SelectedIndex);
            DisableCertificateButtons();
            certificatesListBox.SelectedItem = null;
        }
    }

    /// <summary>
    /// Event handler for the Click event of the job information button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if an item is selected in the employment list box.
    /// If an item is selected, it creates an instance of the <see cref="JobInfoViewer"/>
    /// class, passing the selected job's information from the job history.
    /// It then disables job-related buttons, clears the selection in the list box,
    /// and displays the job information viewer to the user.
    /// </remarks>
    private void jobInfoButton_Click(object sender, EventArgs e)
    {
        if (employmentListBox.SelectedItem != null)
        {
            Globals.AppLogger.Debug("Showing job info for {Job} in job history.", _jobHistory[employmentListBox.SelectedIndex].JobTitle);
            var jobInfoViewer = new JobInfoViewer(_jobHistory[employmentListBox.SelectedIndex]);
            DisableJobButtons();
            employmentListBox.SelectedItem = null;
            jobInfoViewer.Show();
        }
    }

    /// <summary>
    /// Event handler for the Click event of the education info button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if an item is selected in the education list box.
    /// If an item is selected, it creates an instance of the <see cref="EducationInfoViewer"/>
    /// class, passing the selected education history entry as a parameter.
    /// It then disables the education-related buttons, clears the selection in the
    /// education list box, and displays the education info viewer to show details
    /// about the selected education entry.
    /// </remarks>
    private void educationInfoButton_Click(object sender, EventArgs e)
    {
        if (educationListBox.SelectedItem != null)
        {
            Globals.AppLogger.Debug("Showing education info for {Education} in education history.", _educationHistory[educationListBox.SelectedIndex].SchoolName);
            var educationInfoViewer = new EducationInfoViewer(_educationHistory[educationListBox.SelectedIndex]);
            DisableEducationButtons();
            educationListBox.SelectedItem = null;
            educationInfoViewer.Show();
        }
    }

    /// <summary>
    /// Event handler for the Click event of the certificate info button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if an item is selected in the certificates list box.
    /// If an item is selected, it creates an instance of the <see cref="CertificateInfoViewer"/>
    /// class, passing the selected certificate's information from the certificate history.
    /// It then disables the certificate-related buttons, clears the selection in the list box,
    /// and displays the certificate information viewer to the user.
    /// </remarks>
    private void certificateInfoButton_Click(object sender, EventArgs e)
    {
        if (certificatesListBox.SelectedItem != null)
        {
            Globals.AppLogger.Debug("Showing certificate info for {Certificate} in certificate history.", _certificateHistory[certificatesListBox.SelectedIndex].Certificate.CertificateName);
            var certificateInfoViewer =
                new CertificateInfoViewer(_certificateHistory[certificatesListBox.SelectedIndex]);
            DisableCertificateButtons();
            certificatesListBox.SelectedItem = null;
            certificateInfoViewer.Show();
        }
    }

    /// <summary>
    /// Event handler for the FormClosing event of the HistoryWorkspace form.
    /// </summary>
    /// <param name="sender">The source of the event, typically the form being closed.</param>
    /// <param name="e">A <see cref="FormClosingEventArgs"/> that contains the event data.</param>
    /// <remarks>
    /// This method checks if the title box is empty when the form is closing.
    /// If it is empty, a message box prompts the user to confirm whether to
    /// discard changes. If the user chooses not to discard changes, the
    /// closing event is canceled. If the user confirms to discard changes
    /// or if the title box is not empty, the method proceeds to save the
    /// industry information before closing the form.
    /// </remarks>
    private void HistoryWorkspace_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (titleBox.Text == "")
        {
            var discardChanges = MessageBox.Show("No industry name found! Discard changes?", "Discard",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (discardChanges == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            if (discardChanges == DialogResult.Yes)
            {
                Globals.AppLogger.Warning("User did not provide a name for their industry. Changes have been discarded");
                return;
            }
        }

        Globals.AppLogger.Information("Saving industry \"{0}\" to disk.", titleBox.Text);
        SaveIndustry();
    }
}