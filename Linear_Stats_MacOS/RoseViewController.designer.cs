// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace RosePlotMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton FeaturesCheckbox { get; set; }

		[Outlet]
		AppKit.NSTextField FilenameTextField { get; set; }

		[Outlet]
		AppKit.NSButton FishnetCheckbox { get; set; }

		[Outlet]
		AppKit.NSTextField IntervalTextField { get; set; }

		[Outlet]
		AppKit.NSButton StatisticsCheckbox { get; set; }

		[Action ("OnFishnetCheckboxClicked:")]
		partial void OnFishnetCheckboxClicked (Foundation.NSObject sender);

		[Action ("OnSelectButtonClicked:")]
		partial void OnSelectButtonClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (FeaturesCheckbox != null) {
				FeaturesCheckbox.Dispose ();
				FeaturesCheckbox = null;
			}

			if (FilenameTextField != null) {
				FilenameTextField.Dispose ();
				FilenameTextField = null;
			}

			if (FishnetCheckbox != null) {
				FishnetCheckbox.Dispose ();
				FishnetCheckbox = null;
			}

			if (IntervalTextField != null) {
				IntervalTextField.Dispose ();
				IntervalTextField = null;
			}

			if (StatisticsCheckbox != null) {
				StatisticsCheckbox.Dispose ();
				StatisticsCheckbox = null;
			}
		}
	}
}
