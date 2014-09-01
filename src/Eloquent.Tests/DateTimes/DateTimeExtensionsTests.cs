using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eloquent.Tests.DateTimes
{
    [ExcludeFromCodeCoverage]
    public static class DateTimeExtensionsTests
    {
        [TestClass]
        public class Ago
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(DateTime.Now.Subtract(10.Seconds()).ToShortTimeString(), 10.Seconds().Ago().ToShortTimeString());
            }
        }

        [TestClass]
        public class AgoUtc
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(DateTime.UtcNow.Subtract(10.Seconds()).ToShortTimeString(), 10.Seconds().AgoUtc().ToShortTimeString());
            }
        }

        [TestClass]
        public class FromNow
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(DateTime.Now.Add(10.Seconds()).ToShortTimeString(), 10.Seconds().FromNow().ToShortTimeString());
            }
        }

        [TestClass]
        public class FromNowUtc
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(DateTime.UtcNow.Add(10.Seconds()).ToShortTimeString(), 10.Seconds().FromNowUtc().ToShortTimeString());
            }
        }
    }
}