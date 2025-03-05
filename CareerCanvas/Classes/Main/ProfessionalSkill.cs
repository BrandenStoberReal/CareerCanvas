using ProtoBuf;

namespace CareerCanvas.Classes.Main
{
    [ProtoContract]
    public class ProfessionalSkill
    {
        [ProtoMember(1)]
        public string SkillName { get; set; } = String.Empty;

        [ProtoMember(2)]
        public int YearsExperience { get; set; }

        [ProtoMember(3)]
        public List<Employment> RelevantEmployment { get; set; } = new List<Employment>();

        [ProtoMember(4)]
        public List<Education> RelevantEducation { get; set; } = new List<Education>();
    }
}