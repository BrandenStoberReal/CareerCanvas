using ProtoBuf;

namespace CareerCanvas.Classes.Main
{
    [ProtoContract]
    public class ProfessionalIdentity
    {
        [ProtoMember(1)]
        public string? FirstName { get; set; } = String.Empty;

        [ProtoMember(2)]
        public string? MiddleName { get; set; } = String.Empty;

        [ProtoMember(3)]
        public string? LastName { get; set; } = String.Empty;

        [ProtoMember(4)]
        public string? Address { get; set; } = String.Empty;

        [ProtoMember(5)]
        public string? City { get; set; } = String.Empty;

        [ProtoMember(6)]
        public string? State { get; set; } = String.Empty;

        [ProtoMember(7)]
        public string? ZipCode { get; set; } = String.Empty;

        [ProtoMember(8)]
        public string? PhoneNumber { get; set; } = String.Empty;

        [ProtoMember(9)]
        public string? Email { get; set; } = String.Empty;

        [ProtoMember(10)]
        public string? LinkedIn { get; set; } = String.Empty;

        [ProtoMember(11)]
        public string? Portfolio { get; set; } = String.Empty;
    }
}