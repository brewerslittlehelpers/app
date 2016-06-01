using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace BrewersHelper
{
	public class BatchModel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; }

		[OneToMany("O2MBatchKey", "SampleModelsInverse")]
		public List<SampleModel> Samples { get; set; }

		[ForeignKey(typeof(DeviceModel))]
		public int O2ODeviceKey { get; set; }

		public string Name { get; set; }
		public DateTime Time { get; set; }
		public bool IsCompleted { get; set; }
	}
}

