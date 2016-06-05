using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BrewersHelper
{
	public class DataSource
	{
		public DataSource ()
		{
			
		}

		public static void persist(List<Batch> batches)
		{
			//do something here
		}

		public static ObservableCollection<Batch> getBatches()
		{
			ObservableCollection<Batch> batches = new ObservableCollection<Batch> () {
				new Batch("Porter", false),
				new Batch("Lager", false),
				new Batch("Saisson", false),
				new Batch("Indian Pale Ale", false),
				new Batch("Stout", false),
				new Batch("Sour Ale", false),
				new Batch("Wheat Beer", false)
			};
			return batches;
		}
	}
}

