using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Config;

namespace WinS_Tests
{
    [TestClass]
    public class GlobalSettingsTests
    {
        [TestMethod]
        public void ShouldMakeANotEmptyConnString()
        {
            ConfigManager.SetServiceConfiguration();

            Assert.AreNotEqual("", GlobalSettings.myConnectionString);
        }

        [TestMethod]
        public void ShouldReadConfiguration()
        {
            AppConfigReader sut = new AppConfigReader();
            sut.ReadConfiguration();

            Assert.IsNotNull(GlobalSettings.webSite);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldFacadeWork()
        {
            GlobalSettings settings = new GlobalSettings();
            settings.BuildConnectionString();
        }
    }
}
