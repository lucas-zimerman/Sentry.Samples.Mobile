using Foundation;
using UIKit;

namespace Sentry.Samples.Mobile.iOS
{
    public class NativeCrash : INativeCrash
    {
        public void Crash()
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;

            vc = vc.PresentedViewController;
            UIView.BeginAnimations("Animate for keyboard");
            UIView.SetAnimationBeginsFromCurrentState(true);
            UIView.SetAnimationDuration(UIKeyboard.AnimationDurationFromNotification(new NSNotification(null)));
            UIView.SetAnimationCurve((UIViewAnimationCurve)UIKeyboard.AnimationCurveFromNotification(new NSNotification(null)));

            var keyboardFrame = true ? UIKeyboard.FrameEndFromNotification(new NSNotification(null)) : UIKeyboard.FrameBeginFromNotification(new NSNotification(null));


            UIView.CommitAnimations();

            }
        }
    }
}