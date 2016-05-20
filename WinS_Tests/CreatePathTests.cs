using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Common;
using System.IO;
using System.Data;

namespace WinS_Tests
{
    [TestClass]
    public class CreatePathTests
    {
        [TestMethod]
        public void ShouldCreatePath()
        {
            Utils.CreatePath(@"D:\Adelina");
            Assert.IsTrue(Directory.Exists(@"D:\Adelina"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionAtCreatePath()
        {
            Utils.CreatePath("");
        }

    }
}
