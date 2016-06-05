using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace BrewersHelper
{
	public class Batch : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;

		private string _name;
		private bool _isOn;
		public string name { get{ return _name;} set{ OnPropertyChanged (); _name = value;} }
		public bool isOn { get{ return _isOn;} set{OnPropertyChanged (); OnPropertyChanged ("isNotOn"); _isOn = value;} }
		public bool isNotOn{ get { return !_isOn; } }

		public Batch ()
		{
			this.name = "First Batch";
			this.isOn = false;
		}

		public Batch (string name, bool isOn)
		{
			this.name = name;
			this.isOn = isOn;
		}

		void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

