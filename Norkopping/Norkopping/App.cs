
using Xamarin.Forms;

namespace Norkopping
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage() {Title = "Norkopping"}) {BarBackgroundColor = Color.FromHex("#003263"), BarTextColor = Color.White};
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
