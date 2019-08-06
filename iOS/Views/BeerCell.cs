using System;
using Beers.Core.ViewModels;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace Beers.iOS.Views
{
    public partial class BeerCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("BeerCell");
        public static readonly UINib Nib;

        static BeerCell()
        {
            Nib = UINib.FromName("BeerCell", NSBundle.MainBundle);
        }

        protected BeerCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(SetupBindings);
        }

        private void SetupBindings()
        {
            var bindingSet = this.CreateBindingSet<BeerCell, BeerItem>();

            bindingSet.Bind(TitleLabel).To(vm => vm.Name);
            bindingSet.Bind(SubtitleLabel).To(vm => vm.Tagline);

            bindingSet.Apply();
        }
    }
}
