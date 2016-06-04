using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;
using SQLite.Net;

namespace BrewersHelper
{
	[Table("batch")]
	public class BatchModel
	{
		[PrimaryKey, AutoIncrement, Column("Id")]
		public int Id { get; set; }

//		[OneToMany("O2MBatchKey", "SampleModelsInverse")]
		[TextBlob("SamplesBlobbed"), Column("samples")]
		public List<SampleModel> Samples { get; set; }

		public string SamplesBlobbed { get; set; }

		[ForeignKey(typeof(DeviceModel))]
		public int O2ODeviceKey { get; set; }

		[Column("name")]
		public string Name { get; set; }
		[Column("time")]
		public DateTime Time { get; set; }
		[Column("is_completed")]
		public bool IsCompleted { get; set; }
	}
}

