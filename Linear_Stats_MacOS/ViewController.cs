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

        partial void OnSelectButtonClicked(NSObject sender)
        {
			NSSavePanel savePanel = new NSSavePanel();
			savePanel.Title = "Choose RosePlot File to Save...";
			savePanel.RunModal();
			FilenameTextField.StringValue = savePanel.Url.ToString();
			// Checking if a checkbox is checked
			// StatisticsCheckbox.State == NSCellStateValue.On;
		}
    }
}
