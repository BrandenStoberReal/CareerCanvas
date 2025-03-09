using ProtoBuf;

namespace CareerCanvas.Classes.Main.History
{
    [ProtoContract]
    public class Certificate
    {
        [ProtoMember(1)]
        public string CertificateName { get; set; } = string.Empty;

        [ProtoMember(2)]
        public string IssuingOrganization { get; set; } = string.Empty;

        [ProtoMember(3)]
        public DateTime IssueDate { get; set; }

        public Certificate(CertificateProgram parent, string certificateName, DateTime issueDate)
        {
            CertificateName = certificateName;
            IssuingOrganization = parent.IssuingOrganization;
            IssueDate = issueDate;

            parent.Certificate = this;
        }
    }
}