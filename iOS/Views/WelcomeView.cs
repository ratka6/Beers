using System;
using Beers.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace Beers.iOS.Views
{
    public partial class WelcomeView : MvxViewController<WelcomeViewModel>
    {
        public WelcomeView() : base("WelcomeView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupBindings();
        }

        private void SetupBindings()
        {
            var bindingSet = this.CreateBindingSet<WelcomeView, WelcomeViewModel>();

            bindingSet.Bind(TitleLabel).To(vm => vm.Title);
            bindingSet.Bind(DescriptionLabel).To(vm => vm.Description);
            bindingSet.Bind(GoButton).To(vm => vm.GoToBeersList);
            bindingSet.Bind(GoButton).For(v => v.BindTitle()).To(vm => vm.ButtonText);
            
            bindingSet.Apply();
        }
    }
}

