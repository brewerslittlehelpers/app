using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace BrewersHelper
{
	public class DeviceModel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; }

		[OneToMany("O2MDeviceKey", "DeviceModelsInverse")]
		public List<BatchModel> Batches { get; set; }
	}
}

