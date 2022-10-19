using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Lab6
{
    [TestClass]
    public class LakeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Lake lake1 = new Lake(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 });
            Lake lake2 = new Lake(new List<int> { 13, 23, 1, -8, 4, 9 });

            List<int> expected1 = new List<int> { 1, 3, 5, 7, 8, 6, 4, 2 };
            List<int> expected2 = new List<int> { 13, 1, 4, 9, -8, 23 };

            int i1 = 0;
            int i2 = 0;

            foreach (int stone in lake1)
            {
                Assert.AreEqual(expected1[i1++], stone);
            }

            foreach (int stone in lake2)
            {
                Assert.AreEqual(expected2[i2++], stone);
            }
        }
    }
}
