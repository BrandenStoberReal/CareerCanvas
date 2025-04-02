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
        Template.GetElementbyId("name").InnerHtml = $"{Identity.FirstName} {Identity.MiddleName} {Identity.LastName}";

        // Address fill
        if (Identity.Address != String.Empty)
        {
            Template.GetElementbyId("address").InnerHtml = "Address: " + Identity.Address;
        }
        else
        {
            Template.GetElementbyId("address").Remove();
        }

        // Email fill
        if (Identity.Email != String.Empty)
        {
            Template.GetElementbyId("email").InnerHtml = "Email: " + Identity.Email;
        }
        else
        {
            Template.GetElementbyId("email").Remove();
        }

        // Phone number fill
        if (Identity.PhoneNumber != String.Empty)
        {
            Template.GetElementbyId("phonenumber").InnerHtml = "Phone: " + Identity.PhoneNumber;
        }
        else
        {
            Template.GetElementbyId("phonenumber").Remove();
        }

        // Linkedin fill
        if (Identity.LinkedIn != String.Empty)
        {
            Template.GetElementbyId("linkedin").InnerHtml = "LinkedIn: " + Identity.LinkedIn;
        }
        else
        {
            Template.GetElementbyId("linkedin").Remove();
        }

        // Job experience fill
        HtmlNode jobTemplate = Template.DocumentNode.Descendants(0).Where(n => n.HasClass("jobentry")).First();
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

                switch (jobNode.InnerHtml)
                {
                    case string title when title.Contains("jobtitle"):
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobtitle", job.JobTitle);
                        break;

                    case string company when company.Contains("jobcompany"):
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobcompany", job.CompanyName);
                        break;

                    case string startMonth when startMonth.Contains("jobstartmonth"):
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobstartmonth", job.StartDate.ToString("MMMM"));
                        break;

                    case string endMonth when endMonth.Contains("jobendmonth"):
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobendmonth", job.EndDate.ToString("MMMM"));
                        break;

                    case string startYear when startYear.Contains("jobstartyear"):
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobstartyear", job.StartDate.ToString("yyyy"));
                        break;

                    case string endYear when endYear.Contains("jobendyear"):
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobendyear", job.EndDate.ToString("yyyy"));
                        break;

                    case string summary when summary.Contains("jobsummary"):
                        if (job.JobDescription != String.Empty)
                        {
                            jobNode.InnerHtml = jobNode.InnerHtml.Replace("jobsummary", job.JobDescription);
                        }
                        else
                        {
                            jobNode.Descendants().Where(n => n.InnerText == "jobsummary").First().Remove();
                        }
                        break;
                }
            }
            jobTemplate.Remove();
        }

        // Job education fill
        HtmlNode educationTemplate = Template.DocumentNode.Descendants(0).Where(n => n.HasClass("educationentry")).First();
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

                switch (eduNode.InnerHtml)
                {
                    case string degree when degree.Contains("degree"):
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("degree", EnumUtils.GetEnumDescription(education.Degree));
                        break;

                    case string school when school.Contains("schoolname"):
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolname", education.SchoolName);
                        break;

                    case string startMonth when startMonth.Contains("schoolstartmonth"):
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolstartmonth", education.StartDate.ToString("MMMM"));
                        break;

                    case string endMonth when endMonth.Contains("schoolendmonth"):
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolendmonth", education.EndDate.ToString("MMMM"));
                        break;

                    case string startYear when startYear.Contains("schoolstartyear"):
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolstartyear", education.StartDate.ToString("yyyy"));
                        break;

                    case string endYear when endYear.Contains("schoolendyear"):
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("schoolendyear", education.EndDate.ToString("yyyy"));
                        break;
                }
            }
            jobTemplate.Remove();
        }

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