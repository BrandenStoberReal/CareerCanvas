using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Main.Bases
{
    public abstract class StaticMacro
    {
        protected string? MacroName { get; set; }
        protected string? MacroValue { get; set; }
        protected HtmlDocument? HtmlDocument { get; set; }
    }
}
