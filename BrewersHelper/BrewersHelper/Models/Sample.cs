using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace BrewersHelper
{
	[Table ("sample")]
	public class Sample
	{
		[PrimaryKey, AutoIncrement, Column("id")]
		public int ID { get; set; }

		[Unique, Column("time")]
		public string Time { get; set; }
		[Column("temp")]
		public double Temp { get; set; }
		[Column("alcohol")]
		public double Alcohol { get; set; }
		[Column("gravity")]
		public double Gravity { get; set; }
		[Column("ph")]
		public double PH { get; set; }

		[Column("batch_id")]
		public int BatchID { get; set; }
	}
}

