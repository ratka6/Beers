using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace Beers.Droid
{
    [Activity(MainLauncher = true, NoHistory = true, Theme = "@style/Launcher")]
    public class LauncherActivity : MvxSplashScreenActivity
    {
    }
}