using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using HtmlAgilityPack;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Forms.Workspaces;

public partial class ResumeWorkspace : MaterialForm
{
    private ProfessionalIdentity Identity { get; set; }
    private Industry Industry { get; set; }
    private HtmlDocument Template { get; set; }

    public ResumeWorkspace(ProfessionalIdentity identity, Industry industry)
    {
        InitializeComponent();

        Identity = identity;
        Industry = industry;

        var materialSkinManager1 = MaterialSkinManager.Instance;

        // Set this to false to disable backcolor enforcing on non-materialSkin components
        // This HAS to be set before the AddFormToManage()
        materialSkinManager1.EnforceBackcolorOnAllComponents = true;

        // MaterialSkinManager properties
        materialSkinManager1.AddFormToManage(this);
        materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;

        materialSkinManager1.ColorScheme = Globals.AppConfig.ColorScheme;
    }

    /// <summary>
    /// Fills the provided HTML document with identity data, including name, address, email, phone number,
    /// LinkedIn profile, job experience, and education details.
    /// </summary>
    /// <param name="doc">The HtmlDocument to be filled with identity data.</param>
    private void FillDocumentData(HtmlDocument doc)
    {
        // Replace placeholders with identity data
        doc.GetElementbyId("name").InnerHtml = $"{Identity.FirstName} {Identity.MiddleName} {Identity.LastName}";

        // Address fill
        if (Identity.Address != String.Empty)
        {
            doc.GetElementbyId("address").InnerHtml = "Address: " + Identity.Address;
        }
        else
        {
            doc.GetElementbyId("address").Remove();
        }

        // Email fill
        if (Identity.Email != String.Empty)
        {
            doc.GetElementbyId("email").InnerHtml = "Email: " + Identity.Email;
        }
        else
        {
            doc.GetElementbyId("email").Remove();
        }

        // Phone number fill
        if (Identity.PhoneNumber != String.Empty)
        {
            doc.GetElementbyId("phonenumber").InnerHtml = "Phone: " + Identity.PhoneNumber;
        }
        else
        {
            doc.GetElementbyId("phonenumber").Remove();
        }

        // Linkedin fill
        if (Identity.LinkedIn != String.Empty)
        {
            doc.GetElementbyId("linkedin").InnerHtml = "LinkedIn: " + Identity.LinkedIn;
        }
        else
        {
            doc.GetElementbyId("linkedin").Remove();
        }

        // Job experience fill
        HtmlNode jobTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("jobentry")).First();
        if (Industry.Jobs.Count == 0)
        {
            jobTemplate.Remove();
        }
        else
        {
            foreach (Employment job in Industry.Jobs)
            {
                HtmlNode jobNode = jobTemplate.Clone();
                jobTemplate.ParentNode.AppendChild(jobNode);

                if (jobNode.InnerHtml.Contains("jobtitle"))
                {
                    jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobtitle", job.JobTitle);
                }
                if (jobNode.InnerHtml.Contains("jobcompany"))
                {
                    jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobcompany", job.CompanyName);
                }
                if (jobNode.InnerHtml.Contains("jobstartmonth"))
                {
                    jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobstartmonth", job.StartDate.ToString("MMMM"));
                }
                if (jobNode.InnerHtml.Contains("jobendmonth"))
                {
                    jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobendmonth", job.EndDate.ToString("MMMM"));
                }
                if (jobNode.InnerHtml.Contains("jobstartyear"))
                {
                    jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobstartyear", job.StartDate.ToString("yyyy"));
                }
                if (jobNode.InnerHtml.Contains("jobendyear"))
                {
                    jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobendyear", job.EndDate.ToString("yyyy"));
                }
                if (jobNode.InnerHtml.Contains("jobsummary"))
                {
                    if (job.JobDescription != String.Empty)
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobsummary", job.JobDescription);
                    }
                    else
                    {
                        jobNode.Descendants().Where(n => n.InnerText == "jobsummary").First().Remove();
                    }
                }
            }
            jobTemplate.Remove();
        }

        // Job education fill
        HtmlNode educationTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("educationentry")).First();
        if (Industry.Schooling.Count == 0)
        {
            educationTemplate.Remove();
        }
        else
        {
            foreach (Education education in Industry.Schooling)
            {
                HtmlNode eduNode = educationTemplate.Clone();
                educationTemplate.ParentNode.AppendChild(eduNode);

                if (eduNode.InnerHtml.Contains("degree"))
                {
                    eduNode.InnerHtml = eduNode.InnerHtml.Replace("degree", EnumUtils.GetEnumDescription(education.Degree));
                }
                if (eduNode.InnerHtml.Contains("schoolname"))
                {
                    eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolname", education.SchoolName);
                }

                if (eduNode.InnerHtml.Contains("schoolstartmonth"))
                {
                    eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolstartmonth", education.StartDate.ToString("MMMM"));
                }

                if (eduNode.InnerHtml.Contains("schoolendmonth"))
                {
                    eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolendmonth", education.EndDate.ToString("MMMM"));
                }

                if (eduNode.InnerHtml.Contains("schoolstartyear"))
                {
                    eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolstartyear", education.StartDate.ToString("yyyy"));
                }

                if (eduNode.InnerHtml.Contains("schoolendyear"))
                {
                    eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolendyear", education.EndDate.ToString("yyyy"));
                }
                educationTemplate.Remove();
            }
        }
    }

    private void ResumeWorkspace_Load(object sender, EventArgs e)
    {
        // Load the webview runtime
        resumeViewer.EnsureCoreWebView2Async();
    }

    private void openTemplateFolderButton_Click(object sender, EventArgs e)
    {
        FolderUtils.OpenFolder(Path.GetFullPath("./templates/resume"));
    }

    private void resumeViewer_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
    {
        // Load default template
        Template = new HtmlDocument();
        Template.LoadHtml(File.ReadAllText("./templates/resume/default.html"));

        // Replace placeholders with identity data
        FillDocumentData(Template);

        // Load the template into the webview
        resumeViewer.NavigateToString(Template.DocumentNode.OuterHtml);
    }

    private void materialCard1_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }

    private void materialCard2_Click(object sender, EventArgs e)
    {
        ActiveControl = null;
    }
}