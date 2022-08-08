using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace trestleBridge.Extensions
{
    internal static class ExtensionMethods
    {
        public static string? GetDescription(this Enum value)
        {
            Type? type = value.GetType();
            string? name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo? field = type.GetField(name);
                if (field != null)
                {
                    if (Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) is DescriptionAttribute attr)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

        public static string? DisplayAsMenu<T>(this Enum value, string promptText)
        {
            var retVal = new StringBuilder();

            List<T> options = ((T[])Enum.GetValues(typeof(T)))
                                                    .Where(option => (int)(Enum.Parse(typeof(T), option.ToString())) != 0) //leave out the invalid option
                                                    .ToList();
            var counter = 1;
            foreach (T option in options)
            {
                var optionText = ((Enum)Enum.Parse(typeof(T), option?.ToString() ?? "")).GetDescription();
                retVal.AppendLine($"{counter}. {optionText}");
                counter++;
            }
            retVal.AppendLine();
            retVal.AppendLine(promptText);
            retVal.AppendLine("> ");

            return retVal.ToString();
        }
    }
}
