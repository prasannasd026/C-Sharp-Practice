using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_Sharp_Practice;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add2paramCorrectResult()
        {
            Assert.AreEqual(5, Math.Add(2,3));
        }

        [TestMethod]
        public void Add3ParamCorrectResult()
        {
            Assert.AreEqual(8, Math.Add(2, 3, 3));
        }
    }
}
