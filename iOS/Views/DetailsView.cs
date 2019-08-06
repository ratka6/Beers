using System;
using Beers.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;

namespace Beers.iOS.Views
{
    public partial class DetailsView : MvxViewController<DetailsViewModel>
    {
        public DetailsView() : base("DetailsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupBindings();
        }

        private void SetupBindings()
        {
            var bindingSet = this.CreateBindingSet<DetailsView, DetailsViewModel>();

            bindingSet.Bind(ImageView).For(v => v.ImagePath).To(vm => vm.ImageUri);
            bindingSet.Bind(TipsLabel).To(vm => vm.Tips);

            bindingSet.Apply();
        }
    }
}

