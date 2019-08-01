// ReSharper disable All

namespace OOBasics
{
    public class Account
    {
        public decimal balance { get; set; }
        private int number { get; }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public Account(decimal balance, int number)
        {
            this.balance = balance;
            this.number = number;
        }
    }
}