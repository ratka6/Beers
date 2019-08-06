// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Beers.iOS.Views
{
	[Register ("DetailsView")]
	partial class DetailsView
	{
		[Outlet]
		FFImageLoading.Cross.MvxCachedImageView ImageView { get; set; }

		[Outlet]
		UIKit.UILabel TipsLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (TipsLabel != null) {
				TipsLabel.Dispose ();
				TipsLabel = null;
			}
		}
	}
}
