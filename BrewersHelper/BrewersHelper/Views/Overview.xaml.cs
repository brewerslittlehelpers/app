using BrewersHelper.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

using Xamarin.Forms;

namespace BrewersHelper.Views
{
    public partial class Overview : ContentPage
    {
        public Overview()
        {
            InitializeComponent();
            BindingContext = new OverviewViewModel(SimpleIoc.Default.GetInstance<INavigationService>());

			this.Appearing += Overview_Appearing;
        }

        void Overview_Appearing (object sender, EventArgs e)
        {
			// read data from model
			 AlcoholReadingLabel.Text = "35";

//			var db = new SampleDatabase ();
//			App.Database.GetSample(1);

//			SampleModel s = App.Database.GetSample(1);
//			AlcoholReadingLabel.Text = String.Format("{0}", s.Alcohol);

		}
    }
}
