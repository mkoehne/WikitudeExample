using System;
using Foundation;
using Wikitude.Architect;

namespace XamarinExample.iOS
{
	public class ExampleArchitectViewDelegate : WTArchitectViewDelegate
	{
		public override void InvokedURL(WTArchitectView architectView, NSUrl url)
		{
			Console.WriteLine("architect view invoked url: " + url);
		}

		public override void DidFinishLoadNavigation(WTArchitectView architectView, WTNavigation navigation)
		{
			Console.WriteLine("architect view loaded navigation: " + navigation.OriginalURL);
		}

		public override void DidFailToLoadNavigation(WTArchitectView architectView, WTNavigation navigation, NSError error)
		{
			Console.WriteLine("architect view failed to load navigation. " + error.LocalizedDescription);
		}
	}
}
