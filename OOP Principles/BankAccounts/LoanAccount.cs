using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class LoanAccount:Account,IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, int interest)
            : base(customer,balance,interest)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            if(months < 0)
            {
                throw new ArgumentException("Number of months should be possitive number");
            }
            if(Customer is Individual)
            {
                months = Math.Max(0,months -3 );
            }
            if (Customer is Company)
            {
                months = Math.Max(0, months - 2);
            }
            return (this.Balance*this.InterestRate / 100.0m )* months;
        }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }
    }
}
