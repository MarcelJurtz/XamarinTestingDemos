using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinDemoUITest.UITests
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void Add5To7()
        {
            // Arrange
            app.EnterText("txtValueA", "5");
            app.EnterText("txtValueB", "7");

            // Act
            app.Tap("cmdAdd");

            // Assert
            var appResult = app.Query("lblResult").First(result => result.Text == "12");
            Assert.IsTrue(appResult != null, "Label is not displaying the correct result");
        }
    }
}

