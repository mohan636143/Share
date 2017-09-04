using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
namespace Share.Droid
{
	[Activity(Label = "Share.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	//[Application]
	//[MetaData("com.google.android.maps.v2.API_KEY",Value = "AIzaSyDBtlny6R8SCpGkfj6NNqsnsn5eQwpmJ9U")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Xamarin.FormsGoogleMaps.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}
