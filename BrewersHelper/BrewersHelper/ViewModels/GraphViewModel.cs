using System;
using OxyPlot;
using System.Collections.Generic;

namespace BrewersHelper
{
	public class GraphViewModel
	{
		public GraphViewModel ()
		{
			this.Title = "A graph";
			this.Points = new List<DataPoint> {
				new DataPoint (0, 4),
				new DataPoint (10, 13)
			};
		}

		public string Title { get; private set; }

		public IList<DataPoint> Points { get; private set; }
	}
}

