using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eloquent.Tests.Strings
{
    public class StringExtensionsTests
    {
        [TestClass]
        public class IsNullOrEmpty
        {
            [TestMethod]
            public void Can_Determine()
            {
                Assert.IsTrue("".IsNullOrEmpty());
                Assert.IsFalse("blah".IsNullOrEmpty());
            }
        }

        [TestClass]
        public class IsNullOrWhiteSpace
        {
            [TestMethod]
            public void Can_Determine()
            {
                Assert.IsTrue("".IsNullOrWhiteSpace());
                Assert.IsTrue(" ".IsNullOrWhiteSpace());
                Assert.IsFalse("blah".IsNullOrWhiteSpace());
            }
        }


        [TestClass]
        public class ToBoolean
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.IsTrue("true".ToBoolean());
                Assert.IsFalse("false".ToBoolean());
            }
        }

        [TestClass]
        public class ToByte
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, "1".ToByte());
            }
        }

        [TestClass]
        public class ToDateTime
        {
            [TestMethod]
            public void Can_Convert()
            {
                DateTime dt = DateTime.Now;
                DateTime dt2 = dt.ToString().ToDateTime();

                Assert.AreEqual(dt.ToString(), dt2.ToString());
            }

            [TestMethod]
            public void Can_Convert_String()
            {
                DateTime dt = new DateTime(2014, 04, 23, 10, 56, 10, 30);
                
                Assert.AreEqual(dt.ToString(), "23-Apr-2014 10:56:10.30".ToDateTime().ToString());
            }
        }

        [TestClass]
        public class ToDecimal
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1M, "1".ToDecimal());
                Assert.AreEqual(-1.12333M, "-1.12333".ToDecimal());
            }
        }

        [TestClass]
        public class ToDouble
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1D, "1".ToDouble());
                Assert.AreEqual(-1.12333D, "-1.12333".ToDouble());
            }
        }

        [TestClass]
        public class ToInt16
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, "1".ToInt16());
                Assert.AreEqual(-1, "-1".ToInt16());
            }
        }

        [TestClass]
        public class ToInt32
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, "1".ToInt32());
                Assert.AreEqual(-1, "-1".ToInt32());
            }
        }

        [TestClass]
        public class ToInt64
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, "1".ToInt64());
                Assert.AreEqual(-1, "-1".ToInt64());
            }
        }

        [TestClass]
        public class ToSByte
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, "1".ToSByte());
                Assert.AreEqual(-1, "-1".ToSByte());
            }
        }

        [TestClass]
        public class ToSingle
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, "1".ToSingle());
                Assert.AreEqual(-1, "-1".ToSingle());
            }
        }

        [TestClass]
        public class ToUInt16
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(1, "1".ToUInt16());
                Assert.AreEqual(UInt16.MaxValue, UInt16.MaxValue.ToString().ToUInt16());
            }
        }

        [TestClass]
        public class ToUInt32
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(Convert.ToUInt32(1), "1".ToUInt32());
                Assert.AreEqual(UInt32.MaxValue, UInt32.MaxValue.ToString().ToUInt32());
            }
        }

        [TestClass]
        public class ToUInt64
        {
            [TestMethod]
            public void Can_Convert()
            {
                Assert.AreEqual(Convert.ToUInt64(1), "1".ToUInt64());
                Assert.AreEqual(UInt64.MaxValue, UInt64.MaxValue.ToString().ToUInt64());
            }
        }

        [TestClass]
        public class ParseDateTime
        {
            [TestMethod]
            public void Can_Convert()
            {
                DateTime dt = DateTime.Now;
                Assert.AreEqual(dt.ToString(), dt.ToString().ParseDateTime().ToString());
            }
        }
    }
}