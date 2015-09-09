
using System;

using Foundation;
using UIKit;
using CoreGraphics;

namespace ExampleProjectVCC
{
	public partial class LabelViewController : UIViewController
	{
		public LabelViewController () : base ()
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

			var label = new UILabel (new CGRect (30, 30, 100, 75));
			label.Text = "Howdy DFW Mobile .NET";
			View.AddSubview (label);

			/*
			// Navigation!
			var button = UIButton.FromType (UIButtonType.RoundedRect);
			button.Frame  = new CGRect (30, 115, 100, 35);
			button.SetTitle ("Next", UIControlState.Normal);
			button.TouchUpInside += (object sender, EventArgs e) => {
				ShowViewController (new EntryViewController (), null);
			};
			View.AddSubview (button);

			button.BackgroundColor = UIColor.LightGray;
			*/

			/*
			// Alerts!
			var alertButton = UIButton.FromType (UIButtonType.RoundedRect);
			alertButton.Frame  = new CGRect (30, 150, 100, 35);
			alertButton.SetTitle ("Alert", UIControlState.Normal);
			alertButton.TouchUpInside += (object sender, EventArgs e) => {
				var alertView = new UIAlertView ("Red Alert", "This is a red alert!", null, "Ok", null);

				alertView.Show();
			};
			View.AddSubview (alertButton);
			*/

			/*
			// Make a phone call!
			var phoneButton = UIButton.FromType (UIButtonType.RoundedRect);
			phoneButton.Frame  = new CGRect (30, 185, 100, 35);
			phoneButton.SetTitle ("Make Phone Call", UIControlState.Normal);
			phoneButton.TouchUpInside += (object sender, EventArgs e) => {
				UIApplication.SharedApplication.OpenUrl (new NSUrl("tel:" + "8178444444"));
			};
			View.AddSubview (phoneButton);
			*/

			/*
			// Image button
			var imageButton = UIButton.FromType (UIButtonType.Custom);
			imageButton.Frame  = new CGRect (30, 220, 45, 42);
			imageButton.SetImage (UIImage.FromFile ("star-gold45.png"), UIControlState.Normal);
			imageButton.SetImage (UIImage.FromFile ("star-grey45.png"), UIControlState.Disabled);
			imageButton.TouchUpInside += (object sender, EventArgs e) => {
				var alertView = new UIAlertView ("Image Button", "PRESSED!", null, "Ok", null);

				alertView.Show();
			};
			View.AddSubview (imageButton);
			*/



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

			//UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

			Console.WriteLine ("View Did APPEAR");
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			Console.WriteLine ("View Will DISAPPEAR");
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);

			Console.WriteLine ("View Did DISAPPEAR");
		}
	}
}

