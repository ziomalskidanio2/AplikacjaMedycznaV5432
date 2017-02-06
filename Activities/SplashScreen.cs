using System.Threading;

using Android.App;
using Android.OS;

namespace NavDrawer.Activities
{
    [Activity(Label = "Nazwa aplikacji", MainLauncher=true, Theme = "@style/Theme.Splash", NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Thread.Sleep(4000);
            //Start Activity1 Activity
            StartActivity(typeof(HomeView));
            // Create your application here
        }
    }
}