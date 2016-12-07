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
			{   "1_ClientRecognition_1_ImageOnTarget",
				"1_ClientRecognition_2_MultipleTargets",
				"1_ClientRecognition_3_ExtendedTracking",
				"1_ClientRecognition_4_Interactivity",
				"1_ClientRecognition_5_HtmlDrawable",
				"1_ClientRecognition_6_Bonus-Sparkles",
				"1_ClientRecognition_7_Bonus-DistanceToTarget",
				"2_CloudRecognition_1_BasicRecognitionOn-Click",
				"2_CloudRecognition_2_ContinuousRecognitionVsOn-Click",
				"2_CloudRecognition_3_UsingMetainformationInTheResponse",
				"3_3dModels_1_3dModelOnTarget",
				"3_3dModels_2_AppearingAnimation",
				"3_3dModels_3_Interactivity",
				"3_3dModels_4_SnapToScreen",
				"3_3dModels_5_AnimatedModelParts",
				"3_3dModels_6_3dModelAtGeoLocation",
				"4_PointOfInterest_1_PoiAtLocation",
				"4_PointOfInterest_2_PoiWithLabel",
				"4_PointOfInterest_3_MultiplePois",
				"4_PointOfInterest_4_SelectingPois",
				"5_ObtainPoiData_1_FromApplicationModel",
				"5_ObtainPoiData_2_FromLocalResource",
				"5_ObtainPoiData_3_FromWebservice",
				"6_BrowsingPois_1_PresentingDetails",
				"6_BrowsingPois_2_AddingRadar",
				"6_BrowsingPois_3_LimitingRange",
				"6_BrowsingPois_4_ReloadingContent",
				"6_BrowsingPois_5_NativeDetailScreen",
				"6_BrowsingPois_6_Bonus-CaptureScreen",
				"7_Video_1_SimpleVideo",
				"7_Video_2_PlaybackStates",
				"7_Video_3_SnappingVideo",
				"7_Video_4_Bonus-TransparentVideo",
				"8_HardwareControl_1_FrontCamera",
				"8_HardwareControl_2_CameraSwitching",
				"8_HardwareControl_3_AdvancedFeatures",
				"9_PluginsAPI_1_QR&Barcode",
				"9_PluginsAPI_2_FaceDetection",
				"9_PluginsAPI_3_CustomCamera",
				"9_PluginsAPI_4_MarkerTracking",
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

