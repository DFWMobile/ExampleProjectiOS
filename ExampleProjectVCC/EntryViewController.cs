using System;
using UIKit;
using CoreGraphics;
using Foundation;

namespace ExampleProjectVCC
{
	public class EntryViewController : UIViewController
	{
		public EntryViewController () : base ()
		{
			EdgesForExtendedLayout = UIRectEdge.None;
			View.BackgroundColor = UIColor.White;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var entry = new UITextField (new CGRect (30, 30, 250, 35));


			entry.BackgroundColor = UIColor.LightGray;


			entry.AttributedPlaceholder = new NSAttributedString (
				"Enter Location",
				foregroundColor: UIColor.DarkGray);
			

			entry.ShouldReturn += (textField) => {
				//textField.ResignFirstResponder();
				return true;
			};
			View.AddSubview (entry);

			Console.WriteLine ("View Did LOAD");
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			Console.WriteLine ("View Will APPEAR");
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;

			Console.WriteLine ("View Did APPEAR");
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			Console.WriteLine ("View Will DISAPPEAR");
		}

		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();

			Console.WriteLine ("View Will UNLOAD");
		}
	}
}

