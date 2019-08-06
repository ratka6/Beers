using System;
using Android.App;
using Android.Runtime;
using Beers.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace Beers.Droid
{
    [Application]
    public class Application : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
        public Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            var setup = MvxAndroidSetupSingleton.EnsureSingletonAvailable(this);
            setup.EnsureInitialized();
        }
    }
}