using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedNumber;
        private int duration;
        public Call(string number,int dur)
        {
            this.date = DateTime.Now;
            this.Time = DateTime.Now;
            this.DialedNumber = number;
            this.Duration = dur;
        }
        public int Duration { get; set; }

        public string DialedNumber { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }
    }
}
