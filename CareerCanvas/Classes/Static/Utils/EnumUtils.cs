using System.ComponentModel;

namespace CareerCanvas.Classes.Static.Utils;

public static class EnumUtils
{
    public static string GetEnumDescription(Enum value)
    {
        var fi = value.GetType().GetField(value.ToString());

        DescriptionAttribute[] attributes =
            fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

        if (attributes != null && attributes.Any()) return attributes.First().Description;

        return value.ToString();
    }
}