

using System.Collections.Generic;
namespace DefiningClasses
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static string iPhone4s;



        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.battery = new Battery();
            this.display = new Display();
            this.CallHistory = new List<Call>();

        }
        public GSM(string model, string manufacturer, decimal price, string owner, int size, int numberOfColors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery(); ;
            this.display = new Display(size, numberOfColors);
            this.CallHistory = new List<Call>();
        }

        public static string IPhone4S { get; set; }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }

        public List<Call> CallHistory { get; set; }

        public override string ToString()
        {
            return model + "," + manufacturer + "," + price;
        }

        public void AddCall(Call callToAdd)
        {
            CallHistory.Add(callToAdd);
        }
        public void DeleteCall()
        {
            CallHistory.RemoveAt(0);
        }
        public void ClearCalls()
        {
            CallHistory.Clear();
        }

        public decimal CalculatePrice(decimal price)
        {
            decimal sum=0m;
            foreach (var call in CallHistory)
            {

                sum += (call.Duration / 60) * price;
            }
            return sum;
        }
    }
}
