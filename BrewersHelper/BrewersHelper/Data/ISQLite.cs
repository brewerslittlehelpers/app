using System;
using SQLite.Net;

namespace BrewersHelper.Data
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}
