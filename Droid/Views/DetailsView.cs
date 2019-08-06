using Android.App;
using Android.OS;
using Beers.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace Beers.Droid.Views
{
    [MvxActivityPresentation]
    [Activity]
    public class DetailsView : MvxActivity<DetailsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.details_activity);
        }
    }
}