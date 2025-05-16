using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf;

[ProtoContract]
public class ProfessionalSkill
{
    [ProtoMember(1)] public string SkillName { get; set; } = string.Empty;

    [ProtoMember(2)] public int YearsExperience { get; set; }

    // [ProtoMember(3)] public List<Employment> RelevantEmployment { get; set; } = new();

    // [ProtoMember(4)] public List<Education> RelevantEducation { get; set; } = new();

    // [ProtoMember(5)] public List<CertificateProgram> RelevantCertificates { get; set; } = new();
}