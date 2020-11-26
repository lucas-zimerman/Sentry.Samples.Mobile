using Foundation;
using ObjCRuntime;
using System;
using UIKit;

namespace Sentry.Samples.Mobile.iOS
{
    public class NativeCrash : INativeCrash
    {
        public void Crash()
        {
            var window = UIApplication.Alloc(new Class(new IntPtr(-1)));
        }
    }
}