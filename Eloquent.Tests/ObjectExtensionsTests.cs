using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eloquent.Tests.Objects
{
    public class ObjectExtensionsTests
    {
        [TestClass]
        public class ToBoolean
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.IsTrue(("true" as object).ToBoolean());
                Assert.IsFalse(("false" as object).ToBoolean());
            }
        }

        [TestClass]
        public class ToByte
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, ("1" as object).ToByte());
            }
        }

        [TestClass]
        public class ToDateTime
        {
            [TestMethod]
            public void Can_Convert()
            {
                DateTime dt = DateTime.Now;
                DateTime dt2 = (dt as object).ToDateTime();

                Assert.AreEqual(dt.ToString(), dt2.ToString());
            }

            [TestMethod]
            public void Can_Convert_String()
            {
                DateTime dt = new DateTime(2014, 04, 23, 10, 56, 10, 30);

                Assert.AreEqual(dt.ToString(), ("23-Apr-2014 10:56:10.30" as object).ToDateTime().ToString());
            }
        }

        [TestClass]
        public class ToDecimal
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1M, ("1" as object).ToDecimal());
                Assert.AreEqual(-1.12333M, ("-1.12333" as object).ToDecimal());
            }
        }

        [TestClass]
        public class ToDouble
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1D, ("1" as object).ToDouble());
                Assert.AreEqual(-1.12333D, ("-1.12333" as object).ToDouble());
            }
        }

        [TestClass]
        public class ToInt16
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, ("1" as object).ToInt16());
                Assert.AreEqual(-1, ("-1" as object).ToInt16());
            }
        }

        [TestClass]
        public class ToInt32
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, ("1" as object).ToInt32());
                Assert.AreEqual(-1, ("-1" as object).ToInt32());
            }
        }

        [TestClass]
        public class ToInt64
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, ("1" as object).ToInt64());
                Assert.AreEqual(-1, ("-1" as object).ToInt64());
            }
        }

        [TestClass]
        public class ToSByte
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, ("1" as object).ToSByte());
                Assert.AreEqual(-1, ("-1" as object).ToSByte());
            }
        }

        [TestClass]
        public class ToSingle
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, ("1" as object).ToSingle());
                Assert.AreEqual(-1, ("-1" as object).ToSingle());
            }
        }

        [TestClass]
        public class ToUInt16
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, ("1" as object).ToUInt16());
                Assert.AreEqual(UInt16.MaxValue, (UInt16.MaxValue as object).ToUInt16());
            }
        }

        [TestClass]
        public class ToUInt32
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(Convert.ToUInt32(1), "1".ToUInt32());
                Assert.AreEqual(UInt32.MaxValue, (UInt32.MaxValue as object).ToUInt32());
            }
        }

        [TestClass]
        public class ToUInt64
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(Convert.ToUInt64(1), "1".ToUInt64());
                Assert.AreEqual(UInt64.MaxValue, (UInt64.MaxValue as object).ToUInt64());
            }
        }
    }
}