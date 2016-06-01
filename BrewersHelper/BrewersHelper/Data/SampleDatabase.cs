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
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			// create tables
			// database.CreateTable<SampleModel>():
		}
			

		public IEnumerable<SampleModel> GetSamples() 
		{
			return (from s in database.Table<SampleModel> ()
				select s).ToList ();
		}

		public SampleModel GetSampleTemp()
		{
		
		}


		public SampleModel GetSample(int id) 
		{
			return database.Table<SampleModel> ().FirstOrDefault (s => s.Id == id);
		}

		public void DeleteSample(int id) 
		{
			database.Delete<SampleModel> (id);
		}

		public void AddSample(double temp = 0.0, double alcohol = 0.0, double ph = 0.0, double gravity = 0.0) 
		{
			var newSample = new SampleModel {
				Temp = temp,
				Alcohol = alcohol,
				PH = ph,
				Gravity = gravity,
				Time = DateTime.Now
			};

			database.Insert (newSample);
		}

		public void AddDevice()
		{
			var newDevice = new DeviceModel { 
				Name = "Device 1"
			};
			database.Insert (newDevice);
		}
	}
}