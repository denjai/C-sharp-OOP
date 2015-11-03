namespace StudentsAndWorkers
{
    public class Worker:Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal salary, int hours)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }
        
        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / 5 / this.WorkHoursPerDay;
        }
        
    }
}
