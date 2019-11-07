using System.ComponentModel;
using Windows.ApplicationModel.Resources;

namespace ChangeLanguageStudyUWP
{
    public class LocalizedStrings : INotifyPropertyChanged
    {
        private readonly ResourceLoader _resources;
        private readonly LocalizationHelper _localizationHelper;

        public event PropertyChangedEventHandler PropertyChanged;

        public LocalizedStrings()
        {
            _resources = ResourceLoader.GetForViewIndependentUse();
            _localizationHelper = App.LocalizationHelper;
            _localizationHelper.OnLocalizationChange += _localizationHelper_OnLocalizationChange;
        }

        public string this[string key]
        {
            get
            {
                return _resources.GetString(key);
            }
        }

        private void _localizationHelper_OnLocalizationChange(object sender, System.EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }
    }
}
