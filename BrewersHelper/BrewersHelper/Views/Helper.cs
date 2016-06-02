using System;
using System.Windows.Input;

namespace BrewersHelper
{
	public class Helper
	{
		public string HelperName{ get; set; }
		public double Progress{ get; set; }
		public string BatteryPercent{ get; set; }

		public Helper (string helperName, double progress, string batteryPercent)
		{
			HelperName = helperName;
			Progress = progress;
			BatteryPercent = batteryPercent;
		}
	}
}

