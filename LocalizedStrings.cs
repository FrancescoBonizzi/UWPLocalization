using System.ComponentModel;
using Windows.ApplicationModel.Resources;

namespace ChangeLanguageStudyUWP
{
    public class LocalizedStrings
    {
        private readonly ResourceLoader _resources;
        
        public LocalizedStrings()
        {
            _resources = ResourceLoader.GetForViewIndependentUse();
        }

        public string this[string key]
        {
            get
            {
                return _resources.GetString(key);
            }
        }

    }
}
