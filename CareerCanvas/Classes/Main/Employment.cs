using ProtoBuf;

namespace CareerCanvas.Classes.Main
{
    [ProtoContract]
    public class Employment
    {
        [ProtoMember(1)]
        public DateTime StartDate { get; set; }

        [ProtoMember(2)]
        public DateTime EndDate { get; set; }

        [ProtoMember(3)]
        public string CompanyName { get; set; } = String.Empty;

        [ProtoMember(4)]
        public string JobTitle { get; set; } = String.Empty;

        [ProtoMember(5)]
        public string? JobDescription { get; set; }

        public Employment(DateTime startDate, DateTime endDate, string companyName, string jobTitle, string? jobDescription = null)
        {
            StartDate = startDate;
            EndDate = endDate;
            CompanyName = companyName;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
        }
    }
}