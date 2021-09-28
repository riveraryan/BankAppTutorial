using System;
using Xunit;
using BankyStuffLibrary;

namespace BankTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BankAccount account = new BankAccount("Ryan", 1000);
        }
    }
}
