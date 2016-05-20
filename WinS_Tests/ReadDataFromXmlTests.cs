using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Common;
using System.IO;
using System.Data;

namespace WinS_Tests
{
    [TestClass]
    public class ReadDataFromXmlTests
    {
        [TestMethod]
        public void ShouldReadDataFromExcel()
        {
            DataRowCollection sut = Utils.GetDataFromExcel(@"D:\inainte\OUT\DiscoverRomania\GhizAtestati230320152.xlsx");
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void ShouldReturnNull()
        {
            DataRowCollection sut = Utils.GetDataFromExcel(@"D:\inainte\OUT\DiscoverRomania\test.txt");
            Assert.IsNull(sut);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionAtReadData()
        {
            DataRowCollection sut = Utils.GetDataFromExcel("");
        }

    }
}
