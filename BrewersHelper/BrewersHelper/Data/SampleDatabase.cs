using System;
//using SQLite;
using SQLite.Net;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;


namespace BrewersHelper
{
	public class SampleDatabase
	{
		
		SQLiteConnection database;

		public SampleDatabase ()
		{
//			createDatabase ();

			database = DependencyService.Get<ISQLite> ().GetConnection ();
			// create tables
			database.CreateTable<SampleModel> ();
			database.CreateTable<DeviceModel> ();
			database.CreateTable<BatchModel> ();

		}
			

		public IEnumerable<SampleModel> GetSamples() 
		{
			return (from s in database.Table<SampleModel> ()
				select s).ToList ();
		}

		public SampleModel GetSample(int id) 
		{
			return database.Table<SampleModel> ().FirstOrDefault (s => s.Id == id);
		}

		public void DeleteSample(int id) 
		{
			database.Delete<SampleModel> (id);
		}

		public void AddSample(double temp, double alcohol, double ph, double gravity, string time, int batchid) 
		{
			var newSample = new SampleModel {
				Temp = temp,
				Alcohol = alcohol,
				PH = ph,
				Gravity = gravity,
				Time = time,
				O2MBatchKey = batchid
			};

			database.Insert (newSample);
		}

		public int AddDevice(string name)
		{
			var newDevice = new DeviceModel { 
				Name = name
			};
			return database.Insert (newDevice);
		}

		public void AddBatch(string name, bool completed, int device)
		{
			var newBatch = new BatchModel { 
				Name = name,
				Time = DateTime.Now,
				IsCompleted = completed,
				O2ODeviceKey = device
			};
			database.Insert (newBatch);
		}
	}
}