using CareerCanvas.Classes.Main.Misc;
using CareerCanvas.Classes.Static;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace CareerCanvas.Forms.InputDialogs
{
    public partial class CoverLetterInfoForm : MaterialForm
    {
        private CoverLetterInfo _info;
        public CoverLetterInfoForm(ref CoverLetterInfo info)
        {
            InitializeComponent();
            _info = info;

            var materialSkinManager1 = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager1.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager1.AddFormToManage(this);
            materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
            Globals.AppLogger.Debug("Applied global color scheme to CoverLetterInfoForm: {ColorScheme}", Globals.AppConfig.ColorScheme.ToString());
        }

        private void CoverLetterInfoForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_info.CompanyName))
            {
                companyNameBox.Text = _info.CompanyName;
            }
            if (!string.IsNullOrEmpty(_info.JobTitle))
            {
                jobTitleBox.Text = _info.JobTitle;
            }
            if (!string.IsNullOrEmpty(_info.RecipientFirstName))
            {
                recipientFirstNameBox.Text = _info.RecipientFirstName;
            }
            if (!string.IsNullOrEmpty(_info.RecipientLastName))
            {
                recipientLastNameBox.Text = _info.RecipientLastName;
            }
            if (!string.IsNullOrEmpty(_info.RecipientPrefix))
            {
                recipientPrefixBox.Text = _info.RecipientPrefix;
            }
            if (!string.IsNullOrEmpty(_info.CompanyAddress))
            {
                companyAddressBox.Text = _info.CompanyAddress;
            }
            if (!string.IsNullOrEmpty(_info.CompanyCity))
            {
                companyCityBox.Text = _info.CompanyCity;
            }
            if (!string.IsNullOrEmpty(_info.CompanyState))
            {
                companyStateBox.Text = _info.CompanyState;
            }
            if (!string.IsNullOrEmpty(_info.CompanyZip))
            {
                companyZipBox.Text = _info.CompanyZip;
            }
            if (!string.IsNullOrEmpty(_info.CompanyPhone))
            {
                companyPhoneBox.Text = _info.CompanyPhone;
            }
            if (!string.IsNullOrEmpty(_info.CompanyEmail))
            {
                companyEmailBox.Text = _info.CompanyEmail;
            }
            if (!string.IsNullOrEmpty(_info.CompanyWebsite))
            {
                companyWebsiteBox.Text = _info.CompanyWebsite;
            }
            if (!string.IsNullOrEmpty(_info.RecipientTitle))
            {
                recipientTitleBox.Text = _info.RecipientTitle;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoverLetterInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _info.CompanyName = companyNameBox.Text;
            _info.JobTitle = jobTitleBox.Text;
            _info.RecipientFirstName = recipientFirstNameBox.Text;
            _info.RecipientLastName = recipientLastNameBox.Text;
            _info.RecipientPrefix = recipientPrefixBox.Text;
            _info.CompanyAddress = companyAddressBox.Text;
            _info.CompanyCity = companyCityBox.Text;
            _info.CompanyState = companyStateBox.Text;
            _info.CompanyZip = companyZipBox.Text;
            _info.CompanyPhone = companyPhoneBox.Text;
            _info.CompanyEmail = companyEmailBox.Text;
            _info.CompanyWebsite = companyWebsiteBox.Text;
            _info.RecipientTitle = recipientTitleBox.Text;
        }
    }
}
