using CommTracMobile.Views;
using Xamarin.Forms;
using Prism.DryIoc;
using Prism.Logging;

namespace CommTracMobile
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();
        }

        public static new App Current => Application.Current as App;

        public new ILoggerFacade Logger
        {
            get { return base.Logger; }
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("Navigation/Login");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>("Navigation");
            Container.RegisterTypeForNavigation<MainPage>("Index");
            Container.RegisterTypeForNavigation<LoginPage>("Login");
            Container.RegisterTypeForNavigation<ProcessListPage>("ProcessList");
            Container.RegisterTypeForNavigation<FirstProcess>("FirstProcess");
            Container.RegisterTypeForNavigation<FirstProcessSecondPage>("FirstProcessSecond");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}