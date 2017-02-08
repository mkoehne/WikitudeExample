using Xamarin.Forms;

namespace XamarinExample
{
	public class MainPage : ContentPage
	{
		public MainPage()
		{
			this.Title = "Samples";

			var listView = new ListView();

			listView.ItemsSource = new[]
			{
			   "01_ImageRecognition_1_ImageOnTarget",
				"01_ImageRecognition_2_MultipleTargets",
				"01_ImageRecognition_3_Interactivity",
				"01_ImageRecognition_4_HtmlDrawable",
				"01_ImageRecognition_5_Bonus-Sparkles",
				"02_AdvancedImageRecognition_1_Gestures",
				"02_AdvancedImageRecognition_2_DistanceToTarget",
				"02_AdvancedImageRecognition_3_ExtendedTracking",
				"03_CloudRecognition_1_SingleImageRecognition",
				"03_CloudRecognition_2_ContinuousImageRecognition",
				"03_CloudRecognition_3_UsingMetainformationInTheResponse",
				"04_InstantTracking_1_SimpleInstantTracking",
				"04_InstantTracking_2_3DModels",
				"04_InstantTracking_3_GesturesAnd3DModels",
				"05_3dModels_1_3dModelOnTarget",
				"05_3dModels_2_AppearingAnimation",
				"05_3dModels_3_Interactivity",
				"05_3dModels_4_SnapToScreen",
				"05_3dModels_5_AnimatedModelParts",
				"05_3dModels_6_3dModelAtGeoLocation",
				"06_PointOfInterest_1_PoiAtLocation",
				"06_PointOfInterest_2_PoiWithLabel",
				"06_PointOfInterest_3_MultiplePois",
				"06_PointOfInterest_4_SelectingPois",
				"07_ObtainPoiData_1_FromApplicationModel",
				"07_ObtainPoiData_2_FromLocalResource",
				"07_ObtainPoiData_3_FromWebservice",
				"08_BrowsingPois_1_PresentingDetails",
				"08_BrowsingPois_2_AddingRadar",
				"08_BrowsingPois_3_LimitingRange",
				"08_BrowsingPois_4_ReloadingContent",
				"08_BrowsingPois_5_NativeDetailScreen",
				"08_BrowsingPois_6_Bonus-CaptureScreen",
				"09_Video_1_SimpleVideo",
				"09_Video_2_PlaybackStates",
				"09_Video_3_SnappingVideo",
				"09_Video_4_Bonus-TransparentVideo",
				"10_HardwareControl_1_FrontCamera",
				"10_HardwareControl_2_CameraSwitching",
				"10_HardwareControl_3_AdvancedFeatures",
				"11_PluginsAPI_1_QR&Barcode",
				"11_PluginsAPI_2_FaceDetection",
				"11_PluginsAPI_3_CustomCamera",
				"11_PluginsAPI_4_MarkerTracking",
				"x_Demo_1_2dTrackingAndGeo",
				"x_Demo_2_SolarSystem(Geo)",
				"x_Demo_3_SolarSystem(2dTracking)"
			};

			// Using ItemTapped
			listView.ItemTapped += async (sender, e) =>
		   	{
				   ARPage arPage = new ARPage(e.Item.ToString());
				   await Navigation.PushAsync(arPage);
				   ((ListView)sender).SelectedItem = null;
			   };

			Padding = new Thickness(0, 0, 0, 0);
			Content = listView;
		}
	}
}

