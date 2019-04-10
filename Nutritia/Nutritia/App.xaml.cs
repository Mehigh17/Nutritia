using Nutritia.Factories;
using Nutritia.Services;
using Nutritia.Views;
using Xamarin.Forms;

namespace Nutritia
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<RequestExecuter>();
            DependencyService.Register<ViewModelFactory>();

            MainPage = new MainPage();
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
