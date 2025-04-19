using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Protobuf;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Static.Utils
{
    public static class ResumeUtils
    {
        /// <summary>
        /// Placeholder skill names for filling in the resume template when no skills are provided.
        /// </summary>
        private static readonly List<string> FillerSkillNames = new()
        {
            "Teamwork",
            "Communication",
            "Problem Solving",
            "Leadership",
            "Time Management",
            "Adaptability",
            "Critical Thinking",
            "Creativity",
            "Interpersonal Skills",
            "Attention to Detail"
        };

        /// <summary>
        /// Fills the provided HTML document with identity data, including name, address, email, phone number,
        /// LinkedIn profile, job experience, and education details.
        /// </summary>
        /// <param name="doc">The HtmlDocument to be filled with identity data.</param>
        public static void FillDocumentData(HtmlDocument doc, ProfessionalIdentity identity, Industry industry)
        {
            // Replace placeholders with identity data
            doc.GetElementbyId("name").InnerHtml = doc.GetElementbyId("name").InnerHtml.Replace("{{fullName}}", $"{identity.FirstName} {identity.MiddleName} {identity.LastName}");
            Globals.AppLogger.Debug("Name macro successfully located and replaced with user's full name.");

            // Address fill
            if (identity.Address != String.Empty)
            {
                doc.GetElementbyId("address").InnerHtml = doc.GetElementbyId("address").InnerHtml.Replace("{{homeAddress}}", "Address: " + identity.Address);
                Globals.AppLogger.Debug("Address macro successfully located and replaced with user's home address.");
            }
            else
            {
                doc.GetElementbyId("address").Remove();
                Globals.AppLogger.Debug("Address field removed from resume template due to empty value.");
            }

            // Email fill
            if (identity.Email != String.Empty)
            {
                doc.GetElementbyId("email").InnerHtml = doc.GetElementbyId("email").InnerHtml.Replace("{{emailAddress}}", "Email: " + identity.Email);
                Globals.AppLogger.Debug("Email macro successfully located and replaced with user's email address.");
            }
            else
            {
                doc.GetElementbyId("email").Remove();
                Globals.AppLogger.Debug("Email field removed from resume template due to empty value.");
            }

            // Phone number fill
            if (identity.PhoneNumber != String.Empty)
            {
                doc.GetElementbyId("phonenumber").InnerHtml = doc.GetElementbyId("phonenumber").InnerHtml.Replace("{{phoneNumber}}", "Phone: " + identity.PhoneNumber);
                Globals.AppLogger.Debug("Phone number macro successfully located and replaced with user's phone number.");
            }
            else
            {
                doc.GetElementbyId("phonenumber").Remove();
                Globals.AppLogger.Debug("Phone number field removed from resume template due to empty value.");
            }

            // Linkedin fill
            if (identity.LinkedIn != String.Empty)
            {
                doc.GetElementbyId("linkedin").InnerHtml = doc.GetElementbyId("linkedin").InnerHtml.Replace("{{linkedIn}}", "LinkedIn: " + identity.LinkedIn);
                Globals.AppLogger.Debug("LinkedIn macro successfully located and replaced with user's LinkedIn profile.");
            }
            else
            {
                doc.GetElementbyId("linkedin").Remove();
                Globals.AppLogger.Debug("LinkedIn field removed from resume template due to empty value.");
            }

            // Summary fill
            if (industry.ProfessionalSummary != String.Empty)
            {
                doc.GetElementbyId("professionalsummary").InnerHtml = doc.GetElementbyId("professionalsummary").InnerHtml.Replace("{{resumeSummary}}", industry.ProfessionalSummary);
                Globals.AppLogger.Debug("Summary macro successfully located and replaced with user's professional summary.");
            }
            else
            {
                doc.GetElementbyId("professionalsummary").InnerHtml = doc.GetElementbyId("professionalsummary").InnerHtml.Replace("{{resumeSummary}}", "A summary of my professional experiences is available upon request.");
                Globals.AppLogger.Debug("Summary macro successfully located and replaced with default summary.");
            }

            // Skills fill
            HtmlNode skillTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("skillentry")).First();
            if (industry.Skills.Count == 0)
            {
                Globals.AppLogger.Warning("User did not provide any skills! A default set has been provided.");
                List<int> usedNumbers = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    Random rng = new Random();
                    HtmlNode skillNode = skillTemplate.Clone();
                    skillTemplate.ParentNode.AppendChild(skillNode);

                    // Skill name
                    if (skillNode.InnerHtml.Contains("{{skillName}}"))
                    {
                        int randomNumber = rng.Next(0, FillerSkillNames.Count);
                        while (usedNumbers.Contains(randomNumber))
                        {
                            randomNumber = rng.Next(0, FillerSkillNames.Count);
                        }
                        skillNode.InnerHtml = skillNode.InnerHtml.Replace("{{skillName}}", FillerSkillNames[randomNumber]);
                        usedNumbers.Add(randomNumber);
                    }
                }
            }
            else
            {
                Globals.AppLogger.Debug("Managing skill HTML to include user's skills...");
                foreach (ProfessionalSkill skill in industry.Skills)
                {
                    Globals.AppLogger.Debug("Processing skill \"{0}\"...", skill.SkillName);
                    HtmlNode skillNode = skillTemplate.Clone();
                    skillTemplate.ParentNode.AppendChild(skillNode);

                    // Skill name
                    if (skillNode.InnerHtml.Contains("{{skillName}}"))
                    {
                        skillNode.InnerHtml = skillNode.InnerHtml.Replace("{{skillName}}", skill.SkillName);
                        Globals.AppLogger.Debug("Skill \"{0}\" has been successfully added.", skill.SkillName);
                    }
                }
            }
            skillTemplate.Remove();
            Globals.AppLogger.Debug("Original skill template removed successfully.");

            // Job experience fill
            HtmlNode jobTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("jobentry")).First();
            if (industry.Jobs.Count == 0)
            {
                HtmlNode jobSection = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("experiencesection")).First();
                jobTemplate.Remove();
                jobSection.Remove();
                Globals.AppLogger.Warning("User did not provide any job information! This section has been removed from the template. Providing employment history for a resume is strongly advised.");
            }
            else
            {
                foreach (Employment job in industry.Jobs)
                {
                    Globals.AppLogger.Debug("Processing job {0}...", job.JobTitle);
                    HtmlNode jobNode = jobTemplate.Clone();
                    jobTemplate.ParentNode.AppendChild(jobNode);

                    // Job title
                    if (jobNode.InnerHtml.Contains("{{jobTitle}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobTitle}}", job.JobTitle);
                        Globals.AppLogger.Debug("JobTitle macro located and replaced with proper data.");
                    }

                    // Job company name
                    if (jobNode.InnerHtml.Contains("{{jobCompanyName}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobCompanyName}}", job.CompanyName);
                        Globals.AppLogger.Debug("JobCompanyName macro located and replaced with proper data.");
                    }

                    // Job starting month
                    if (jobNode.InnerHtml.Contains("{{jobStartMonth}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobStartMonth}}", job.StartDate.ToString("MMMM"));
                        Globals.AppLogger.Debug("JobStartMonth macro located and replaced with proper data.");
                    }

                    // Job ending month
                    if (jobNode.InnerHtml.Contains("{{jobEndMonth}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobEndMonth}}", job.EndDate.ToString("MMMM"));
                        Globals.AppLogger.Debug("JobEndMonth macro located and replaced with proper data.");
                    }

                    // Job starting year
                    if (jobNode.InnerHtml.Contains("{{jobStartYear}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobStartYear}}", job.StartDate.ToString("yyyy"));
                        Globals.AppLogger.Debug("JobStartYear macro located and replaced with proper data.");
                    }

                    // Job ending year
                    if (jobNode.InnerHtml.Contains("{{jobEndYear}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobEndYear}}", job.EndDate.ToString("yyyy"));
                        Globals.AppLogger.Debug("JobEndYear macro located and replaced with proper data.");
                    }

                    // Job starting date
                    if (jobNode.InnerHtml.Contains("{{jobStartDate}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobStartDate}}", job.StartDate.ToString("MMMM yyyy"));
                        Globals.AppLogger.Debug("jobStartDate macro located and replaced with proper data.");
                    }

                    // Job ending date
                    if (jobNode.InnerHtml.Contains("{{jobEndDate}}"))
                    {
                        jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobEndDate}}", job.EndDate.ToString("MMMM yyyy"));
                        Globals.AppLogger.Debug("jobEndDate macro located and replaced with proper data.");
                    }

                    // Job description
                    if (jobNode.InnerHtml.Contains("{{jobDescription}}"))
                    {
                        if (job.JobDescription != String.Empty)
                        {
                            jobNode.InnerHtml = jobNode.InnerHtml.Replace("{{jobDescription}}", job.JobDescription);
                            Globals.AppLogger.Debug("JobDescription macro located and replaced with proper data.");
                        }
                        else
                        {
                            Globals.AppLogger.Warning("Job \"{0}\" did not contain a job description! This section has been removed from the template. Providing a brief job description is strongly advised.");
                            jobNode.Descendants().Where(n => n.InnerText == "{{jobDescription}}").First().Remove();
                        }
                    }
                    jobTemplate.Remove();
                    Globals.AppLogger.Debug("Job field template removed successfully. This is intended behavior.");
                }
            }

            // Education fill
            HtmlNode educationTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("educationentry")).First();
            if (industry.Schooling.Count == 0)
            {
                HtmlNode educationSection = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("educationsection")).First();
                educationTemplate.Remove();
                educationSection.Remove();
                Globals.AppLogger.Warning("User did not provide any education history! This section has been removed from the template. Providing education history on a resume is strongly advised.");
            }
            else
            {
                foreach (Education education in industry.Schooling)
                {
                    Globals.AppLogger.Debug("Processing education \"{0}\"...", education.SchoolName);
                    HtmlNode eduNode = educationTemplate.Clone();
                    educationTemplate.ParentNode.AppendChild(eduNode);

                    // Degree type
                    if (eduNode.InnerHtml.Contains("{{degreeType}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{degreeType}}", EnumUtils.GetEnumDescription(education.Degree));
                        Globals.AppLogger.Debug("DegreeType macro located and replaced with proper data.");
                    }

                    // School name
                    if (eduNode.InnerHtml.Contains("{{schoolName}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolName}}", education.SchoolName);
                        Globals.AppLogger.Debug("SchoolName macro located and replaced with proper data.");
                    }

                    // Degree starting month
                    if (eduNode.InnerHtml.Contains("{{schoolStartMonth}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolStartMonth}}", education.StartDate.ToString("MMMM"));
                        Globals.AppLogger.Debug("SchoolStartMonth macro located and replaced with proper data.");
                    }

                    // Degree ending month
                    if (eduNode.InnerHtml.Contains("{{schoolEndMonth}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolEndMonth}}", education.EndDate.ToString("MMMM"));
                        Globals.AppLogger.Debug("SchoolEndMonth macro located and replaced with proper data.");
                    }

                    // Degree starting year
                    if (eduNode.InnerHtml.Contains("{{schoolStartYear}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolStartYear}}", education.StartDate.ToString("yyyy"));
                        Globals.AppLogger.Debug("SchoolStartYear macro located and replaced with proper data.");
                    }

                    // Degree ending year
                    if (eduNode.InnerHtml.Contains("{{schoolEndYear}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolEndYear}}", education.EndDate.ToString("yyyy"));
                        Globals.AppLogger.Debug("SchoolEndYear macro located and replaced with proper data.");
                    }

                    // Degree starting date
                    if (eduNode.InnerHtml.Contains("{{schoolStartDate}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolStartDate}}", education.StartDate.ToString("MMMM yyyy"));
                        Globals.AppLogger.Debug("SchoolStartDate macro located and replaced with proper data.");
                    }

                    // Degree ending date
                    if (eduNode.InnerHtml.Contains("{{schoolEndDate}}"))
                    {
                        eduNode.InnerHtml = eduNode.InnerHtml.Replace("{{schoolEndDate}}", education.EndDate.ToString("MMMM yyyy"));
                        Globals.AppLogger.Debug("SchoolEndDate macro located and replaced with proper data.");
                    }

                    educationTemplate.Remove();
                    Globals.AppLogger.Debug("Education field template removed successfully. This is intended behavior.");
                }
            }

            // Certificates fill
            HtmlNode certificatesTemplate = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("certificateentry")).First();
            if (industry.Certificates.Count == 0)
            {
                HtmlNode certificatesSection = doc.DocumentNode.Descendants(0).Where(n => n.HasClass("certificatesection")).First();
                certificatesTemplate.Remove();
                certificatesSection.Remove();
                Globals.AppLogger.Warning("User did not provide any certificates! This section has been removed from the template.");
            }
            else
            {
                foreach (CertificateProgram certificate in industry.Certificates)
                {
                    Globals.AppLogger.Debug("Processing certificate \"{0}\"...", certificate.Certificate.CertificateName);
                    HtmlNode certNode = certificatesTemplate.Clone();
                    certificatesTemplate.ParentNode.AppendChild(certNode);

                    // Certificate name
                    if (certNode.InnerHtml.Contains("{{certificateName}}"))
                    {
                        certNode.InnerHtml = certNode.InnerHtml.Replace("{{certificateName}}", certificate.Certificate.CertificateName);
                        Globals.AppLogger.Debug("CertificateName macro located and replaced with proper data.");
                    }

                    // Certificate issuer
                    if (certNode.InnerHtml.Contains("{{certificateIssuingOrganization}}"))
                    {
                        certNode.InnerHtml = certNode.InnerHtml.Replace("{{certificateIssuingOrganization}}", certificate.IssuingOrganization);
                        Globals.AppLogger.Debug("CertificateIssuingOrganization macro located and replaced with proper data.");
                    }

                    // Certificate issue month
                    if (certNode.InnerHtml.Contains("{{certificateMonth}}"))
                    {
                        certNode.InnerHtml = certNode.InnerHtml.Replace("{{certificateMonth}}", certificate.Certificate.IssueDate.ToString("MMMM"));
                        Globals.AppLogger.Debug("CertificateStartMonth macro located and replaced with proper data.");
                    }

                    // Certificate issue year
                    if (certNode.InnerHtml.Contains("{{certificateYear}}"))
                    {
                        certNode.InnerHtml = certNode.InnerHtml.Replace("{{certificateYear}}", certificate.Certificate.IssueDate.ToString("yyyy"));
                        Globals.AppLogger.Debug("CertificateStartYear macro located and replaced with proper data.");
                    }

                    // Certificate issue date
                    if (certNode.InnerHtml.Contains("{{certificateDate}}"))
                    {
                        certNode.InnerHtml = certNode.InnerHtml.Replace("{{certificateDate}}", certificate.Certificate.IssueDate.ToString("MMMM yyyy"));
                        Globals.AppLogger.Debug("CertificateDate macro located and replaced with proper data.");
                    }
                    certificatesTemplate.Remove();
                    Globals.AppLogger.Debug("Certificates field template removed successfully. This is intended behavior.");
                }
            }
        }
    }
}