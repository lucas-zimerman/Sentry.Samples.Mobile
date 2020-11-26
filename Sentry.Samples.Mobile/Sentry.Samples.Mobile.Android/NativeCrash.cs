using Android.App;
using Android.Content;


namespace Sentry.Samples.Mobile.Droid
{
    public class NativeCrash : INativeCrash
    {
        public void Crash()
        {
            var currentContext = Application.Context;
            currentContext.StartService(new Intent("heh"));
        }
    }
}