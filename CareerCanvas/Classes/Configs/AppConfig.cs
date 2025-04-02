using ReaLTaiizor.Colors;
using ReaLTaiizor.Util;

namespace CareerCanvas.Classes.Configs;

public class AppConfig
{
    /// <summary>
    /// The application color scheme. Applies to all forms.
    /// </summary>
    public MaterialColorScheme ColorScheme { get; set; } = new(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700,
        MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);
}