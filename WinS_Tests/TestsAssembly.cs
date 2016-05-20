using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinS_RomanianTrips.Common;
using System.IO;
using System.Data;

namespace WinS_Tests
{
    [TestClass()]
    public class TestsAssembly
    {
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            context.BeginTimer("romaniantrips");

            CreatePathTests tst = new CreatePathTests();
            MoveFileTests txt2 = new MoveFileTests();
            tst.ShouldCreatePath();
            tst.ShouldThrowExceptionAtCreatePath();
            txt2.ShouldMoveFiles();
            txt2.ShouldThrowExceptionAtMoveFiles();

            context.EndTimer("romaniantrips");
        }
    }
}
