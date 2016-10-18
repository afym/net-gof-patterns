using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwarePatterns.Structural.Flyweight;

namespace SoftwarePatternsTest.Structurals
{
    [TestClass]
    public class Flyweigth
    {
        [TestMethod]
        public void TestInstance()
        {
            BankTransaction Transaction = new BankTransaction();
            Assert.IsInstanceOfType(Transaction, typeof(ITransaction));
        }

        [TestMethod]
        public void TestImplement() 
        {
            string[] Banks = { "BCP", "INTERBANK", "BBVA", "BCR"};

            TransactionFlyWeightFactory Factory = new TransactionFlyWeightFactory();
            double TotalDiscount = 0.0d;

            for (int Bank = 0; Bank <= 1000; Bank++)
            {
                string BankCode = Banks[this.GetRandomBankIndex()];
                System.Diagnostics.Trace.WriteLine("BANK TRANSACTION :: " + BankCode);
                BankTransaction BankTran = (BankTransaction)Factory.GetBankTransactionByBankName(BankCode);
                BankTran.TransactionCode = this.GetRandomTransactionCode();
                BankTran.Amount = this.GetRandomAmount();
                BankTran.DateTime = DateTime.Now;
                TotalDiscount += BankTran.GetDiscount();
            }

            System.Diagnostics.Trace.WriteLine("BANK TRANSACTION DISCOUNT :: " + TotalDiscount);

            Assert.AreEqual(Factory.GetBankTransactions().Count, 4);
            Assert.AreNotEqual(0.0d, TotalDiscount);
            Factory.CleanBankTransactions();
            Assert.IsNull(Factory.GetBankTransactions());
        }

        private int GetRandomBankIndex() 
        {
            return new Random().Next(4);
        }

        private double GetRandomAmount() 
        {
            Random Random = new Random();
            int NumberA = Random.Next(50, 100);
            int NumberB = Random.Next(200, 800);
            int NumberC = Random.Next(1, 10);

            return (100 * (NumberA * NumberC) / NumberB);
        }

        private string GetRandomTransactionCode() 
        {
            Random Random = new Random();
            int NumberA = Random.Next(100, 900);
            int NumberB = Random.Next(5000, 8000);

            return "AFO-" + NumberA + NumberB;
        }
    }
}
