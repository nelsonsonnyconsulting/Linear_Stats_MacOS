using System;
using AppKit;
using Foundation;

namespace RosePlotMac
{
	public partial class ViewController : NSViewController
	{
		// Internal model
		private String RosePlotFileLocation;
		private bool SaveFishnet;
		private bool SaveStatistics;
		private bool SelectedFeatures;

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
			// Save panel configuation
			NSSavePanel savePanel = new NSSavePanel();
			savePanel.Title = "Choose RosePlot File to Save...";

			// If OK is clicked, update the label
			if (savePanel.RunModal() == 1)
			{
				FilenameTextField.StringValue = savePanel.Url.Path;
			}
		}

        partial void OnFishnetCheckboxClicked(NSObject sender)
        {
			SaveFishnet = FishnetCheckbox.State == NSCellStateValue.On;
        }

        partial void OnStatisticsCheckboxClicked(NSObject sender)
        {
			SaveStatistics = StatisticsCheckbox.State == NSCellStateValue.On;
        }

        partial void OnFeaturesCheckboxClicked(NSObject sender)
        {
			SelectedFeatures = FeaturesCheckbox.State == NSCellStateValue.On;
        }
    }
}
