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
    }
}
