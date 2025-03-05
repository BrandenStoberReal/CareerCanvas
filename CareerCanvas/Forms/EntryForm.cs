using CareerCanvas.Classes.Configs;
using CareerCanvas.Classes.Static;
using CareerCanvas.Forms;
using ProtoBuf;
using ReaLTaiizor.Child.Material;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Globalization;
using System.Net.Security;
using System.Security.Authentication;

namespace CareerCanvas
{
    public partial class EntryForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private readonly TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        private readonly string identityConfigPath = $"./data/configs/identity.careerconfig";

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

            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);
        }

        private async void EntryForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            await readMeView.EnsureCoreWebView2Async();

            FolderUtils.CreateAppFolders();

            // Create encryption key if not exists
            if (!File.Exists("./data/misc/encryption.key"))
            {
                File.WriteAllText("./data/misc/encryption.key", EncryptionUtils.Generate256BitKey());
            }

            // Load identity settings
            if (File.Exists(identityConfigPath))
            {
                // Decrypt identity settings
                EncryptionUtils.DecryptFile(identityConfigPath, identityConfigPath, File.ReadAllText("./data/misc/encryption.key"));

                // Read file
                using (FileStream file = File.OpenRead(identityConfigPath))
                {
                    Globals.IdentityConfig = Serializer.Deserialize<IdentityConfig>(file);
                }
            }

            // Generate encryption key for identity files
            if (Globals.IdentityConfig.UseEncryption && Globals.IdentityConfig.EncryptionKey == null)
            {
                Globals.IdentityConfig.EncryptionKey = EncryptionUtils.Generate256BitKey();
            }

            // Load changelog
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
                        string reply = await httpClient.GetStringAsync("https://raw.githubusercontent.com/BrandenStoberReal/CareerCanvas/refs/heads/main/CHANGELOG.md");
                        var html = Markdig.Markdown.ToHtml(reply);
                        readMeView.NavigateToString(html);
                    }
                    catch (Exception)
                    {
                        readMeView.NavigateToString("<h1>Failed to load changelog</h1>");
                    }
                }
            }

            // Load identity settings
            identityEncryptionCheckbox.Checked = Globals.IdentityConfig.UseEncryption;
        }

        private void newIdentityButton_Click(object sender, EventArgs e)
        {
            IdentityWorkspace identityWorkspace = new IdentityWorkspace();
            identityWorkspace.Show();
        }

        private void identityPage_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            identitiesListBox.SelectedItem = null;
        }

        private void openIdentityButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetFullPath("./data/identities");
            openFileDialog1.Filter = "Identity files (*.identity)|*.identity";
            openFileDialog1.Title = "Import External Identity File";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;
            string realFileName = Path.GetFileNameWithoutExtension(selectedFileName).ToLower();

            if (!File.Exists("./data/identities/" + realFileName + ".identity"))
            {
                File.Copy(selectedFileName, "./data/identities/" + realFileName + ".identity");
            }

            IdentityWorkspace identityWorkspace = new IdentityWorkspace(realFileName);
            identityWorkspace.Show();
        }

        private void identityRefreshTimer_Tick(object sender, EventArgs e)
        {
            identitiesListBox.Items.Clear();
            foreach (string file in Directory.GetFiles("./data/identities"))
            {
                if (file.EndsWith(".identity"))
                {
                    string identityName = textInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).Replace("_", " ").Replace(".enc", " (Encrypted)"));
                    if (!identitiesListBox.Items.Any(x => x.Text == identityName))
                    {
                        MaterialListBoxItem item = new MaterialListBoxItem(identityName);
                        item.SecondaryText = "Last Modified: " + File.GetLastWriteTime(file).ToString("MM/dd/yyyy HH:mm:ss");
                        identitiesListBox.Items.Add(item);
                        identitiesListBox.Refresh();
                    }
                }
            }
        }

        private void identitiesListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (identitiesListBox.SelectedItem != null)
            {
                string identityName = identitiesListBox.SelectedItem.Text.Replace(" (Encrypted)", ".enc").Replace(" ", "_");
                IdentityWorkspace identityWorkspace = new IdentityWorkspace(identityName.ToLower());

                identitiesListBox.SelectedItem = null;
                identityWorkspace.Show();
            }
        }

        private void identityConfigExpansionPanel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

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

        private void identityConfigExpansionPanel_SaveClick(object sender, EventArgs e)
        {
            Globals.IdentityConfig.UseEncryption = identityEncryptionCheckbox.Checked;
            identityConfigExpansionPanel.ValidationButtonEnable = false;
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save identity settings
            using (FileStream file = File.Create(identityConfigPath))
            {
                Serializer.Serialize(file, Globals.IdentityConfig);
            }

            // Encrypt identity settings
            EncryptionUtils.EncryptFile(identityConfigPath, identityConfigPath, File.ReadAllText("./data/misc/encryption.key"));
        }
    }
}