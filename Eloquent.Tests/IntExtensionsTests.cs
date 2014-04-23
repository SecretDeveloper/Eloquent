using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eloquent.Tests
{
    public class IntExtensionsTests
    {
        [TestClass]
        public class Times
        {
            [TestMethod]
            public void Can_Count()
            {
                var list = new List<string>();
                10.Times(() => list.Add("Item"));

                Assert.AreEqual(10, list.Count);
                Assert.IsTrue(list.All(x => x.Equals("Item")));
            }
        }

        [TestClass]
        public class Bytes
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10.Bytes(), 4.Bytes() + 6.Bytes());
            }
        }

        [TestClass]
        public class Kilobytes
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10.Kilobytes(), 4.Kilobytes() + 6.Kilobytes());
            }
        }

        [TestClass]
        public class Megabytes
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10.Megabytes(), 4.Megabytes() + 6.Megabytes());
            }
        }

        [TestClass]
        public class Gigabytes
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10.Gigabytes(), 4.Gigabytes() + 6.Gigabytes());
            }
        }

        [TestClass]
        public class Terabytes
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10.Terabytes(), 4.Terabytes() + 6.Terabytes());
            }
        }

        [TestClass]
        public class Petabytes
        {
            [TestMethod]
            public void Can_Count()
            {
                Assert.AreEqual(10.Petabytes(), 4.Petabytes() + 6.Petabytes());
            }
        }

        [TestClass]
        public class Exabytes
        {
            [TestMethod]
            public void Can_Add_Exabytes()
            {
                Assert.AreEqual(10.Exabytes(), 4.Exabytes() + 6.Exabytes());
            }

            [TestMethod]
            public void Can_Add_Exabytes_All()
            {
                var result = 1.Exabytes() + 1.Petabytes() + 1.Terabytes() + 1.Gigabytes() + 1.Megabytes() + 1.Kilobytes() + 1.Bytes();
                Assert.AreEqual(1154048505100108801, result);
            }
        }
    }
}
