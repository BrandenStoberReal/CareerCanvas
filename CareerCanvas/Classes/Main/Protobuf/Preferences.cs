using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LlmTornado;
using LlmTornado.Code;

namespace CareerCanvas.Classes.Main.Protobuf
{
    public class Preferences
    {
        public LLmProviders LlmProvider { get; set; } = LLmProviders.Unknown;
    }
}