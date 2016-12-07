using Android.App;
using Android.OS;

namespace XamarinExample.Droid
{
	[Activity(Label = "ErrorActivity")]
	public class ErrorActivity : Activity
	{
		private const string TITLE = "Error";

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.activity_error);

			Title = TITLE;
		}
	}
}

