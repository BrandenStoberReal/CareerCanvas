using LlmTornado.Code;
using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf
{
    [ProtoContract]
    public class AiSecrets
    {
        [ProtoMember(1)]
        public List<Tuple<LLmProviders, string>> ApiKeys { get; set; } = new List<Tuple<LLmProviders, string>>();
    }
}