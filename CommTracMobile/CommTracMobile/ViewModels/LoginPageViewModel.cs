using CommTracMobile.Helpers;
using Prism.Commands;
using Prism.Navigation;

namespace CommTracMobile.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Login";

            LoginCommand = new DelegateCommand(OnLoginCommandExecuted, LoginCommandCanExecute).ObservesProperty(() => UserName).ObservesProperty(() => Password);
       }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public DelegateCommand LoginCommand { get; }

        private async void OnLoginCommandExecuted()
        {
            IsBusy = true;
            Settings.Current.UserName = UserName;
            await _navigationService.NavigateAsync("/Index/Navigation/ProcessList?message=Glad%20you%20read%20the%20code");
            IsBusy = false;
        }

        private bool LoginCommandCanExecute() =>
            !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password) && IsNotBusy;
    }
}
