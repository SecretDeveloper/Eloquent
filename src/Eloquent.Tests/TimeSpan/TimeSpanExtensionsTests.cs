using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eloquent.Tests.TimeSpan
{
    [ExcludeFromCodeCoverage]
    public class TimeSpanExtensionsTests
    {
        [TestClass]
        public class Milliseconds
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10, 10.Milliseconds().Milliseconds);
            }
        }

        [TestClass]
        public class Seconds
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10, 10.Seconds().Seconds);
            }
        }

        [TestClass]
        public class Minutes
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10, 10.Minutes().Minutes);
            }
        }

        [TestClass]
        public class Hours
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10, 10.Hours().Hours);
            }
        }

        [TestClass]
        public class Days
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10, 10.Days().Days);
            }
        }

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