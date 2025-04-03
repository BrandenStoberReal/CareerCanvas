using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Protobuf;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Static.Utils
{
    public static class ResumeUtils
    {
        /// <summary>
        /// Fills the provided HTML document with identity data, including name, address, email, phone number,
        /// LinkedIn profile, job experience, and education details.
        /// </summary>
        /// <param name="doc">The HtmlDocument to be filled with identity data.</param>
        public static void FillDocumentData(HtmlDocument doc, ProfessionalIdentity identity, Industry industry)
        {
            // Replace placeholders with identity data
            doc.GetElementbyId("name").InnerHtml = $"{identity.FirstName} {identity.MiddleName} {identity.LastName}";

            // Address fill
            if (identity.Address != String.Empty)
            {
                doc.GetElementbyId("address").InnerHtml = "Address: " + identity.Address;
            }
            else
            {
                doc.GetElementbyId("address").Remove();
            }

            // Email fill
            if (identity.Email != String.Empty)
            {
                doc.GetElementbyId("email").InnerHtml = "Email: " + identity.Email;
            }
            else
            {
                doc.GetElementbyId("email").Remove();
            }

            // Phone number fill
            if (identity.PhoneNumber != String.Empty)
            {
                doc.GetElementbyId("phonenumber").InnerHtml = "Phone: " + identity.PhoneNumber;
            }
            else
            {
                doc.GetElementbyId("phonenumber").Remove();
            }

            // Linkedin fill
            if (identity.LinkedIn != String.Empty)
            {
                doc.GetElementbyId("linkedin").InnerHtml = "LinkedIn: " + identity.LinkedIn;
            }
            else
            {
                doc.GetElementbyId("linkedin").Remove();
            }

            // Job experience fill
            HtmlNode jobTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("jobentry")).First();
            if (industry.Jobs.Count == 0)
            {
                jobTemplate.Remove();
            }
            else
            {
                foreach (Employment job in industry.Jobs)
                {
                    HtmlNode jobNode = jobTemplate.Clone();
                    jobTemplate.ParentNode.AppendChild(jobNode);

                    if (jobNode.InnerHtml.Contains("{{jobTitle}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobTitle}}", job.JobTitle);
                    }
                    if (jobNode.InnerHtml.Contains("{{jobCompanyName}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobCompanyName}}", job.CompanyName);
                    }
                    if (jobNode.InnerHtml.Contains("{{jobStartMonth}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobStartMonth}}", job.StartDate.ToString("MMMM"));
                    }
                    if (jobNode.InnerHtml.Contains("{{jobEndMonth}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobEndMonth}}", job.EndDate.ToString("MMMM"));
                    }
                    if (jobNode.InnerHtml.Contains("{{jobStartYear}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobStartYear}}", job.StartDate.ToString("yyyy"));
                    }
                    if (jobNode.InnerHtml.Contains("{{jobEndYear}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobEndYear}}", job.EndDate.ToString("yyyy"));
                    }
                    if (jobNode.InnerHtml.Contains("{{jobDescription}}"))
                    {
                        if (job.JobDescription != String.Empty)
                        {
                            jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobDescription}}", job.JobDescription);
                        }
                        else
                        {
                            jobNode.Descendants().Where(n => n.InnerText == "{{jobDescription}}").First().Remove();
                        }
                    }
                }
                jobTemplate.Remove();
            }

            // Job education fill
            HtmlNode educationTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("educationentry")).First();
            if (industry.Schooling.Count == 0)
            {
                educationTemplate.Remove();
            }
            else
            {
                foreach (Education education in industry.Schooling)
                {
                    HtmlNode eduNode = educationTemplate.Clone();
                    educationTemplate.ParentNode.AppendChild(eduNode);

                    if (eduNode.InnerHtml.Contains("{{degreeType}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{degreeType}}", EnumUtils.GetEnumDescription(education.Degree));
                    }
                    if (eduNode.InnerHtml.Contains("{{schoolName}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolName}}", education.SchoolName);
                    }

                    if (eduNode.InnerHtml.Contains("{{schoolStartMonth}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolStartMonth}}", education.StartDate.ToString("MMMM"));
                    }

                    if (eduNode.InnerHtml.Contains("{{schoolEndMonth}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolEndMonth}}", education.EndDate.ToString("MMMM"));
                    }

                    if (eduNode.InnerHtml.Contains("{{schoolStartYear}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolStartYear}}", education.StartDate.ToString("yyyy"));
                    }

                    if (eduNode.InnerHtml.Contains("{{schoolEndYear}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolEndYear}}", education.EndDate.ToString("yyyy"));
                    }
                    educationTemplate.Remove();
                }
            }
        }
    }
}