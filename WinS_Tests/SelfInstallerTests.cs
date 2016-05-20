using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Common;

namespace WinS_Tests
{
    [TestClass]
    public class SelfInstallerTests
    {   
        [TestMethod]
        public void ShouldBeSingleton()
        {
            SelfInstaller sut1 = SelfInstaller.GetInstance();
            SelfInstaller sut2 = SelfInstaller.GetInstance();

            Assert.ReferenceEquals(sut2, sut1);
        }
    }
}
