using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using CommTracMobile.Helpers;
using Prism.Navigation;

namespace CommTracMobile.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Home Page";
            Settings.Current.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(Settings.UserName))
                    UserName = Settings.Current.UserName;
            };

        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            UserName = Settings.Current.UserName;
        }
    }
}
