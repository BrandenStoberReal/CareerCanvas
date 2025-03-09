using ProtoBuf;

namespace CareerCanvas.Classes.Main.History
{
    [ProtoContract]
    public class CertificateProgram
    {
        [ProtoMember(1)]
        public string ProgramName { get; set; } = string.Empty;

        [ProtoMember(2)]
        public string IssuingOrganization { get; set; } = string.Empty;

        [ProtoMember(3)]
        public DateTime StartDate { get; set; }

        [ProtoMember(4)]
        public DateTime EndDate { get; set; }

        [ProtoMember(5)]
        public TimeSpan TotalTimeSpent { get; private set; }

        [ProtoMember(6)]
        public Certificate Certificate { get; set; }

        public CertificateProgram(string programName, string issuingOrganization, DateTime startDate, DateTime endDate)
        {
            ProgramName = programName;
            IssuingOrganization = issuingOrganization;
            StartDate = startDate;
            EndDate = endDate;
            TotalTimeSpent = EndDate - StartDate;
        }
    }
}