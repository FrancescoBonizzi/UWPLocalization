using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ChangeLanguageStudyUWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (LocalizationHelper.IsCultureItalian(App.LocalizationHelper.GetCurrentLocalizationCode()))
                App.LocalizationHelper.ChangeLocalizationTo("en-US");
            else App.LocalizationHelper.ChangeLocalizationTo("it-IT");
        }
    }
}
