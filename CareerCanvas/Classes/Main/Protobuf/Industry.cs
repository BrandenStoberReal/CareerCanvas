using CareerCanvas.Classes.Main.History;
using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf;

[ProtoContract]
public class Industry
{
    [ProtoMember(1)] public List<Employment> Jobs { get; set; } = new();

    [ProtoMember(2)] public List<Education> Schooling { get; set; } = new();

    [ProtoMember(3)] public List<CertificateProgram> Certificates { get; set; } = new();

    [ProtoMember(4)] public string Description { get; set; } = string.Empty;
    [ProtoMember(5)] public string ProfessionalSummary { get; set; } = string.Empty;

    [ProtoMember(6)] public List<ProfessionalSkill> Skills { get; set; } = new();
}