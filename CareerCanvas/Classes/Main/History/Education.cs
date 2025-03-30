using System.ComponentModel;
using ProtoBuf;

namespace CareerCanvas.Classes.Main.History;

[ProtoContract]
public enum DegreeType
{
    [ProtoEnum] [Description("High School Diploma")]
    HighSchool,

    [ProtoEnum] [Description("Associate's Degree")]
    Associate,

    [ProtoEnum] [Description("Bachelor's Degree")]
    Bachelor,

    [ProtoEnum] [Description("Master's Degree")]
    Master,

    [ProtoEnum] [Description("Doctorate Degree")]
    Doctorate
}

[ProtoContract]
public class Education
{
    [ProtoMember(1)] public DateTime StartDate { get; set; }

    [ProtoMember(2)] public DateTime EndDate { get; set; }

    [ProtoMember(3)] public string SchoolName { get; set; } = string.Empty;

    [ProtoMember(4)] public DegreeType Degree { get; set; }

    [ProtoMember(5)] public TimeSpan TotalTimeSpent { get; private set; }

    [ProtoMember(6)] public string City { get; set; } = string.Empty;

    [ProtoMember(7)] public string State { get; set; } = string.Empty;
}