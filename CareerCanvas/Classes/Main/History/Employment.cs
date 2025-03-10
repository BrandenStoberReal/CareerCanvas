using ProtoBuf;

namespace CareerCanvas.Classes.Main.History
{
    [ProtoContract]
    public class Employment
    {
        [ProtoMember(1)]
        public DateTime StartDate { get; set; }

        [ProtoMember(2)]
        public DateTime EndDate { get; set; }

        [ProtoMember(3)]
        public string CompanyName { get; set; } = string.Empty;

        [ProtoMember(4)]
        public string JobTitle { get; set; } = string.Empty;

        [ProtoMember(5)]
        public string? JobDescription { get; set; }
    }
}