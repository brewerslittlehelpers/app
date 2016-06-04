using BrewersHelper.Implementations;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BrewersHelper.ViewModels
{
    class HistoryViewModel : ViewModelBase
    {
        INavigationService _navigationservice;
        private string compareButtonLabel;

		private string test;
		private Batch batch = new Batch ("Porter", 1);
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

        public string CompareButtonLabel
        {
            get { return compareButtonLabel; }
            set { compareButtonLabel = value; }
        }

        public ICommand CompareButtonCommand { get; private set; }

        public HistoryViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            CompareButtonLabel = "Compare";
            CompareButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.Compare));

			this.Test = "Lauretta";





			helperList = new ObservableCollection<Helper> ();
			Helper helper1 = new Helper("Helper 1: IPA", 1, "2016-05-20 14:31:23.938");
			Helper helper2 = new Helper ("Helper 2: Lager", 2, "2016-05-20 14:31:23.938");
			Helper helper3 = new Helper ("Helper 3: Blond Ale", 3, "2016-05-20 14:31:23.938");
			Helper helper4 = new Helper ("Helper 4: Brown Ale", 4, "2016-05-20 14:31:23.938");
			Helper helper5 = new Helper ("Helper 5: Golden Ale", 5, "2016-05-20 14:31:23.938");
			helperList.Add (helper1);
			helperList.Add (helper2);
			helperList.Add (helper3);
			helperList.Add (helper4);
			helperList.Add (helper5);
			AddHelperLabel = "Add new helper";
			NewHelperName = "";

        }

		public string Test
		{
			get{
				return test;
			}

			set {
				test = value;
			}
		}




		public class Employee{
			public string DisplayName {get; set;}
		}

		ObservableCollection<Employee> employees = new ObservableCollection<Employee>();














		public class Batch {
			private string name;
			private int isComplete;

			public Batch(string name, int isComplete){
				this.name = name;
				this.isComplete = isComplete;
			}

			public string Name {
				get {
					return name;
				}
				set {
					name = value;
				}
			}

			public int IsComplete{
				get {
					return isComplete;
				}
				set {
					isComplete = value;
				}
			}

		}
    }
}
