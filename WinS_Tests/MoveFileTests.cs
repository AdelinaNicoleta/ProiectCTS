using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Common;
using System.IO;
using System.Data;

namespace WinS_Tests
{
    [TestClass]
    public class MoveFileTests
    {
        [TestMethod]
        public void ShouldMoveFiles()
        {
            if (!Directory.Exists(@"D:\Adelina\Test"))
            {
                Directory.CreateDirectory(@"D:\Adelina\Test");
            }
            var myFile = File.Create(@"D:\Adelina\Test\test.txt");
            myFile.Close();

            Utils.MoveFileToProcessed(@"D:\Adelina\Test", "test.txt");

            Assert.IsTrue(File.Exists(@"D:\Adelina\Test\Processed\" + "test" + DateTime.Now.ToShortDateString() + ".txt"));

            File.Delete(@"D:\Adelina\Test\Processed\" + "test" + DateTime.Now.ToShortDateString() + ".txt");
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ShouldThrowExceptionAtMoveFiles()
        {
            Utils.MoveFileToProcessed("", "test.txt");
        }
    }
}
