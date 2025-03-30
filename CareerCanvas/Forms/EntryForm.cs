using CareerCanvas.Classes.Configs;
using CareerCanvas.Classes.Static;
using CareerCanvas.Forms;
using ProtoBuf;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System.Net.Security;
using System.Security.Authentication;

namespace CareerCanvas
{
    public partial class EntryForm : MaterialForm
    {
        // Instances
        private readonly MaterialSkinManager materialSkinManager;

        /// <summary>
        /// Constructor for the EntryForm class.
        /// Initializes the form components and configures the MaterialSkinManager settings.
        /// </summary>
        public EntryForm()
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
        }

        /// <summary>
        /// Load event handler for the EntryForm. Initializes the form by setting up necessary configurations,
        /// ensuring the WebView2 component is ready, creating application folders, handling encryption keys,
        /// loading identity settings, and fetching the changelog.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private async void EntryForm_Load(object sender, EventArgs e)
        {
            // Set the active control to null to prevent any control from being focused initially
            this.ActiveControl = null;

            // Ensure the WebView2 component is initialized and ready
            await readMeView.EnsureCoreWebView2Async();

            // Create necessary application folders if they do not exist
            FolderUtils.CreateAppFolders();

            // Create an encryption key if it does not exist
            if (!File.Exists("./data/misc/encryption.key"))
            {
                File.WriteAllText("./data/misc/encryption.key", EncryptionUtils.Generate256BitKey());
            }

            // Load identity settings if the configuration file exists
            if (File.Exists(Globals.IdentityConfigPath))
            {
                // Decrypt the identity settings file using the encryption key
                EncryptionUtils.DecryptFile(Globals.IdentityConfigPath, Globals.IdentityConfigPath, File.ReadAllText("./data/misc/encryption.key"));

                // Read and deserialize the identity configuration file
                using (FileStream file = File.OpenRead(Globals.IdentityConfigPath))
                {
                    Globals.IdentityConfig = Serializer.Deserialize<IdentityConfig>(file);
                }
            }

            // Generate an encryption key for identity files if encryption is enabled and no key exists
            if (Globals.IdentityConfig.UseEncryption && Globals.IdentityConfig.EncryptionKey == null)
            {
                Globals.IdentityConfig.EncryptionKey = EncryptionUtils.Generate256BitKey();
            }

            // Load the changelog from a remote source
            using (SocketsHttpHandler handler = new SocketsHttpHandler())
            {
                handler.AllowAutoRedirect = true;
                handler.EnableMultipleHttp3Connections = true;
                handler.UseProxy = false;
                handler.AllowAutoRedirect = true;
                handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
                handler.SslOptions = new SslClientAuthenticationOptions
                {
                    EnabledSslProtocols = SslProtocols.Tls13 | SslProtocols.Tls12
                };
                using (HttpClient httpClient = new HttpClient(handler))
                {
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "CareerCanvas");
                    httpClient.DefaultRequestVersion = new Version(3, 0);
                    try
                    {
                        // Fetch the changelog markdown file and convert it to HTML
                        string reply = await httpClient.GetStringAsync("https://raw.githubusercontent.com/BrandenStoberReal/CareerCanvas/refs/heads/main/CHANGELOG.md");
                        var html = Markdig.Markdown.ToHtml(reply);
                        readMeView.NavigateToString(html);
                    }
                    catch (Exception ex)
                    {
                        // Display an error message if the changelog fails to load
                        readMeView.NavigateToString("<h1>Failed to load changelog</h1><p>" + ex.Message + "</p>");
                    }
                }
            }

