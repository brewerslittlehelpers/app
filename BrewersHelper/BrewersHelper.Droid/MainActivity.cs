using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using BrewersHelper.Android;

//[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]

namespace BrewersHelper.Droid
{
    [Activity(Label = "BrewersHelper", Icon = "@drawable/cup_image", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
			Xamarin.Forms.DependencyService.Register<SQLite_Android>();

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

