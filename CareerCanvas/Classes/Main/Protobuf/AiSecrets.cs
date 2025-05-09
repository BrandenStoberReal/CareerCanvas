using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf
{
    [ProtoContract]
    public class AiSecrets
    {
        [ProtoMember(1)]
        public string OpenAiApiKey { get; set; } = string.Empty;
        [ProtoMember(2)]
        public string AnthropicApiKey { get; set; } = string.Empty;
        [ProtoMember(3)]
        public string GoogleApiKey { get; set; } = string.Empty;
    }
}
