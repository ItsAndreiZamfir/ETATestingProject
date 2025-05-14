using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Encapsulation
{
    public class WalletTest
    {
        Wallet wallet;

        [SetUp]
        public void Setup()
        {
            wallet = new Wallet(1000m);
        }

        [Test]
        public void TestDeposit()
        {
            wallet.Deposit(500m);
            Assert.That(wallet.GetBalance(), Is.EqualTo(1500m));
            Assert.That(wallet.Balance, Is.EqualTo(1500m));
        }

        [Test]
        public void TestWithdraw()
        {
            wallet.Withdraw(300m);
            Assert.That(wallet.GetBalance(), Is.EqualTo(700m));
            Assert.That(wallet.Balance, Is.EqualTo(700m));
        }
    }
}
