namespace DefiningClasses
{
    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

        public int? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        private BatteryType? batteryType;

        public int HoursIdle { get; set; }

        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.batteryType = null;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = type;
        }
    }
}

   public enum BatteryType
   {
        Lilon,
        NiMH,
        NiCD
   }