using CareerCanvas.Classes.Main;
using ProtoBuf;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CareerCanvas.Forms
{
    public partial class IdentityWorkspace : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        private void SaveIdentity()
        {
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

            this.Text = $"{identity.FirstName} {identity.LastName} - Identity Workspace";
        }

        private void LoadIdentity(string filename)
        {
            string identityPath = Path.Combine("./data/identities", filename.ToLower() + ".identity");
            ProfessionalIdentity identity;
            using (FileStream file = File.OpenRead(identityPath))
            {
                identity = Serializer.Deserialize<ProfessionalIdentity>(file);
            }
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

            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);

            if (filename != null)
            {
                LoadIdentity(filename);
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

            string selectedFileName = openFileDialog1.FileName;
            LoadIdentity(Path.GetFileNameWithoutExtension(selectedFileName).ToLower());
        }
    }
}