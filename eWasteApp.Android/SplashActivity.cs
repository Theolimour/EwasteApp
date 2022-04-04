using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eWasteApp.Droid
{

    [Activity(Label = "ewasteApp", Icon = "@drawable/ewaste_logo", Theme = "@style/SplashTheme", MainLauncher = true,
           ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    class SplashActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(500);
            StartActivity(typeof(MainActivity));
            OverridePendingTransition(0, 0);
        }
    }
}