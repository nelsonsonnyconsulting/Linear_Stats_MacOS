using AppKit;

namespace RosePlotMac
{
	static class MainClass
	{
		static void Main (string [] args)
		{
			System.Console.Out.WriteLine("Hello world!");
			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}