            // Set the identity encryption checkbox based on the loaded configuration
            identityEncryptionCheckbox.Checked = Globals.IdentityConfig.UseEncryption;
        }

        /// <summary>
        /// Handles the click event for the "New Identity" button.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void newIdentityButton_Click(object sender, EventArgs e)
        {
            IdentityWorkspace identityWorkspace = new IdentityWorkspace();
            identityWorkspace.Show();
        }

        /// <summary>
        /// Handles the click event for the identity page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void identityPage_Click(object sender, EventArgs e)
        {
            // Deselect active controls
            this.ActiveControl = null;
            identitiesListBox.SelectedItem = null;
        }

        /// <summary>
        /// Handles the click event for the open identity button.
        /// Opens a file dialog to select an identity file and imports it if not already present.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void openIdentityButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the initial directory to the identities folder and filter for identity files
            openFileDialog1.InitialDirectory = Path.GetFullPath("./data/identities");
            openFileDialog1.Filter = "Identity files (*.identity)|*.identity";
            openFileDialog1.Title = "Import External Identity File";

            // Show the dialog and check if the user selected a file
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;
            string realFileName = Path.GetFileNameWithoutExtension(selectedFileName).ToLower();

            // Check if the file already exists in the identities folder, if not, copy it
            if (!File.Exists("./data/identities/" + realFileName + ".identity"))
            {
                File.Copy(selectedFileName, "./data/identities/" + realFileName + ".identity");
            }

            // Create and show the identity workspace for the selected identity
            IdentityWorkspace identityWorkspace = new IdentityWorkspace(realFileName);
            identityWorkspace.Show();
        }

        /// <summary>
        /// Handles the tick event for the identity refresh timer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void identityRefreshTimer_Tick(object sender, EventArgs e)
        {
            // Clear the current items in the identities list box
            identitiesListBox.Items.Clear();

            // Iterate through each file in the identities directory
            foreach (string file in Directory.GetFiles("./data/identities"))
            {
                // Check if the file has an .identity extension
                if (file.EndsWith(".identity"))
                {
                    // Format the identity name by converting underscores to spaces and marking encrypted files
                    string identityName = Globals.textInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).Replace("_", " ").Replace(".enc", " (Encrypted)"));

                    // Check if the identity name is not already in the list box
                    if (!identitiesListBox.Items.Any(x => x.Text == identityName))
                    {
                        // Create a new list box item with the identity name
                        MaterialListBoxItem item = new MaterialListBoxItem(identityName);

                        // Set the secondary text to the last modified date of the file
                        item.SecondaryText = "Last Modified: " + File.GetLastWriteTime(file).ToString("MM/dd/yyyy HH:mm:ss");

                        // Add the item to the list box and refresh the display
                        identitiesListBox.Items.Add(item);
                        identitiesListBox.Refresh();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the tick event for the history refresh timer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void historyRefreshTimer_Tick(object sender, EventArgs e)
        {
            // Clear the current items in the histories list box
            historiesListBox.Items.Clear();

            // Iterate through each file in the specified directory
            foreach (string file in Directory.GetFiles("./data/industries"))
            {
                // Check if the file has the .industry extension
                if (file.EndsWith(".industry"))
                {
                    // Convert the file name to a title case string without the extension and underscores
                    string historyName = Globals.textInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).Replace("_", " "));

                    // Check if the item is not already in the list box
                    if (!historiesListBox.Items.Any(x => x.Text == historyName))
                    {
                        // Create a new list box item with the history name
                        MaterialListBoxItem item = new MaterialListBoxItem(historyName);

                        // Set the secondary text to the last modified date of the file
                        item.SecondaryText = "Last Modified: " + File.GetLastWriteTime(file).ToString("MM/dd/yyyy HH:mm:ss");

                        // Add the item to the list box and refresh the display
                        historiesListBox.Items.Add(item);
                        historiesListBox.Refresh();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the selected index changed event for the identities list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="selectedItem">The selected item in the list box.</param>
        private void identitiesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (identitiesListBox.SelectedItem != null)
            {
                // Retrieve and format the identity name from the selected item
                string identityName = identitiesListBox.SelectedItem.Text.Replace(" (Encrypted)", ".enc").Replace(" ", "_");

                // Create a new IdentityWorkspace instance with the formatted identity name
                IdentityWorkspace identityWorkspace = new IdentityWorkspace(identityName.ToLower());

                // Clear the selected item in the list box
                identitiesListBox.SelectedItem = null;

                // Display the identity workspace
                identityWorkspace.Show();
            }
        }

        /// <summary>
        /// Handles the selected index changed event for the histories list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="selectedItem">The selected item in the list box.</param>
        private void historiesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (historiesListBox.SelectedItem != null)
            {
                // Replace spaces with underscores in the selected item's text to form a valid file name.
                string historyName = historiesListBox.SelectedItem.Text.Replace(" ", "_");

                // Create a new HistoryWorkspace object using the modified history name.
                HistoryWorkspace historyWorkspace = new HistoryWorkspace(Path.Combine("./data/industries", historyName.ToLower() + ".industry"));

                // Clear the selected item in the list box.
                historiesListBox.SelectedItem = null;

                // Display the history workspace.
                historyWorkspace.Show();
            }
        }

        /// <summary>
        /// Handles the click event for the identity config expansion panel.
        /// Sets the ActiveControl property to null to remove focus from any control.
        /// </summary>
        /// <param name="sender">The source of the event, typically the expansion panel.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void identityConfigExpansionPanel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        /// <summary>
        /// Handles the checked changed event for the identity encryption checkbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void identityEncryptionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Dynamic save button enable/disable
            if (Globals.IdentityConfig.UseEncryption != identityEncryptionCheckbox.Checked)
            {
                identityConfigExpansionPanel.ValidationButtonEnable = true;
            }
            else
            {
                identityConfigExpansionPanel.ValidationButtonEnable = false;
            }
        }

        /// <summary>
        /// Handles the text changed event for the identity encryption password box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void identityEncryptionPasswordBox_TextChanged(object sender, EventArgs e)
        {
            // Dynamic save button enable/disable
            if (Globals.IdentityConfig.UseEncryption != identityEncryptionCheckbox.Checked)
            {
                identityConfigExpansionPanel.ValidationButtonEnable = true;
            }
            else
            {
                identityConfigExpansionPanel.ValidationButtonEnable = false;
            }
        }

        /// <summary>
        /// Handles the save click event for the identity config expansion panel.
        /// Updates the global identity configuration to use encryption based on the checkbox state
        /// and disables the validation button on the expansion panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void identityConfigExpansionPanel_SaveClick(object sender, EventArgs e)
        {
            Globals.IdentityConfig.UseEncryption = identityEncryptionCheckbox.Checked;
            identityConfigExpansionPanel.ValidationButtonEnable = false;
        }

        /// <summary>
        /// Handles the form closing event for the EntryForm.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A FormClosingEventArgs that contains the event data.</param>
        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        /// <summary>
        /// Handles the click event for the new history button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void newHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryWorkspace historyWorkspace = new HistoryWorkspace();
            historyWorkspace.Show();
        }

        /// <summary>
        /// Handles the click event for the open identity folder button.
        /// Opens the folder containing identity data files.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void openIdentityFolderButton_Click(object sender, EventArgs e)
        {
            FolderUtils.OpenFolder(Path.GetFullPath("./data/identities"));
        }

        /// <summary>
        /// Handles the click event for the open industry folder button.
        /// Opens the folder located at "./data/industries".
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void openIndustryFolderButton_Click(object sender, EventArgs e)
        {
            FolderUtils.OpenFolder(Path.GetFullPath("./data/industries"));
        }

        /// <summary>
        /// Handles the click event for the industry page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void industryPage_Click(object sender, EventArgs e)
        {
            historiesListBox.SelectedItem = null;
        }

        /// <summary>
        /// Handles the click event for the import history button.
        /// Opens a file dialog to select an industry file and imports it if not already present.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void importHistoryButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the initial directory and filter for the file dialog
            openFileDialog1.InitialDirectory = Path.GetFullPath("./data/industries");
            openFileDialog1.Filter = "Industry files (*.industry)|*.industry";
            openFileDialog1.Title = "Import External Industry File";

            // Show the dialog and check if the user selected a file
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;
            string realFileName = Path.GetFileNameWithoutExtension(selectedFileName).ToLower();

            // Check if the file already exists in the target directory
            if (!File.Exists("./data/industries/" + realFileName + ".industry"))
            {
                // Copy the selected file to the target directory
                File.Copy(selectedFileName, "./data/industries/" + realFileName + ".industry");
            }

            // Create and show a new HistoryWorkspace with the selected file
            HistoryWorkspace industryWorkspace = new HistoryWorkspace(selectedFileName);
            industryWorkspace.Show();
        }
    }
}