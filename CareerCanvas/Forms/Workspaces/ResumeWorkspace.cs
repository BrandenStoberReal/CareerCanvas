using CareerCanvas.Classes.Main.Protobuf;
using ReaLTaiizor.Forms;

namespace CareerCanvas.Forms.Workspaces
{
    public partial class ResumeWorkspace : MaterialForm
    {
        public ResumeWorkspace(ProfessionalIdentity identity, Industry industry)
        {
            InitializeComponent();
        }

        private void ResumeWorkspace_Load(object sender, EventArgs e)
        {
            resumeViewer.EnsureCoreWebView2Async();
        }
    }
}