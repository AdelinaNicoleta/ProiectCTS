using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Common;
using System.IO;
using System.Data;
using System.Threading;
using System.Diagnostics;
using WinS_RomanianTrips.ThreadSync;

namespace WinS_Tests
{
    [TestClass]
    public class DiscoverRomaniaTests
    {
        [TestMethod]
        public void ShouldStartThreadDiscoverRomania()
        {
            int startNumber = Process.GetCurrentProcess().Threads.Count;
            ThreadDiscoverRomania sut = new ThreadDiscoverRomania();
            sut.StartSync();
            int endNumber = Process.GetCurrentProcess().Threads.Count;
            Assert.AreEqual(startNumber + 1, endNumber);
        }

    }
}
