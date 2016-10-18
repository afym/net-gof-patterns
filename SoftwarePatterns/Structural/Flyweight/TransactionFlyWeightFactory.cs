using System;
using System.Collections.Generic;

namespace SoftwarePatterns.Structural.Flyweight
{
    public class TransactionFlyWeightFactory
    {
        private static Dictionary<string, ITransaction> BankTransactions;

        public TransactionFlyWeightFactory() 
        {
            if (BankTransactions == null) 
            {
                BankTransactions = new Dictionary<string, ITransaction>();
            }
        }

        public ITransaction GetBankTransactionByBankName(string BankName)
        {
            BankTransaction BankTransaction = null;

            try
            {
                BankTransaction = (BankTransaction)BankTransactions[BankName];
            }
            catch (KeyNotFoundException e)
            {
                BankTransaction = new BankTransaction();
                BankTransaction.BankName = BankName;
                BankTransactions.Add(BankName, BankTransaction);
            }

            return BankTransaction;
        }

        public void CleanBankTransactions() 
        {
            BankTransactions = null;
        }

        /// <summary>
        /// Method just to validate a unit test
        /// </summary>
        /// <returns>Dictionary<string, ITransaction></returns>
        public Dictionary<string, ITransaction> GetBankTransactions() 
        {
            return BankTransactions;
        }
    }
}
