using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCanvas.Classes.Main.History;
using CareerCanvas.Classes.Main.Macros;
using CareerCanvas.Classes.Main.Misc;
using CareerCanvas.Classes.Main.Protobuf;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Static.Utils
{
    public static class CoverLetterUtils
    {

        /// <summary>
        /// Fills the document with the provided data.
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="identity"></param>
        /// <param name="cvInfo"></param>
        public static void FillDocumentData(HtmlDocument doc, ProfessionalIdentity identity, CoverLetterInfo cvInfo)
        {

            StaticAbsoluteMacro nameMacro = new StaticAbsoluteMacro(ref doc, MacroList.FullNameMacro, $"{identity.FirstName} {identity.LastName}");
            nameMacro.Fill();

            StaticAbsoluteMacro addressMacro = new StaticAbsoluteMacro(ref doc, MacroList.HomeAddressMacro, identity.Address);
            addressMacro.Fill();

            StaticAbsoluteMacro dateMacro = new StaticAbsoluteMacro(ref doc, MacroList.CurrentDateMacro, DateTime.Now.ToString("MMM dd, yyyy"));
            dateMacro.Fill();

            StaticAbsoluteMacro companyNameMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyNameMacro, cvInfo.CompanyName);
            companyNameMacro.Fill();

            StaticAbsoluteMacro jobTitleMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.AppliedJobTitleMacro, cvInfo.JobTitle);
            jobTitleMacro.Fill();

            StaticAbsoluteMacro companyAddressMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyAddressMacro, cvInfo.CompanyAddress);
            companyAddressMacro.Fill();

            StaticAbsoluteMacro companyCityMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyCityMacro, cvInfo.CompanyCity);
            companyCityMacro.Fill();

            StaticAbsoluteMacro companyStateMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyStateMacro, cvInfo.CompanyState);
            companyStateMacro.Fill();

            StaticAbsoluteMacro companyZipMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyZipMacro, cvInfo.CompanyZip);
            companyZipMacro.Fill();

            StaticAbsoluteMacro recipientFirstNameMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterRecipientFirstNameMacro, cvInfo.RecipientFirstName);
            recipientFirstNameMacro.Fill();

            StaticAbsoluteMacro recipientLastNameMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterRecipientLastNameMacro, cvInfo.RecipientLastName);
            recipientLastNameMacro.Fill();

            StaticAbsoluteMacro recipientPrefixMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterRecipientPrefixMacro, cvInfo.RecipientPrefix);
            recipientPrefixMacro.Fill();

            StaticAbsoluteMacro emailMacro = new StaticAbsoluteMacro(ref doc, MacroList.EmailAddressMacro, identity.Email);
            emailMacro.Fill();

            StaticAbsoluteMacro phoneMacro = new StaticAbsoluteMacro(ref doc, MacroList.PhoneNumberMacro, identity.PhoneNumber);
            phoneMacro.Fill();

            StaticAbsoluteMacro linkedInMacro = new StaticAbsoluteMacro(ref doc, MacroList.LinkedInMacro, identity.LinkedIn);
            linkedInMacro.Fill();

            StaticAbsoluteMacro recipientTitleMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterRecipientTitleMacro, cvInfo.RecipientTitle);
            recipientTitleMacro.Fill();

            StaticAbsoluteMacro companyPhoneMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyPhoneMacro, cvInfo.CompanyPhone);
            companyPhoneMacro.Fill();

            StaticAbsoluteMacro companyEmailMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyEmailMacro, cvInfo.CompanyEmail);
            companyEmailMacro.Fill();

            StaticAbsoluteMacro companyWebsiteMacro = new StaticAbsoluteMacro(ref doc, CoverLetterMacroList.CoverLetterCompanyWebsiteMacro, cvInfo.CompanyWebsite);
            companyWebsiteMacro.Fill();
        }
    }
}
