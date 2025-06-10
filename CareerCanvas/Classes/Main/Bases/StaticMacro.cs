using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Main.Bases
{
    /// <summary>
    /// Core class for all static macro classes.
    /// </summary>
    public abstract class StaticMacro
    {
        /// <summary>
        /// Macro's name/title
        /// </summary>
        protected string? MacroName { get; set; }

        /// <summary>
        /// The value the macro name will be replaced with in the HTML document.
        /// </summary>
        protected string? MacroValue { get; set; }

        /// <summary>
        /// Gets or sets the HTML document associated with the current operation.
        /// </summary>
        protected HtmlDocument? HtmlDocument { get; set; }
    }
}