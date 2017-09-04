
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Share.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            //Xamarin.FormsMaps.Init();
            Xamarin.FormsGoogleMaps.Init("AIzaSyDBtlny6R8SCpGkfj6NNqsnsn5eQwpmJ9U");
			var statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
			if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
			{
                object statusBarColor;
                new Themes.DefaultTheme().Resources.TryGetValue("StatusBarColor",out statusBarColor);
                statusBar.BackgroundColor = ((Xamarin.Forms.Color)statusBarColor).ToUIColor();
			}

            LoadApplication(new App());

            var mainWindow = UIApplication.SharedApplication.ValueForKey(new NSString("keyWindow"));

            return base.FinishedLaunching(app, options);


        }
    }
}
