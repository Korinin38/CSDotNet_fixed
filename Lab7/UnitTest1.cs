using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<ObjectWithName> list = new List<ObjectWithName> {
                new ObjectWithName("Foo"),
                new ObjectWithName("Bar"),
                new ObjectWithName("Baz"),
                new ObjectWithName("Hello"),
                new ObjectWithName("World!") };

            Assert.IsTrue("Hello World!".Equals(LinqQueries.Query1(list, ' ')));
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<ObjectWithName> list = new List<ObjectWithName> {
                new ObjectWithName("Every"),
                new ObjectWithName("one"),
                new ObjectWithName("I"),
                new ObjectWithName("know"),
                new ObjectWithName("are"),
                new ObjectWithName("here"),
                new ObjectWithName("(At least if I'm not forgetting anyone)") };

            var expected = LinqQueries.Query2(list);

            string result = String.Join("", from e in expected select e.Name);
            Assert.AreEqual("Everyoneknow(At least if I'm not forgetting anyone)", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string a = "Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена";

            LinqQueries.Query3(a);
        }
    }
}
