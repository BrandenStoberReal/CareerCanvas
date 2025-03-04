using CareerCanvas.Classes.Static;
using CareerCanvas.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Net.Security;
using System.Security.Authentication;

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
                    string reply = await httpClient.GetStringAsync("https://raw.githubusercontent.com/BrandenStoberReal/CareerCanvas/refs/heads/main/README.md");
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
    }
}