using Android.App;
using Android.OS;
using Beers.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace Beers.Droid.Views
{
    [MvxActivityPresentation]
    [Activity]
    public class WelcomeView : MvxActivity<WelcomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.welcome_activity);
        }
    }
}