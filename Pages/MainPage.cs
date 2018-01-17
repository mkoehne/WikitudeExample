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
                "01_ImageTracking_1_ImageOnTarget",
                "01_ImageTracking_2_DifferentTargets",
                "01_ImageTracking_3_Interactivity",
                "01_ImageTracking_4_HtmlDrawable",
                "01_ImageTracking_5_Bonus-Sparkles",
                "02_AdvancedImageTracking_1_Gestures",
                "02_AdvancedImageTracking_2_DistanceToTarget",
                "02_AdvancedImageTracking_3_ExtendedTracking",
                "03_MultipleTargets_1_MultipleTargets",
                "03_MultipleTargets_2_DistanceBetweenTargets",
                "03_MultipleTargets_3_TransformationBetweenTargets",
                "04_CloudRecognition_1_SingleImageRecognition",
                "04_CloudRecognition_2_ContinuousImageRecognition",
                "04_CloudRecognition_3_UsingMetainformationInTheResponse",
                "05_InstantTracking_1_SimpleInstantTracking",
                "05_InstantTracking_2_3dModelOnPlane",
                "05_InstantTracking_3_Interactivity",
                "05_InstantTracking_4_SceneInteraction",
                "06_ObjectTracking_1_BasicObjectTracking",
                "06_ObjectTracking_2_2dImageAndSoundAugmentations",
                "06_ObjectTracking_3_Animated3dAugmentations",
                "07_3dModels_1_3dModelOnTarget",
                "07_3dModels_2_AppearingAnimation",
                "07_3dModels_3_Interactivity",
                "07_3dModels_4_SnapToScreen",
                "07_3dModels_5_AnimatedModelParts",
                "07_3dModels_6_3dModelAtGeoLocation",
                "08_PointOfInterest_1_PoiAtLocation",
                "08_PointOfInterest_2_PoiWithLabel",
                "08_PointOfInterest_3_MultiplePois",
                "08_PointOfInterest_4_SelectingPois",
                "09_ObtainPoiData_1_FromApplicationModel",
                "09_ObtainPoiData_2_FromLocalResource",
                "09_ObtainPoiData_3_FromWebservice",
                "10_BrowsingPois_1_PresentingDetails",
                "10_BrowsingPois_2_AddingRadar",
                "10_BrowsingPois_3_LimitingRange",
                "10_BrowsingPois_4_ReloadingContent",
                "10_BrowsingPois_5_NativeDetailScreen",
                "10_BrowsingPois_6_Bonus-CaptureScreen",
                "11_Video_1_SimpleVideo",
                "11_Video_2_PlaybackStates",
                "11_Video_3_SnappingVideo",
                "11_Video_4_Bonus-TransparentVideo",
                "12_HardwareControl_1_FrontCamera",
                "12_HardwareControl_2_CameraSwitching",
                "12_HardwareControl_3_AdvancedFeatures",
                "13_PluginsAPI_1_QR&Barcode",
                "13_PluginsAPI_2_FaceDetection",
                "13_PluginsAPI_3_SimpleInputPlugin",
                "13_PluginsAPI_4_CustomCamera",
                "13_PluginsAPI_5_MarkerTracking",
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

