using CareerCanvas.Classes.Static;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CareerCanvas
{
    public partial class EntryForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            FolderUtils.CreateAppFolders();
        }
    }
}