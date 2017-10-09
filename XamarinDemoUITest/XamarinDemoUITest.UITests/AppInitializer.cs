using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinDemoUITest.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                /*
                return ConfigureApp
                    .Android
                    .StartApp();
                    */
                return ConfigureApp.Android.Debug().ApkFile(@"C:\Users\marcel.jurtz\Documents\Visual Studio 2017\Projects\XamarinDemoUITest\XamarinDemoUITest\XamarinDemoUITest.Android\bin\Release\XamarinDemoUITest.Android-Signed.apk").StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

