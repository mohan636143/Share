using Share.Views;
using Xamarin.Forms;

namespace Share
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            this.Resources =  new Themes.DefaultTheme().Resources;

            MainPage = new MapPage();
            if(Device.RuntimePlatform == Device.iOS)
            {
                MainPage.Padding = new Thickness(0, 20, 0, 0);
            }
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
