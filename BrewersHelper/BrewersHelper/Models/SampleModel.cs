using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace BrewersHelper
{
	public class SampleModel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[ForeignKey(typeof(BatchModel))]
		public int O2MBatchKey { get; set; }

		public DateTime Time { get; set; }
		public double Temp { get; set; }
		public double Alcohol { get; set; }
		public double Gravity { get; set; }
		public double PH { get; set; }

		override public string ToString()
		{
			return "Id: " + Id +"\n"+
				"BatchKey: " + O2MBatchKey +"\n"+
				"Time: " + Time +"\n"+
				"Alcohol: " + Alcohol +"\n"+
				"Temp: " + Temp +"\n"+
				"Gravity: " + Gravity +"\n"+
				"pH: " + PH ;
		}
	}
}

