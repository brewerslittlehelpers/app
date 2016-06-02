using System;
using SQLite.Net;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;


namespace BrewersHelper.Data
{
	public class SampleDatabase
	{

//		public List<SampleModel> Samples { get; set; }
//		public List<BatchModel> Batches { get; set; }
//		public List<DeviceModel> Devices { get; set; }

		SQLiteConnection database;

		public SampleDatabase ()
		{
			// hack

//			Samples = new List<SampleModel>();

			database = DependencyService.Get<ISQLite> ().GetConnection ();

//			// create tables

			database.CreateTable<SampleModel> ();
			database.CreateTable<DeviceModel> ();
			database.CreateTable<BatchModel> ();

			createDatabase ();

			// Devices

//			Devices.Add(new DeviceModel() {
//				Name = "My first device"
//			});
//
//			// Batches
//
//			Batches.Add(new BatchModel() { 
//				Name = "Tims Mighty Hop",
////				O2ODeviceKey = 1,
//				Time = DateTime.Now,
//				IsCompleted = false
//			});
//
//			Batches.Add(new BatchModel() { 
//				Name = "Haavards Ale",
////				O2ODeviceKey = 1,
//				Time = DateTime.Now,
//				IsCompleted = false
//			});
//
//			Batches.Add(new BatchModel() { 
//				Name = "CKs Disaster Porter",
////				O2ODeviceKey = 1,
//				Time = DateTime.Now,
//				IsCompleted = true
//			});

			// Samples

			// Batch 1
//			AddSample (18.0, 0.0, 6.0, 1.054, "2016-05-15 06:00:00.000", 1);

//			Samples.Add(new SampleModel () {
//				O2MBatchKey = 1,
//				Time = Convert.ToDateTime("2016-05-15 06:00:00.000"),
//				Temp = 18.0,
//				Alcohol = 0.0,
//				Gravity = 1.054,
//				PH = 6.0
//			});
//
//			Samples.Add(new SampleModel() {
//				O2MBatchKey = 1,
//				Time = Convert.ToDateTime("2016-05-16 06:00:00.000"),
//				Temp = 17.9,
//				Alcohol = 0.1,
//				Gravity = 1.053,
//				PH = 5.9
//			});

			// Batch 2

			// Batch 3

		}

		public IEnumerable<SampleModel> GetSamples() 
		{
			return (from s in database.Table<SampleModel> ()
				select s).ToList ();
		}
			
		private void createDatabase()
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

			AddSample (16.0, 0.0, 6.0, 1.052, "2016-05-15 06:00:00.000", 1);
			AddSample (16.1, 0.1, 6.0, 1.036, "2016-05-16 06:00:00.000", 1);
			AddSample (16.2, 0.4, 6.0, 1.032, "2016-05-17 06:00:00.000", 1);
			AddSample (16.6, 1.1, 5.8, 1.029, "2016-05-18 06:00:00.000", 1);
			AddSample (16.3, 1.2, 5.7, 1.025, "2016-05-19 06:00:00.000", 1);
			AddSample (15.5, 1.5, 5.6, 1.022, "2016-05-20 06:00:00.000", 1);
			AddSample (14.4, 2.1, 4.4, 1.019, "2016-05-21 06:00:00.000", 1);
			AddSample (15.3, 2.3, 4.3, 1.016, "2016-05-22 06:00:00.000", 1);
			AddSample (16.1, 3.1, 4.1, 1.014, "2016-05-23 06:00:00.000", 1);
			AddSample (16.5, 3.9, 4.0, 1.012, "2016-05-24 06:00:00.000", 1);
			AddSample (16.1, 4.4, 4.0, 1.011, "2016-05-25 06:00:00.000", 1);
			AddSample (16.5, 4.7, 4.0, 1.010, "2016-05-26 06:00:00.000", 1);
			AddSample (18.2, 5.1, 4.1, 1.010, "2016-05-27 06:00:00.000", 1);
			AddSample (18.1, 5.3, 4.4, 1.010, "2016-05-28 06:00:00.000", 1);
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
				O2ODeviceKey = device
			};
			database.Insert (newBatch);
		}
	}
}