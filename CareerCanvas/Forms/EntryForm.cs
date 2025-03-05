using CareerCanvas.Classes.Static;
using CareerCanvas.Forms;
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

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            await readMeView.EnsureCoreWebView2Async();

            FolderUtils.CreateAppFolders();

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
                    string reply = await httpClient.GetStringAsync("https://raw.githubusercontent.com/BrandenStoberReal/CareerCanvas/refs/heads/main/CHANGELOG.md");
                    var html = Markdig.Markdown.ToHtml(reply);
                    readMeView.NavigateToString(html);
                }
            }
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
            openFileDialog1.Title = "Open External Identity File";

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
            foreach (string file in Directory.GetFiles("./data/identities"))
            {
                if (file.EndsWith(".identity"))
                {
                    string identityName = textInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).Replace("_", " "));
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
                string identityName = identitiesListBox.SelectedItem.Text.Replace(" ", "_");
                IdentityWorkspace identityWorkspace = new IdentityWorkspace(identityName.ToLower());

                identitiesListBox.SelectedItem = null;
                identityWorkspace.Show();
            }
        }
    }
}