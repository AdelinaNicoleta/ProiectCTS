using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Config;
using WinS_RomanianTrips.ThreadSync;
using WinS_RomanianTrips.Download;

namespace WinS_Tests
{
    [TestClass]
    public class FileSyncTests
    {
        [TestMethod]
        public void ShouldAttachAndDetach()
        {
            ISync sut1 = new ThreadDiscoverRomania();
            ISync sut2 = new ThreadHotels();
            ISync sut3 = new ThreadTravelAgents();

            FileSync sync = new FileSync();
            sync.attach(sut1);
            sync.attach(sut2);
            sync.detach(sut3);

            Assert.AreEqual(2, sync.syncList.Count);
        }
    }
}
