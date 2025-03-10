using CareerCanvas.Classes.Main.History;
using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf
{
    [ProtoContract]
    public class Industry
    {
        [ProtoMember(1)]
        public List<Employment> Jobs { get; set; } = new List<Employment>();

        [ProtoMember(2)]
        public List<Education> Schooling { get; set; } = new List<Education>();

        [ProtoMember(3)]
        public List<CertificateProgram> Certificates { get; set; } = new List<CertificateProgram>();

        [ProtoMember(4)]
        public string Description { get; set; } = string.Empty;
    }
}