using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.CurrentActivity;

namespace MyWasteGame.Android
{
    [Activity(Label = "MyWasteGame", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
	        CrossCurrentActivity.Current.Init(this, bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
			UserDialogs.Init(this);
			LoadApplication(new App());
        }
    }
}


