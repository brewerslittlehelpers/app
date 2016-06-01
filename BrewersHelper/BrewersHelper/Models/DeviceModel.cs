using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace BrewersHelper
{
	public class DeviceModel
	{
		public string Name { get; set; }

		[PrimaryKey, AutoIncrement]
		public int Id { get; }

		[OneToOne("O2ODeviceKey", "DeviceModelsInverse")]
		public BatchModel Batch { get; set; }
	}
}

