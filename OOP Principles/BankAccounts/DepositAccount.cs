using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class DepositAccount : Account, IDeposit, IWithdraw
    {

        public DepositAccount(Customer customer, decimal balance, int interest)
            : base(customer, balance, interest)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && Balance < 1000m)
            {
                return 0m;
            }
            else return months * Balance * (InterestRate / 100.0m);
        }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public void Withdraw(decimal money)
        {
            if (this.Balance - money < 0.0m)
            {
                throw new ArgumentOutOfRangeException("Balance is too low.");
            }
            else this.Balance -= money;
        }
    }
}
