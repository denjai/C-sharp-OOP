namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private int interestRate;

        private decimal balance;

        public Account(Customer customer,decimal balance,int interest)
        {
            this.customer = customer;
            this.interestRate = interest;
            this.balance = balance;
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public int InterestRate
        {
            get { return interestRate; }
            set { this.interestRate = value; }
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public abstract decimal CalculateInterest(int months);
    }
}
