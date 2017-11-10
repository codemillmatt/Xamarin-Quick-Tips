using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace MobileCenter.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            Microsoft.Azure.Mobile.MobileCenter.Start("61318f7e-d2f3-4742-86f8-45800aa7608a", typeof(Analytics), typeof(Crashes));

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
