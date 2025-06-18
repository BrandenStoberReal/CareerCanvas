using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LlmTornado;
using LlmTornado.Code;
using ProtoBuf;

namespace CareerCanvas.Classes.Main.Protobuf
{
    [ProtoContract]
    public class Preferences
    {
        [ProtoMember(1)]
        public LLmProviders LlmProvider { get; set; } = LLmProviders.Unknown;
    }
}