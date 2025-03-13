using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using ProtoBuf;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms
{
    public partial class IdentityWorkspace : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        /// <summary>
        /// Flushes an identity to disk.
        /// </summary>
        private void SaveIdentity()
        {
            // Flush class to disk
            ProfessionalIdentity identity = new ProfessionalIdentity
            {
                FirstName = firstNameTextBox.Text,
                MiddleName = middleNametextBox.Text,
                LastName = lastNameTextBox.Text,
                Address = addressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                ZipCode = zipTextBox.Text,
                PhoneNumber = phoneTextBox.Text,
                Email = emailTextBox.Text,
                LinkedIn = linkedInTextBox.Text,
                Portfolio = portfolioTextBox.Text
            };
            string identityPath = $"./data/identities/{identity.FirstName.ToLower()}_{identity.LastName.ToLower()}.identity";
            using (FileStream file = File.Create(identityPath))
            {
                Serializer.Serialize(file, identity);
            }

            // Encrypt file if enabled
            if (Globals.IdentityConfig.UseEncryption)
            {
                if (Globals.IdentityConfig.EncryptionKey == null)
                {
                    Globals.IdentityConfig.EncryptionKey = EncryptionUtils.Generate256BitKey();
                }
                string key = Globals.IdentityConfig.EncryptionKey;
                string encryptedPath = $"./data/identities/{identity.FirstName.ToLower()}_{identity.LastName.ToLower()}.enc.identity";
                EncryptionUtils.EncryptFile(identityPath, encryptedPath, key);
                File.Delete(identityPath);
            }

            // Update window title
            this.Text = $"{identity.FirstName} {identity.LastName} - Identity Workspace";
        }

        /// <summary>
        /// Loads an identity from disk.
        /// </summary>
        /// <param name="filename">The name of the file, not the path, to load.</param>
        private void LoadIdentity(string filename)
        {
            string identityPath = Path.Combine("./data/identities", filename.ToLower() + ".identity");
            ProfessionalIdentity identity;

            // Handle encrypted files
            if (filename.Contains(".enc"))
            {
                try
                {
                    string key = Globals.IdentityConfig.EncryptionKey;
                    string decryptedPath = $"./data/identities/{filename.Replace(".enc", "")}.identity";
                    EncryptionUtils.DecryptFile(identityPath, decryptedPath, key);
                    File.Delete(identityPath);
                    identityPath = decryptedPath;
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error occurred while decrypting the identity file. Only self-encrypted files are supported at this time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Load binary data
            using (FileStream file = File.OpenRead(identityPath))
            {
                identity = Serializer.Deserialize<ProfessionalIdentity>(file);
            }

            // Populate fields
            firstNameTextBox.Text = identity.FirstName;
            middleNametextBox.Text = identity.MiddleName;
            lastNameTextBox.Text = identity.LastName;
            addressTextBox.Text = identity.Address;
            cityTextBox.Text = identity.City;
            stateTextBox.Text = identity.State;
            zipTextBox.Text = identity.ZipCode;
            phoneTextBox.Text = identity.PhoneNumber;
            emailTextBox.Text = identity.Email;
            linkedInTextBox.Text = identity.LinkedIn;
            portfolioTextBox.Text = identity.Portfolio;

            // Change window title
            this.Text = $"{identity.FirstName} {identity.LastName} - Identity Workspace";
        }

        public IdentityWorkspace(string? filename = null)
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

            if (filename != null)
            {
                LoadIdentity(filename);
                if (firstNameTextBox.Text == String.Empty || lastNameTextBox.Text == String.Empty)
                {
                    this.Text = $"New Identity - Identity Workspace";
                }
            }
            else
            {
                this.Text = "New Identity - Identity Workspace";
            }
        }

        private void IdentityWorkspace_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void IdentityWorkspace_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void IdentityWorkspace_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (firstNameLabel.Text == String.Empty || lastNameLabel.Text == String.Empty)
            {
                MessageBox.Show("First Name and Last Name are required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveIdentity();

            MessageBox.Show("Identity saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetFullPath("./data/identities");
            openFileDialog1.Filter = "Identity files (*.identity)|*.identity";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (firstNameTextBox.Text != String.Empty && lastNameTextBox.Text != String.Empty)
            {
                SaveIdentity();
            }

            string selectedFileName = openFileDialog1.FileName;
            LoadIdentity(Path.GetFileNameWithoutExtension(selectedFileName).ToLower());
        }

        private void IdentityWorkspace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firstNameTextBox.Text == String.Empty || lastNameTextBox.Text == String.Empty)
            {
                DialogResult discardChanges = MessageBox.Show("First name and/or last name are empty! Discard changes?", "Discard", MessageBoxButtons.YesNo);
                if (discardChanges == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else if (discardChanges == DialogResult.Yes)
                {
                    return;
                }
            }

            SaveIdentity();
        }

        private void clearAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                firstNameTextBox.Text = String.Empty;
                middleNametextBox.Text = String.Empty;
                lastNameTextBox.Text = String.Empty;
                addressTextBox.Text = String.Empty;
                cityTextBox.Text = String.Empty;
                stateTextBox.Text = String.Empty;
                zipTextBox.Text = String.Empty;
                phoneTextBox.Text = String.Empty;
                emailTextBox.Text = String.Empty;
                linkedInTextBox.Text = String.Empty;
                portfolioTextBox.Text = String.Empty;

                this.Text = "New Identity - Identity Workspace";
            }
        }
    }
}