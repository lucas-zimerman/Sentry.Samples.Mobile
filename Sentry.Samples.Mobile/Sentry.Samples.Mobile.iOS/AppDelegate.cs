using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Foundation;
using UIKit;

namespace Sentry.Samples.Mobile.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var sw = Stopwatch.StartNew();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            var @return = base.FinishedLaunching(app, options);

            SentrySdk.AddBreadcrumb(
                "FinishedLaunching",
                "app.lifecycle",
                "event",
                new Dictionary<string, string>()
            {
                {"timing", sw.Elapsed.ToString()},
                {"return", @return.ToString()}
            });
            return @return;
        }
    }
}