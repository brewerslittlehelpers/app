using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace BrewersHelper
{
	public class Database
	{
		private SQLiteConnection _connection;

		public Database ()
		{
			_connection = DependencyService.Get<ISQLite> ().GetConnection ();
			_connection.CreateTable<SampleModel> ();
		}

		public IEnumerable<SampleModel> GetSamples() 
		{
			return (from s in _connection.Table<SampleModel> ()
				select s).ToList ();
		}

		public SampleModel GetSample(int id) 
		{
			return _connection.Table<SampleModel> ().FirstOrDefault (s => s.Id == id);
		}

		public void DeleteSample(int id) 
		{
			_connection.Delete<SampleModel> (id);
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

			_connection.Insert (newSample);
		}
	}
}