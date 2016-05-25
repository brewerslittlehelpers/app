using System;
using SQLite.Net;

namespace BrewersHelper
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

