using Xamarin.Forms;

namespace XamarinExample
{
	public class ARPage : ContentPage
	{
		public string worldId;

		public ARPage(string worldId)
		{
			this.worldId = worldId;
			this.Title = worldId.Replace("_", " ");
		}
	}
}

