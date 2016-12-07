using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.App;

namespace XamarinExample.Droid
{
	[Activity(Label = "XamarinExample.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		private static readonly int REQUEST_CAMERA = 0;

		protected override void OnCreate(Bundle bundle)
		{
			if (Android.Support.V4.Content.ContextCompat.CheckSelfPermission(this, Android.Manifest.Permission.Camera) != (int)Permission.Granted)
			{
				ActivityCompat.RequestPermissions(this, new String[] { Android.Manifest.Permission.Camera }, REQUEST_CAMERA);
			}

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
		{
			if (requestCode == REQUEST_CAMERA)
			{
				if (grantResults.Length == 1 && grantResults[0] == Permission.Granted)
				{
					StartActivity(typeof(WikitudeActivity));
				}
				else {
					StartActivity(typeof(ErrorActivity));
				}
				Finish();
			}
		}
	}
}
