﻿using System;
using System.IO;
using Xamarin.Forms;
using BrewersHelper.Android;
using BrewersHelper.Data;

[assembly: Dependency(typeof(SQLite_Android))]

namespace BrewersHelper.Android
{
	public class SQLite_Android: ISQLite
	{
		public SQLite_Android ()
		{
		}

		#region ISQLite implementation

		public SQLite.Net.SQLiteConnection GetConnection ()
		{
			var fileName = "SampleDatabase.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath, fileName);

			var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid ();
			var connection = new SQLite.Net.SQLiteConnection (platform, path);

			return connection;
		}

		#endregion
	}
}