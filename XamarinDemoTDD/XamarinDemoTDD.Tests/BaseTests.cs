using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XamarinDemoTDD.Tests
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void MustPass()
        {
            int expected = 1;
            int actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhenProjectStartedIsActive()
        {
            Project project = new Project();
            project.Start();
            Assert.IsTrue(project.IsActive);
        }

        [TestMethod]
        public void ProjectHasDuration()
        {
            DateTime startTime = DateTime.Now;
            var project = new Project();
            project.Start(startTime);
            project.End(startTime.AddSeconds(60));
            Assert.AreEqual(60, project.DurationInSeconds);
        }

        [TestMethod]
        public void ProjectCanStartAndStopAndHasDuration()
        {
            DateTime startTime = DateTime.Now;
            var project = new Project();

            project.Start(startTime);
            project.End(startTime.AddSeconds(60)); // 60
            project.Start(startTime.AddSeconds(120));
            project.End(startTime.AddSeconds(240)); // 120
            project.Start(startTime.AddSeconds(360));
            project.End(startTime.AddSeconds(720)); // 360

            Assert.AreEqual(project.DurationInSeconds, 60 + 120 + 360);
        }
    }
}
