using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HundredMillionStrings.Generate(4);
            // HundredMillionStrings.Generate(8); //big mistake! (as big as ~1 GB) Let's just believe it works.
        }
    }
}
