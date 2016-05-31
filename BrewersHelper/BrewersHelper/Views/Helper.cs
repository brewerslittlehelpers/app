using System;

namespace BrewersHelper
{
	public class Helper
	{
		public string HelperName{ get; set; }
		public int Percent;

		public Helper (string helperName, int percent)
		{
			HelperName = helperName;
			Percent = percent;
		}
	}
}

