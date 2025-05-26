using CareerCanvas.Classes.Configs;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Forms.Workspaces;
using ProtoBuf;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System.Diagnostics;
using System.Xml;

namespace CareerCanvas.Forms;

public partial class EntryForm : MaterialForm
{
    /// <summary>
    ///     Constructor for the EntryForm class.
    ///     Initializes the form components and configures the MaterialSkinManager settings.
    /// </summary>
    public EntryForm()
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
    }

    /// <summary>
    ///     Load event handler for the EntryForm. Initializes the form by setting up necessary configurations,
    ///     ensuring the WebView2 component is ready, creating application folders, handling encryption keys,
    ///     and loading identity settings.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void EntryForm_Load(object sender, EventArgs e)
    {
        // Set the active control to null to prevent any control from being focused initially
        InputUtils.ClearActiveControl(this);

        // Append debug title if running in debug mode
        if (Globals.DebugMode)
        {
            this.Text += " [DEBUG MODE]";
        }

        // Load identity settings if the configuration file exists
        if (File.Exists(Globals.IdentityConfigPath))
        {
            // Decrypt the identity settings file using the encryption key
            EncryptionUtils.DecryptFile(Globals.IdentityConfigPath, Globals.IdentityConfigPath,
                File.ReadAllText("./data/misc/encryption.key"));

            // Read and deserialize the identity configuration file
            using var file = File.OpenRead(Globals.IdentityConfigPath);
            Globals.IdentityConfig = Serializer.Deserialize<IdentityConfig>(file);
        }

        // Generate an encryption key for identity files if encryption is enabled and no key exists
        if (Globals.IdentityConfig.UseEncryption && Globals.IdentityConfig.EncryptionKey == null)
            Globals.IdentityConfig.EncryptionKey = EncryptionUtils.Generate256BitKey();

        // Set the identity encryption checkbox based on the loaded configuration
        identityEncryptionCheckbox.Checked = Globals.IdentityConfig.UseEncryption;

        // Set API key controls
        if (Globals.AiSecrets != null)
        {
            openAiKeyBox.Text = Globals.AiSecrets.OpenAiApiKey;
            anthropicKeyBox.Text = Globals.AiSecrets.AnthropicApiKey;
            geminiKeyBox.Text = Globals.AiSecrets.GoogleApiKey;
        }

        // Fill the start page labels
        int resumeTemplates = 0;
        int cvTemplates = 0;
        int identitiesCount = 0;
        int industriesCount = 0;

        resumeTemplates = Directory.GetFiles(Path.GetFullPath("./templates/resume")).Count(file => Path.GetExtension(file) == ".html");
        cvTemplates = Directory.GetFiles(Path.GetFullPath("./templates/coverletter")).Count(file => Path.GetExtension(file) == ".html");
        identitiesCount = Directory.GetFiles(Path.GetFullPath("./data/identities")).Count(file => Path.GetExtension(file) == ".identity");
        industriesCount = Directory.GetFiles(Path.GetFullPath("./data/industries")).Count(file => Path.GetExtension(file) == ".industry");

        resumeTemplatesCountLabel.Text = resumeTemplates.ToString() + " " + resumeTemplatesCountLabel.Text;
        coverLetterTemplatesCountLabel.Text = cvTemplates.ToString() + " " + coverLetterTemplatesCountLabel.Text;
        identityCountLabel.Text = identitiesCount.ToString() + " " + identityCountLabel.Text;
        industryCountLabel.Text = industriesCount.ToString() + " " + industryCountLabel.Text;
    }

    /// <summary>
    ///     Handles the click event for the "New Identity" button.
    /// </summary>
    /// <param name="sender">The source of the event, typically the button that was clicked.</param>
    /// <param name="e">An EventArgs object that contains the event data.</param>
    private void newIdentityButton_Click(object sender, EventArgs e)
    {
        var identityWorkspace = new IdentityWorkspace();
        identityWorkspace.Show();
    }

    /// <summary>
    ///     Handles the click event for the identity page.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void identityPage_Click(object sender, EventArgs e)
    {
        // Deselect active controls
        identitiesListBox.SelectedItem = null;
    }

    /// <summary>
    ///     Handles the click event for the open identity button.
    ///     Opens a file dialog to select an identity file and imports it if not already present.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void openIdentityButton_Click(object sender, EventArgs e)
    {
        var openFileDialog1 = new OpenFileDialog();

        // Set the initial directory to the identities folder and filter for identity files
        openFileDialog1.InitialDirectory = Path.GetFullPath("./data/identities");
        openFileDialog1.Filter = "Identity files (*.identity)|*.identity";
        openFileDialog1.Title = "Import External Identity File";

        // Show the dialog and check if the user selected a file
        if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

        var selectedFileName = openFileDialog1.FileName;
        var realFileName = Path.GetFileNameWithoutExtension(selectedFileName).ToLower();

        // Check if the file already exists in the identities folder, if not, copy it
        if (!File.Exists("./data/identities/" + realFileName + ".identity"))
            File.Copy(selectedFileName, "./data/identities/" + realFileName + ".identity");

        // Create and show the identity workspace for the selected identity
        var identityWorkspace = new IdentityWorkspace(realFileName);
        identityWorkspace.Show();
    }

    /// <summary>
    ///     Handles the tick event for the identity refresh timer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void identityRefreshTimer_Tick(object sender, EventArgs e)
    {
        // Clear the current items in the identities list box
        identitiesListBox.Items.Clear();

        // Iterate through each file in the identities directory
        foreach (var file in Directory.GetFiles("./data/identities"))
            // Check if the file has an .identity extension
            if (file.EndsWith(".identity"))
            {
                // Format the identity name by converting underscores to spaces and marking encrypted files
                var identityName = Globals.CultureTextInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).Replace("_", " ")
                    .Replace(".enc", " (Encrypted)"));

                // Check if the identity name is not already in the list box
                if (identitiesListBox.Items.All(x => x.Text != identityName))
                {
                    // Create a new list box item with the identity name
                    var item = new MaterialListBoxItem(identityName)
                    {
                        // Set the secondary text to the last modified date of the file
                        SecondaryText = "Last Modified: " + File.GetLastWriteTime(file).ToString("MM/dd/yyyy HH:mm:ss")
                    };

                    // Add the item to the list box and refresh the display
                    identitiesListBox.Items.Add(item);
                    identitiesListBox.Refresh();
                }
            }
    }

    /// <summary>
    ///     Handles the tick event for the history refresh timer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void historyRefreshTimer_Tick(object sender, EventArgs e)
    {
        // Clear the current items in the histories list box
        historiesListBox.Items.Clear();

        // Iterate through each file in the specified directory
        foreach (var file in Directory.GetFiles("./data/industries"))
            // Check if the file has the .industry extension
            if (file.EndsWith(".industry"))
            {
                // Convert the file name to a title case string without the extension and underscores
                var historyName =
                    Globals.CultureTextInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).Replace("_", " "));

                // Check if the item is not already in the list box
                if (historiesListBox.Items.All(x => x.Text != historyName))
                {
                    // Create a new list box item with the history name
                    var item = new MaterialListBoxItem(historyName)
                    {
                        // Set the secondary text to the last modified date of the file
                        SecondaryText = "Last Modified: " + File.GetLastWriteTime(file).ToString("MM/dd/yyyy HH:mm:ss")
                    };

                    // Add the item to the list box and refresh the display
                    historiesListBox.Items.Add(item);
                    historiesListBox.Refresh();
                }
            }
    }

    /// <summary>
    ///     Handles the selected index changed event for the identities list box.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="selectedItem">The selected item in the list box.</param>
    private void identitiesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
    {
        if (identitiesListBox.SelectedItem != null)
        {
            // Retrieve and format the identity name from the selected item
            var identityName = Path.GetFullPath(Path.Combine("./data/identities", identitiesListBox.SelectedItem.Text.Replace(" (Encrypted)", ".enc").Replace(" ", "_") + ".identity"));

            // Create a new IdentityWorkspace instance with the formatted identity name
            var identityWorkspace = new IdentityWorkspace(identityName.ToLower());

            // Clear the selected item in the list box
            identitiesListBox.SelectedItem = null;

            // Display the identity workspace
            identityWorkspace.Show();
        }
    }

    /// <summary>
    ///     Handles the selected index changed event for the histories list box.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="selectedItem">The selected item in the list box.</param>
    private void historiesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
    {
        if (historiesListBox.SelectedItem != null)
        {
            // Replace spaces with underscores in the selected item's text to form a valid file name.
            var historyName = historiesListBox.SelectedItem.Text.Replace(" ", "_");

            // Create a new HistoryWorkspace object using the modified history name.
            var historyWorkspace =
                new HistoryWorkspace(Path.Combine("./data/industries", historyName.ToLower() + ".industry"));

            // Clear the selected item in the list box.
            historiesListBox.SelectedItem = null;

            // Display the history workspace.
            historyWorkspace.Show();
        }
    }

    /// <summary>
    ///     Handles the click event for the identity config expansion panel.
    ///     Sets the ActiveControl property to null to remove focus from any control.
    /// </summary>
    /// <param name="sender">The source of the event, typically the expansion panel.</param>
    /// <param name="e">An EventArgs object that contains the event data.</param>
    private void identityConfigExpansionPanel_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    ///     Handles the checked changed event for the identity encryption checkbox.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void identityEncryptionCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        // Dynamic save button enable/disable
        identityConfigExpansionPanel.ValidationButtonEnable =
            Globals.IdentityConfig.UseEncryption != identityEncryptionCheckbox.Checked;
    }

    /// <summary>
    ///     Handles the save click event for the identity config expansion panel.
    ///     Updates the global identity configuration to use encryption based on the checkbox state
    ///     and disables the validation button on the expansion panel.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void identityConfigExpansionPanel_SaveClick(object sender, EventArgs e)
    {
        Globals.IdentityConfig.UseEncryption = identityEncryptionCheckbox.Checked;
        identityConfigExpansionPanel.ValidationButtonEnable = false;
    }

    /// <summary>
    ///     Handles the form closing event for the EntryForm.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A FormClosingEventArgs that contains the event data.</param>
    private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    /// <summary>
    ///     Handles the click event for the new history button.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void newHistoryButton_Click(object sender, EventArgs e)
    {
        var historyWorkspace = new HistoryWorkspace();
        historyWorkspace.Show();
    }

    /// <summary>
    ///     Handles the click event for the open identity folder button.
    ///     Opens the folder containing identity data files.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void openIdentityFolderButton_Click(object sender, EventArgs e)
    {
        FolderUtils.OpenFolder(Path.GetFullPath("./data/identities"));
    }

    /// <summary>
    ///     Handles the click event for the open industry folder button.
    ///     Opens the folder located at "./data/industries".
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void openIndustryFolderButton_Click(object sender, EventArgs e)
    {
        FolderUtils.OpenFolder(Path.GetFullPath("./data/industries"));
    }

    /// <summary>
    ///     Handles the click event for the industry page.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void industryPage_Click(object sender, EventArgs e)
    {
        historiesListBox.SelectedItem = null;
    }

    /// <summary>
    ///     Handles the click event for the import history button.
    ///     Opens a file dialog to select an industry file and imports it if not already present.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void importHistoryButton_Click(object sender, EventArgs e)
    {
        var openFileDialog1 = new OpenFileDialog();

        // Set the initial directory and filter for the file dialog
        openFileDialog1.InitialDirectory = Path.GetFullPath("./data/industries");
        openFileDialog1.Filter = "Industry files (*.industry)|*.industry";
        openFileDialog1.Title = "Import External Industry File";

        // Show the dialog and check if the user selected a file
        if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

        var selectedFileName = openFileDialog1.FileName;
        var realFileName = Path.GetFileNameWithoutExtension(selectedFileName).ToLower();

        // Check if the file already exists in the target directory
        if (!File.Exists("./data/industries/" + realFileName + ".industry"))
            // Copy the selected file to the target directory
            File.Copy(selectedFileName, "./data/industries/" + realFileName + ".industry");

        // Create and show a new HistoryWorkspace with the selected file
        var industryWorkspace = new HistoryWorkspace(selectedFileName);
        industryWorkspace.Show();
    }

    /// <summary>
    /// Clears the active control when the welcome page is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void welcomePage_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    /// Event handler for the button click event to open the resume workspace.
    /// Prompts the user to select an identity file and an industry file,
    /// then initializes and displays the resume workspace with the selected files.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void openResumeWorkspaceButton_Click(object sender, EventArgs e)
    {
        var identity = new ProfessionalIdentity();
        var industry = new Industry();

        OpenFileDialog identityPicker = new OpenFileDialog();
        identityPicker.Title = "Select an identity file";
        identityPicker.Filter = "Identity files (*.identity)|*.identity";
        identityPicker.InitialDirectory = Path.GetFullPath("./data/identities");

        if (identityPicker.ShowDialog() == DialogResult.OK)
        {
            var identityPath = identityPicker.FileName;
            var identityName = Path.GetFileNameWithoutExtension(identityPath).ToLower();
            using (var file = File.OpenRead(identityPath))
            {
                identity = Serializer.Deserialize<ProfessionalIdentity>(file);
            }
        }
        else
        {
            return;
        }

        OpenFileDialog industryPicker = new OpenFileDialog();
        industryPicker.Title = "Select an industry file";
        industryPicker.Filter = "Industry files (*.industry)|*.industry";
        industryPicker.InitialDirectory = Path.GetFullPath("./data/industries");

        if (industryPicker.ShowDialog() == DialogResult.OK)
        {
            var industryPath = industryPicker.FileName;
            var industryName = Path.GetFileNameWithoutExtension(industryPath).ToLower();
            using (var file = File.OpenRead(industryPath))
            {
                industry = Serializer.Deserialize<Industry>(file);
            }
        }
        else
        {
            return;
        }

        var resumeWorkspace = new ResumeWorkspace(identity, industry);
        resumeWorkspace.Show();
    }

    /// <summary>
    /// Clears the active control when the resume page is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void resumePage_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    /// Clears the active control when the material card is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void materialCard5_Click(object sender, EventArgs e)
    {
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    /// Opens the cover letter builder workspace when the button is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void openCvBuilderButton_Click(object sender, EventArgs e)
    {
        var identity = new ProfessionalIdentity();
        var industry = new Industry();

        OpenFileDialog identityPicker = new OpenFileDialog();
        identityPicker.Title = "Select an identity file";
        identityPicker.Filter = "Identity files (*.identity)|*.identity";
        identityPicker.InitialDirectory = Path.GetFullPath("./data/identities");

        if (identityPicker.ShowDialog() == DialogResult.OK)
        {
            var identityPath = identityPicker.FileName;
            var identityName = Path.GetFileNameWithoutExtension(identityPath).ToLower();
            using (var file = File.OpenRead(identityPath))
            {
                identity = Serializer.Deserialize<ProfessionalIdentity>(file);
            }
        }
        else
        {
            return;
        }

        OpenFileDialog industryPicker = new OpenFileDialog();
        industryPicker.Title = "Select an industry file";
        industryPicker.Filter = "Industry files (*.industry)|*.industry";
        industryPicker.InitialDirectory = Path.GetFullPath("./data/industries");

        if (industryPicker.ShowDialog() == DialogResult.OK)
        {
            var industryPath = industryPicker.FileName;
            var industryName = Path.GetFileNameWithoutExtension(industryPath).ToLower();
            using (var file = File.OpenRead(industryPath))
            {
                industry = Serializer.Deserialize<Industry>(file);
            }
        }
        else
        {
            return;
        }

        var coverLetterWorkspace = new CoverLetterWorkspace(identity, industry);
        coverLetterWorkspace.Show();
        InputUtils.ClearActiveControl(this);
    }

    /// <summary>
    /// Manages the saving of the user's openAI API key to the global configuration.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void openAiKeyBox_TextChanged(object sender, EventArgs e)
    {
        Globals.AiSecrets.OpenAiApiKey = openAiKeyBox.Text;
    }

    /// <summary>
    /// Manages the saving of the user's Anthropic API key to the global configuration.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void anthropicKeyBox_TextChanged(object sender, EventArgs e)
    {
        Globals.AiSecrets.AnthropicApiKey = anthropicKeyBox.Text;
    }

    /// <summary>
    /// Manages the saving of the user's Gemini API key to the global configuration.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void geminiKeyBox_TextChanged(object sender, EventArgs e)
    {
        Globals.AiSecrets.GoogleApiKey = geminiKeyBox.Text;
    }

    /// <summary>
    /// Opens Gemini's API key page in the user's default browser.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void geminiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("explorer.exe", "https://aistudio.google.com/app/apikey");
    }

    /// <summary>
    /// Cleans up the logs folder when clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void clearLogsButton_Click(object sender, EventArgs e)
    {
        DialogResult confirmation = MessageBox.Show("Are you sure?", "Clean Logs Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (confirmation == DialogResult.Yes)
        {
            foreach (var file in Directory.GetFiles(Path.GetFullPath("./logs")))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    // We would log it here, but well y'know...
                }
            }
            MessageBox.Show("Logs cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}