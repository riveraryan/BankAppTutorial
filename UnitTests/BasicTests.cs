using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankyStuffLibrary;

namespace UnitTests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var account = new BankAccount("Ryan", 875);
        }
    }
}
