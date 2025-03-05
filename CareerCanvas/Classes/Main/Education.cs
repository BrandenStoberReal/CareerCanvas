using ProtoBuf;

namespace CareerCanvas.Classes.Main
{
    [ProtoContract]
    public enum DegreeType
    {
        [ProtoEnum]
        HighSchool,

        [ProtoEnum]
        Associate,

        [ProtoEnum]
        Bachelor,

        [ProtoEnum]
        Master,

        [ProtoEnum]
        Doctorate
    }

    [ProtoContract]
    public class Education
    {
        [ProtoMember(1)]
        public DateTime StartDate { get; set; }

        [ProtoMember(2)]
        public DateTime EndDate { get; set; }

        [ProtoMember(3)]
        public string SchoolName { get; set; } = String.Empty;

        [ProtoMember(4)]
        public DegreeType Degree { get; set; }

        [ProtoMember(5)]
        public TimeSpan TotalTimeSpent { get; private set; }

        public Education(DateTime startDate, DateTime endDate, string schoolName, DegreeType degree)
        {
            StartDate = startDate;
            EndDate = endDate;
            SchoolName = schoolName;
            Degree = degree;
            TotalTimeSpent = EndDate - StartDate;
        }
    }
}