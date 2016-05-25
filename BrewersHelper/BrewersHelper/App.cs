using BrewersHelper.Implementations;
using BrewersHelper.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BrewersHelper
{
    public class App : Application
    {
        public App()
        {
            var nav = new NavigationService();

            nav.Configure(Locator.Menu, typeof(Menu));
            nav.Configure(Locator.Overview, typeof(Overview));
            nav.Configure(Locator.History, typeof(History));
            nav.Configure(Locator.Readings, typeof(Readings));
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
