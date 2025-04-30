using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using ProtoBuf;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.Workspaces;

public sealed partial class IdentityWorkspace : MaterialForm
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityWorkspace"/> class.
    /// </summary>
    /// <param name="file"></param>
    public IdentityWorkspace(string? file = null)
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
        Globals.AppLogger.Debug("Applied global color scheme to IdentityWorkspace: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());

        // Load identity if filename is provided
        if (file != null)
        {
            LoadIdentity(file);
            if (firstNameTextBox.Text == string.Empty || lastNameTextBox.Text == string.Empty)
                Text = "New Identity - Identity Workspace";
        }
        else
        {
            Text = "New Identity - Identity Workspace";
        }
    }

    /// <summary>
    /// Flushes an identity to disk.
    /// </summary>
    private void SaveIdentity()
    {
        // Flush class to disk
        var identity = new ProfessionalIdentity
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

        // Write identity to path
        var identityPath = Path.GetFullPath($"./data/identities/{identity.FirstName.ToLower()}_{identity.LastName.ToLower()}.identity");
        using (var file = File.Create(identityPath))
        {
            Serializer.Serialize(file, identity);
        }

        // Encrypt file if enabled
        if (Globals.IdentityConfig.UseEncryption)
        {
            Globals.IdentityConfig.EncryptionKey ??= EncryptionUtils.Generate256BitKey();
            var key = Globals.IdentityConfig.EncryptionKey;
            var encryptedPath =
                Path.GetFullPath($"./data/identities/{identity.FirstName.ToLower()}_{identity.LastName.ToLower()}.enc.identity");
            EncryptionUtils.EncryptFile(identityPath, encryptedPath, key);
            File.Delete(identityPath);
        }

        // Update window title
        Text = $"{identity.FirstName} {identity.LastName} - Identity Workspace";

        Globals.AppLogger.Information("Saved identity to {Path}", identityPath);
    }

    /// <summary>
    /// Loads an identity from disk.
    /// </summary>
    /// <param name="file">The name of the file, not the path, to load.</param>
    private void LoadIdentity(string file)
    {
        try
        {

            var identityPath = Path.GetFullPath(file);
            ProfessionalIdentity identity;

            // Handle encrypted files
            if (file.Contains(".enc"))
                try
                {
                    var key = Globals.IdentityConfig.EncryptionKey;
                    var decryptedPath = file.Replace(".enc", "");
                    if (key != null)
                    {
                        EncryptionUtils.DecryptFile(identityPath, decryptedPath, key);
                        File.Delete(identityPath);
                        identityPath = decryptedPath;
                    }
                }
                catch
                {
                    MessageBox.Show(
                        "An internal error occurred while decrypting the identity file. The key may be corrupt or missing.",
                        "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            // Load binary data
            // ReSharper disable once IdentifierTypo
            using (var filey = File.OpenRead(identityPath))
            {
                identity = Serializer.Deserialize<ProfessionalIdentity>(filey);
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
            Text = $"{identity.FirstName} {identity.LastName} - Identity Workspace";

            Globals.AppLogger.Information("Loaded identity from {Path}", identityPath);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "An internal error occurred while loading the identity file. The file may be corrupt or missing.",
                "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Globals.AppLogger.Error(ex, "Failed to load identity from {Path}", file);
            this.Close();
        }
    }

    /// <summary>
    /// Sets the active control to null when the form loads.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void IdentityWorkspace_Load(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    /// <summary>
    /// Sets the active control to null when the form is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void IdentityWorkspace_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    /// <summary>
    /// Sets the active control to null when the form is shown.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void IdentityWorkspace_Shown(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    /// <summary>
    /// Saves the identity to disk when the save button is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var openFileDialog1 = new OpenFileDialog();

        openFileDialog1.InitialDirectory = Path.GetFullPath("./data/identities");
        openFileDialog1.Filter = "Identity files (*.identity)|*.identity";

        if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

        if (firstNameTextBox.Text != string.Empty && lastNameTextBox.Text != string.Empty) SaveIdentity();

        var selectedFileName = openFileDialog1.FileName;
        LoadIdentity(selectedFileName);
    }

    /// <summary>
    /// Saves the identity to disk when the form closes.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void IdentityWorkspace_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (firstNameTextBox.Text == string.Empty || lastNameTextBox.Text == string.Empty)
        {
            var discardChanges = MessageBox.Show("First name and/or last name are empty! Discard changes?", "Discard",
                MessageBoxButtons.YesNo);
            if (discardChanges == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            if (discardChanges == DialogResult.Yes)
            {
                Globals.AppLogger.Warning("User discarded changes to identity due to missing required fields.");
                return;
            }
        }

        SaveIdentity();
    }

    /// <summary>
    /// Clears all fields when the button is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void clearAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Clear Fields",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.Yes)
        {
            firstNameTextBox.Text = string.Empty;
            middleNametextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            stateTextBox.Text = string.Empty;
            zipTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            linkedInTextBox.Text = string.Empty;
            portfolioTextBox.Text = string.Empty;

            Text = "New Identity - Identity Workspace";
            Globals.AppLogger.Debug("Cleared all fields in Identity Workspace.");
        }
    }
}