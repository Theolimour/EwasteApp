using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Acr.UserDialogs;

namespace eWasteApp.Droid
{
    [Activity(Label = "eWasteApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", 
        MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        bool ExitApp
        {
            set
            {
                if (value)
                {
                    base.OnBackPressed();
                }
            }
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            UserDialogs.Init(this);
            registerDependencies();
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void registerDependencies()
        {
            //Register native dependencie
            App.RegisterDependencies((builder) =>
            {
            });
        }
        async System.Threading.Tasks.Task DisplayExitAlert()
        {
            ExitApp = await App.Current.MainPage.DisplayAlert("Info", "Do you want to exit?", "Quit", "Cancel");
        }
    }
}