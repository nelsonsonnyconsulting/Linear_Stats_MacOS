using System;

using AppKit;
using Foundation;

namespace RosePlotMac
{
	public partial class ViewController : NSViewController
	{
		private int numberOfTimesClicked = 0;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
    }
}
