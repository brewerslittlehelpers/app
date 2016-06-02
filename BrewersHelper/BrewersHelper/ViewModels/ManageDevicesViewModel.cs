using BrewersHelper.Implementations;
using BrewersHelper.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace BrewersHelper.ViewModels
{
	class ManageDevicesViewModel : ViewModelBase
	{

		public ObservableCollection<Helper> helperList{ get; private set; }
		private string addHelperLabel;
		private string newHelperName;

		public string AddHelperLabel {
			get { return addHelperLabel; }
			set { addHelperLabel = value; }
		}

		public string NewHelperName {
			get{ return newHelperName; }
			set { newHelperName = value;
				RaisePropertyChanged (() => NewHelperName);
			}
		}

		public ICommand DeleteHelperCommand{ get; private set; }
		public ICommand AddHelperCommand{ get; private set; }

		public ManageDevicesViewModel ()
		{
			//Static list of helpers until the database is up and running
			helperList = new ObservableCollection<Helper> ();
			Helper helper1 = new Helper("Helper 1: IPA", 0.3, "30%");
			Helper helper2 = new Helper ("Helper 2: Lager", 0.9, "90%");
			Helper helper3 = new Helper ("Helper 3: Blond Ale", 0.4, "40%");
			Helper helper4 = new Helper ("Helper 4: Brown Ale", 0.6, "60%");
			Helper helper5 = new Helper ("Helper 5: Golden Ale", 0.7, "70%");
			helperList.Add (helper1);
			helperList.Add (helper2);
			helperList.Add (helper3);
			helperList.Add (helper4);
			helperList.Add (helper5);
			AddHelperLabel = "Add new helper";
			NewHelperName = "";

			DeleteHelperCommand = new Command ((object sender) =>
				{
					var helper = (Helper)sender;
					Helper listHelper = (from h in helperList 
						where h == helper 
						select h).FirstOrDefault<Helper>();
					helperList.Remove(listHelper);

				});
			AddHelperCommand = new Command ((object sender) =>
				{
					if(!sender.ToString().Equals("")){
						helperList.Add(new Helper(sender.ToString(), 1.0, "100%"));
						NewHelperName="";
					}
				});
		}
	}
}