using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Main.Bases
{
    public abstract class StaticMacro
    {
        protected string MacroName { get; set; }
        protected string? MacroValue { get; set; }
        protected HtmlDocument HtmlDocument { get; set; }
        public override string ToString()
        {
            return $"{MacroName}: {MacroValue}";
        }
    }
}
