using System;

namespace SoftwarePatterns.Structural.Flyweight
{
    public class BankTransaction : ITransaction
    {
        const double DISCOUNT_PERCENT = 0.5d;

        public string BankName { set; get; }
        public string TransactionCode { set; get; }
        public DateTime DateTime { set; get; }
        public double Amount { set; get; }

        public double GetDiscount()
        {
            return this.Amount * DISCOUNT_PERCENT;
        }
    }
}
