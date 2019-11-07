using System;
using System.ComponentModel;
using System.Globalization;

namespace ChangeLanguageStudyUWP
{
    public class LocalizationHelper
    {
        public static bool IsCultureItalian(string cultureCode)
            => string.Equals(cultureCode, "it", StringComparison.InvariantCultureIgnoreCase)
            || string.Equals(cultureCode, "it-IT", StringComparison.InvariantCultureIgnoreCase);

        public string GetCurrentLocalizationCode()
        {
            var languageOverride = Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride;

            if (!string.IsNullOrWhiteSpace(languageOverride))
                return languageOverride;

            return CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        }

        public void ChangeLocalizationTo(string cultureCode)
        {
            Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = cultureCode;
        }
    }
}
