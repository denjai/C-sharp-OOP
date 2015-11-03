using System;
namespace BankAccounts
{
    public class MortgageAccount:Account,IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, int interest)
            : base(customer,balance,interest)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Number of months should be possitive number");
            }
            if (Customer is Individual)
            {
                months = Math.Max(0, months - 6);
                return this.Balance * this.InterestRate / 100.0m * months;
            }
            if (Customer is Company)
            {
                int fullInterest = Math.Max(0,months-12);
                if (fullInterest > 0)
                    months = 12;
                return this.Balance * (this.InterestRate / 100.0m * fullInterest) + this.Balance * (this.InterestRate / 100.0m / 2 * months);
            }
            return 0;
        }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }
    }
}
