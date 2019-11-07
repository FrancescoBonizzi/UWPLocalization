﻿using System.Threading.Tasks;
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

        private async void btnChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (LocalizationHelper.IsCultureItalian(App.LocalizationHelper.GetCurrentLocalizationCode()))
                App.LocalizationHelper.ChangeLocalizationTo("en-US");
            else App.LocalizationHelper.ChangeLocalizationTo("it-IT");

            await Task.Delay(100); // used to prepare the resource.
            DataContext = new LocalizedStrings();
        }
    }
}
