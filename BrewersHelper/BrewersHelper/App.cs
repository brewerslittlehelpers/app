using BrewersHelper.Implementations;
using BrewersHelper.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrewersHelper.Data;
using System.Diagnostics;

using Xamarin.Forms;

namespace BrewersHelper
{
    public class App : Application
    {
		static SampleDatabase database;

		public static SampleDatabase Database {
			get { 
				if (database == null) {
					database = new SampleDatabase();
				}
				return database;
			}
		}

        public App()
        {
//			Database = new SampleDatabase ();

            var buttonStyle = new Style(typeof(Button))
            {
                Setters =
                {
					new Setter { Property = View.HorizontalOptionsProperty, Value = LayoutOptions.Center },
					new Setter { Property = View.VerticalOptionsProperty, Value = LayoutOptions.CenterAndExpand },
					new Setter { Property = Button.BorderColorProperty, Value = Color.Gray },
					new Setter { Property = Button.BorderRadiusProperty, Value = 5 },
					new Setter { Property = Button.BorderWidthProperty, Value = 5 },
					new Setter { Property = VisualElement.WidthRequestProperty, Value = 150 },
					new Setter { Property = Button.TextColorProperty, Value = Color.White },
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.Teal },
                    new Setter { Property = Button.FontSizeProperty, Value = 14 },
                    new Setter { Property = Button.FontAttributesProperty, Value = FontAttributes.Bold }
                }
			};

            var labelStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter { Property = View.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new Setter { Property = View.VerticalOptionsProperty, Value = LayoutOptions.CenterAndExpand },
                    new Setter { Property = VisualElement.WidthRequestProperty, Value = 200 },
                    new Setter { Property = Label.TextColorProperty, Value = Color.White },
                    new Setter { Property = Label.BackgroundColorProperty, Value = Color.Teal },
                    new Setter { Property = Label.FontSizeProperty, Value = 14 },
                    new Setter { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold },
                    //new Setter { Property = Label.MarginProperty, Value = 10 }
                }
            };
					
            Resources = new ResourceDictionary ();
			Resources.Add ("Blue", Color.FromHex("#2d3e50"));

            var nav = new NavigationService();
            nav.Configure(Locator.Menu, typeof(Menu));
            nav.Configure(Locator.Overview, typeof(Overview));
            nav.Configure(Locator.History, typeof(History));
            nav.Configure(Locator.ManageDevices, typeof(ManageDevices));
            nav.Configure(Locator.Thresholds, typeof(Thresholds));
            nav.Configure(Locator.Compare, typeof(Compare));

            SimpleIoc.Default.Register<INavigationService>(()=>nav);

            var menu = new NavigationPage(new Menu());
            nav.Initialize(menu);
            MainPage = menu;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
