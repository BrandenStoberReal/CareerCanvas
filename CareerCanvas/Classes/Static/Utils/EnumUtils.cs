using System.ComponentModel;

namespace CareerCanvas.Classes.Static.Utils;

public static class EnumUtils
{
    /// <summary>
    /// Gets the description of an enum value.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetEnumDescription(Enum value)
    {
        var fi = value.GetType().GetField(value.ToString());

        if (fi.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Any()) return attributes.First().Description;

        return value.ToString();
    }
}