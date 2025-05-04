using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCanvas.Classes.Main.Bases;
using CareerCanvas.Classes.Static;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace CareerCanvas.Classes.Main.Macros
{
    /// <summary>
    /// StaticAbsoluteMacro is a class that represents a macro with a static absolute value. Macros defined in this class will be replaced and removed instead if such value is empty.
    /// </summary>
    public class StaticAbsoluteMacro : StaticMacro
    {
        [Obsolete("This field is obsolete. Smarter logic is built into the fill method by default.", true)]
        private string removeClassCode = "cc-remove-if-blank";

        /// <summary>
        /// Constructor for StaticAbsoluteMacro.
        /// </summary>
        /// <param name="parentdoc"></param>
        /// <param name="macroName"></param>
        /// <param name="macroValue"></param>
        public StaticAbsoluteMacro(ref HtmlDocument parentdoc, string macroName, string? macroValue)
        {
            MacroName = macroName;
            MacroValue = macroValue;
            HtmlDocument = parentdoc;
        }

        /// <summary>
        /// Overrides the ToString method to return the macro name and value.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MacroValue.Trim();
        }

        /// <summary>
        /// Fills the document with the macro value.
        /// </summary>
        public void Fill(bool destructive = true)
        {
            try
            {
                if (destructive)
                {
                    if (MacroValue == string.Empty || MacroValue == null)
                    {
                        // Remove empty elements
                        // TODO: Detect multiple macros & don't delete element if present
                        foreach (var node in HtmlDocument.DocumentNode.Descendants().Where(x => x.NodeType == HtmlNodeType.Text))
                        {
                            HtmlTextNode casted = (HtmlTextNode)node;
                            if (casted.Text.Contains("{{" + MacroName + "}}"))
                            {
                                node.ParentNode.Remove();
                                Globals.AppLogger.Warning($"{MacroName} macro located and removed due to lack of data.");
                            }
                        }
                    }
                }

                // Replace remaining elements
                HtmlDocument.DocumentNode.InnerHtml = HtmlDocument.DocumentNode.InnerHtml.Replace("{{" + MacroName + "}}", MacroValue.Trim());
            }
            catch (Exception ex)
            {
                Globals.AppLogger.Error("An error occurred while filling the document data. Macro: {0} Value: {1}", MacroName, MacroValue?.ToString());
                Globals.AppLogger.Error("Error Message: " + ex.Message);
                Globals.AppLogger.Error("Stack Trace: " + ex.StackTrace);
            }
        }
    }
}
