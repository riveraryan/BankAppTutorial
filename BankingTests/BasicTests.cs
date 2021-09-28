using System;
using Xunit;
using BankyStuffLibrary;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void testNegativeInitialBalance()
        {
            Assert.Throws<ArgumentException>(
                ()=>new BankAccount("Ryan", -875)
            );
        }

        [Fact]
        public void TestOverdraft() 
        {
            BankAccount account = new BankAccount("Ryan", 875);

            Assert.Throws<InvalidOperationException>(
                ()=>  account.makeWithdrawal(1000, DateTime.Now, "Attempt Overdraft")
            );

            Assert.Throws<ArgumentException>(
                () => account.makeWithdrawal(-1000, DateTime.Now, "Attempt Overdraft")
            );
        }
    }
}
