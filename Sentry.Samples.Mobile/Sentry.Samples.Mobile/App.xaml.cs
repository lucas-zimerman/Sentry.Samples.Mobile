using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sentry.Samples.Mobile
{
    public partial class App : Application
    {
        public static INativeCrash NativeCrash;
        public App()
        {
            _ = SentrySdk.Init(o =>
            {
                o.Debug = true;
                o.Dsn = "https://80aed643f81249d4bed3e30687b310ab@o447951.ingest.sentry.io/5428537";
              //  o.CacheDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "sentryLogs");
            });

            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart() => SentrySdk.AddBreadcrumb("OnStart", "app.lifecycle", "event");

        protected override void OnSleep() => SentrySdk.AddBreadcrumb("OnSleep", "app.lifecycle", "event");

        protected override void OnResume() => SentrySdk.AddBreadcrumb("OnResume", "app.lifecycle", "event");

    }
}
