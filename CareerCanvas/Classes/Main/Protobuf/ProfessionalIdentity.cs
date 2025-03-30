using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf;

[ProtoContract]
public class ProfessionalIdentity
{
    [ProtoMember(1)] public string? FirstName { get; set; } = string.Empty;

    [ProtoMember(2)] public string? MiddleName { get; set; } = string.Empty;

    [ProtoMember(3)] public string? LastName { get; set; } = string.Empty;

    [ProtoMember(4)] public string? Address { get; set; } = string.Empty;

    [ProtoMember(5)] public string? City { get; set; } = string.Empty;

    [ProtoMember(6)] public string? State { get; set; } = string.Empty;

    [ProtoMember(7)] public string? ZipCode { get; set; } = string.Empty;

    [ProtoMember(8)] public string? PhoneNumber { get; set; } = string.Empty;

    [ProtoMember(9)] public string? Email { get; set; } = string.Empty;

    [ProtoMember(10)] public string? LinkedIn { get; set; } = string.Empty;

    [ProtoMember(11)] public string? Portfolio { get; set; } = string.Empty;
}