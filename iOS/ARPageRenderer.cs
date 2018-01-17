using System;
using Foundation;
using UIKit;
using Wikitude.Architect;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(XamarinExample.ARPage), typeof(XamarinExample.iOS.ARPageRenderer))]
namespace XamarinExample.iOS
{
    public class ARPageRenderer : PageRenderer
    {
        string worldId;
        WTArchitectView architectView;
        WTNavigation navigation;
        ExampleArchitectViewDelegate architectViewDelegate = new ExampleArchitectViewDelegate();

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            var page = e.NewElement as ARPage;
            worldId = page.worldId;
            this.Title = worldId;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.architectView = new WTArchitectView();
            this.architectView.Delegate = architectViewDelegate;
            this.View.AddSubview(this.architectView);
            this.architectView.TranslatesAutoresizingMaskIntoConstraints = false;

            NSDictionary views = new NSDictionary(new NSString("architectView"), architectView);
            this.View.AddConstraints(NSLayoutConstraint.FromVisualFormat("|[architectView]|", 0, null, views));
            this.View.AddConstraints(NSLayoutConstraint.FromVisualFormat("V:|[architectView]|", 0, null, views));

            architectView.SetLicenseKey("NGBXvYi66YY4pT3CqeLvcv31N9xl4uasQSZwF5xPfJ5lcrI5leTkRrzzVihYTbEbRWRf9S9hWqkeCykxd1IgU/qbg5WJjwSK7dk9f/zHwlV1Qa/JYIB6l+sh2OjrdrXO7E9Qdqih1RYGF+3MDt7CC3BmMUrhkFanOvCf/eXMmX1TYWx0ZWRfX6PikQ4qQBjn7mRR7l4e36y3jrIqcuQfE4vdeKCDiD2pePwQ41U/FnA7HSShjqq9TcTpQaASuWQL+nnrKUU3ybpck+50zKokc0nK6tX0rjqAE3cKZJIXMV1VRszX2rUJFFzM80eMWNQ2FN6I3e0LlyY3gkAt05XUiTq4YaOVb62gRlytIPNvaxwFoj3Xvh5+vR4afdbKAgdAlxT4KLazRObTUBuYHWeKU9/cXR4RagzSDUt+mpYzEVpZTB8OjGFWKf+j+5kCRrQ/ra4gYIuf3KqYFy0JsuAeN2keaI5M34saqcTNSUV7Ng1V/ZjJg9Ac56TLC+D1FuMDdpZ6c3eWTsaccwc4tMmnyiA8Y60GqXIeFOClE1locWR0Fu/MXmOkoFSXGy/ldfzVOo756Mhb4xCSTvbN+PUKbyM9EYWrmj3Yu88wxglud9L+G8etmi+Mr1wO4SGCfIQdzu1Pt9go8QhZpIB7Nyk1IirWW99b10Kzh8rW1fj8ReVBddHb4SU5+r2/CmAUMrbohodJFBefpbagBhQ7EV8sg/1ylBYaNVXUi3bfCt437rcwNniWV6/Pm4thryejMMflAji9gp+TgioY4r1ex6LDzzzRrHGZ+Qypwrm41oxWpz5Gw4hbkeakbqhVT7AgTq2bvQ++Gkksaw5RO54rIzuh2QOu1Ad+XY81VHLYMnudcLzWuY3WcrQEqgQ/jRIGOH4ZywKTOqtXozF4Us85z5CWHfdESc2foe68ZbOem/pn7a9Hk+foWy9oFp8/0lEKjoVCZp264eeU7EsdQoHNnPDq8w3UZSfVGd3sOytAIQAkeFER/5GNQBXM+gsoCU3cd5Wrfvj9LHrC223CqdDENpyVc2uHc+RfyOAhXMZxtw0+Hi2etkJXkC+6y4ncxwKt8wlThhBtpDfgE0wB6wZ0sHLE+fmK7LOSUipj8qc7s6sD01la+xHL7yrcpWDJIJ46cgiycaVb7AWSW5c8wXpKK+i/JgI8IDVDPqMFZVfhFhfW8jg=");

            NSNotificationCenter.DefaultCenter.AddObserver(UIApplication.DidBecomeActiveNotification, (notification) =>
            {
                if (navigation.Interrupted)
                {
                    architectView.reloadArchitectWorld();
                }
                StartAR();
            });

            NSNotificationCenter.DefaultCenter.AddObserver(UIApplication.WillResignActiveNotification, (notification) =>
            {
                StopAR();
            });

            var path = NSBundle.MainBundle.BundleUrl.AbsoluteString + "SDK_Examples/" + worldId + "/index.html";
            navigation = architectView.LoadArchitectWorldFromURL(NSUrl.FromString(path), WTFeatures.Geo);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            StartAR();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            StopAR();
        }

        public void StartAR()
        {
            if (!architectView.IsRunning)
            {
                architectView.Start((startupConfiguration) =>
               {
                   // use startupConfiguration.CaptureDevicePosition = AVFoundation.AVCaptureDevicePosition.Front; to start the Wikitude SDK with an active front cam
                   startupConfiguration.CaptureDevicePosition = AVFoundation.AVCaptureDevicePosition.Back;
               }, (isRunning, error) =>
               {
                   if (isRunning)
                   {
                       Console.WriteLine("Wikitude SDK version " + WTArchitectView.SDKVersion + " is running.");
                   }
                   else
                   {
                       Console.WriteLine("Unable to start Wikitude SDK. Error: " + error.LocalizedDescription);
                   }
               });
            }
        }

        public void StopAR()
        {
            if (architectView.IsRunning)
            {
                architectView.Stop();
            }
        }

        #region Rotation

        public override void WillRotate(UIInterfaceOrientation toInterfaceOrientation, double duration)
        {
            base.WillRotate(toInterfaceOrientation, duration);

            architectView.SetShouldRotateToInterfaceOrientation(true, toInterfaceOrientation);
        }

        public override bool ShouldAutorotate()
        {
            return true;
        }

        #endregion
    }
}
