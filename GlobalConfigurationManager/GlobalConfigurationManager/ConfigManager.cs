using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalConfigurationManager
{
    internal static class ConfigManager
    {
        public static string Theme { get; private set; } = "Light";
        public static string Language { get; private set; } = "English";
        public static int FontSize { get; private set; } = 10;

        public static void SetTheme(string theme)
        {
            Theme = theme;
        }

        public static void SetLanguage(string language)
        {
            Language = language;
        }

        public static void SetFontSize(int fontSize)
        {
            if (FontSize > 0)
            {
                FontSize = fontSize;
            }
            else
            {
                throw new ArgumentException("Font size must be greater than 0");
            }
        }
    }
}
