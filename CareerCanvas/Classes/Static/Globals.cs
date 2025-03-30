using CareerCanvas.Classes.Configs;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Util;

namespace CareerCanvas.Classes.Static
{
    public static class Globals
    {
        public static MaterialColorScheme AppColorScheme { get; set; } = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.LIGHT);
        public static IdentityConfig IdentityConfig { get; set; } = new IdentityConfig();
        public static string IdentityConfigPath { get; set; } = "./data/misc/identity.careerconfig";
    }
}