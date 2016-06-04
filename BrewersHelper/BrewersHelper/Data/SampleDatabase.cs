using System;
using SQLite.Net;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Diagnostics;

namespace BrewersHelper.Data
{
	public class SampleDatabase
	{

//		public List<SampleModel> Samples { get; set; }
//		public List<BatchModel> Batches { get; set; }
//		public List<DeviceModel> Devices { get; set; }

		// hack
		private int batchnum = 0;

		SQLiteConnection database;

		public SampleDatabase ()
		{
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

		public BatchModel GetBatch(int id)
		{
			return database.Table<BatchModel> ().FirstOrDefault (b => b.Id == id);
		}
			
		public void CreateDatabase()
		{
			AddDevice ("First device");
			AddDevice ("Second device");

			AddBatch ("Tims Mighty Poof Porter", false, 1);
			AddBatch ("Haavards Holy Ale", false, 1);
			AddBatch ("CKs Beer", true, 2);

			// first batch
			AddSample (18.0, 0.0, 6.0, 1.052, "2016-05-15 06:00:00.000", 1);
			AddSample (18.1, 0.1, 6.0, 1.036, "2016-05-16 06:00:00.000", 1);
			AddSample (18.2, 0.4, 6.0, 1.032, "2016-05-17 06:00:00.000", 1);
			AddSample (17.7, 1.1, 5.8, 1.029, "2016-05-18 06:00:00.000", 1);
			AddSample (17.8, 1.2, 5.7, 1.025, "2016-05-19 06:00:00.000", 1);
			AddSample (17.5, 1.5, 5.6, 1.022, "2016-05-20 06:00:00.000", 1);
			AddSample (17.4, 2.1, 4.4, 1.019, "2016-05-21 06:00:00.000", 1);
			AddSample (17.3, 2.3, 4.3, 1.016, "2016-05-22 06:00:00.000", 1);
			AddSample (16.9, 3.1, 4.1, 1.014, "2016-05-23 06:00:00.000", 1);
			AddSample (16.8, 3.5, 4.0, 1.012, "2016-05-24 06:00:00.000", 1);
			AddSample (17.1, 4.0, 4.0, 1.011, "2016-05-25 06:00:00.000", 1);
			AddSample (17.1, 4.5, 4.0, 1.010, "2016-05-26 06:00:00.000", 1);
			AddSample (17.2, 5.0, 4.1, 1.010, "2016-05-27 06:00:00.000", 1);
			AddSample (17.1, 5.5, 4.1, 1.010, "2016-05-28 06:00:00.000", 1);

			// second batch
			AddSample (19.0, 0.0, 6.0, 1.052, "2016-05-15 06:00:00.000", 2);
			AddSample (19.3, 1.0, 6.0, 1.036, "2016-05-16 06:00:00.000", 2);
			AddSample (20.2, 1.4, 6.0, 1.032, "2016-05-17 06:00:00.000", 2);
			AddSample (20.7, 2.8, 6.0, 1.029, "2016-05-18 06:00:00.000", 2);
			AddSample (19.5, 5.2, 6.0, 1.025, "2016-05-19 06:00:00.000", 2);
			AddSample (19.4, 7.5, 6.0, 1.022, "2016-05-20 06:00:00.000", 2);

			AddSample (16.0, 0.0, 6.0, 1.052, "2016-05-15 06:00:00.000", 3);
			AddSample (16.1, 0.1, 6.0, 1.036, "2016-05-16 06:00:00.000", 3);
			AddSample (16.2, 0.4, 6.0, 1.032, "2016-05-17 06:00:00.000", 3);
			AddSample (16.6, 1.1, 5.8, 1.029, "2016-05-18 06:00:00.000", 3);
			AddSample (16.3, 1.2, 5.7, 1.025, "2016-05-19 06:00:00.000", 3);
			AddSample (15.5, 1.5, 5.6, 1.022, "2016-05-20 06:00:00.000", 3);
			AddSample (14.4, 2.1, 4.4, 1.019, "2016-05-21 06:00:00.000", 3);
			AddSample (15.3, 2.3, 4.3, 1.016, "2016-05-22 06:00:00.000", 3);
			AddSample (16.1, 3.1, 4.1, 1.014, "2016-05-23 06:00:00.000", 3);
			AddSample (16.5, 3.9, 4.0, 1.012, "2016-05-24 06:00:00.000", 3);
			AddSample (16.1, 4.4, 4.0, 1.011, "2016-05-25 06:00:00.000", 3);
			AddSample (16.5, 4.7, 4.0, 1.010, "2016-05-26 06:00:00.000", 3);
			AddSample (18.2, 5.1, 4.1, 1.010, "2016-05-27 06:00:00.000", 3);
			AddSample (18.1, 5.3, 4.4, 1.010, "2016-05-28 06:00:00.000", 3);
		}


//		public SampleModel GetSample(int id) 
//		{
//			return database.Table<SampleModel> ().FirstOrDefault (s => s.Id == id);
//		}
//
//		public BatchModel GetBatch(int id) 
//		{
//			return database.Table<BatchModel> ().FirstOrDefault (s => s.Id == id);
//		}
//
//		public void DeleteSample(int id) 
//		{
//			database.Delete<SampleModel> (id);
//		}
//

		public void ResetDatabase()
		{
			database.DeleteAll<BatchModel>();
			database.DeleteAll<SampleModel>();
			database.DeleteAll<DeviceModel>();
		}

		public void AddSample(double temp, double alcohol, double ph, double gravity, string time, int batchid) 
		{
			var newSample = new SampleModel() {
				Temp = temp,
				Alcohol = alcohol,
				PH = ph,
				Gravity = gravity,
				Time = Convert.ToDateTime(time),
				O2MBatchKey = batchid
			};

			database.Insert (newSample);
		}

		public int AddDevice(string name)
		{
			var newDevice = new DeviceModel() { 
				Name = name
			};
			return database.Insert (newDevice);
		}

		public void AddBatch(string name, bool completed, int device)
		{

			// TODO make sure data is not duplicated


			var newBatch = new BatchModel() { 
				Name = name,
				Time = DateTime.Now,
				IsCompleted = completed,
				Id = batchnum,
				O2ODeviceKey = device
			};

			Debug.WriteLine ("inserting batch {0}", newBatch.Id);

			database.Insert (newBatch);
			batchnum++;
		}
	}
}