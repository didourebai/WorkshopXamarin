
using Xamarin.Forms;

namespace Sample3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            TabbedPage tb = new TabbedPage();
            tb.Children.Add(new MainPage());
            tb.Children.Add(new Page1());
            tb.Children.Add(new Page2());
            MainPage = tb;

            //MainPage = new NavigationPage( new Sample3.MainPage());
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
