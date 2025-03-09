using CareerCanvas.Classes.Main.History;
using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf
{
    [ProtoContract]
    public class ProfessionalHistory
    {
        [ProtoMember(1)]
        public string Title { get; set; } = String.Empty;

        [ProtoMember(2)]
        public List<Employment> Jobs { get; set; } = new List<Employment>();

        [ProtoMember(3)]
        public List<Education> Schooling { get; set; } = new List<Education>();
    }
}