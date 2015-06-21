using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    public class Subscriber
    {
        private string id;

        public Subscriber(EventTimer timer, StrDelegegate msg)
        {
            this.Func = msg;
            timer.PlsPrint += HandlePlsPrint;
        }
        public StrDelegegate Func { get; set; }
        public Subscriber(string ID, EventTimer timer, StrDelegegate msg)
        {
            id = ID;
            // Subscribe to the event using C# 2.0 syntax
            timer.myEvent += HandleCustomEvent;
            this.Func = msg;
        }

        // Define what actions to take when the event is raised. 
        void HandleCustomEvent(object sender, EventArgs e)
        {
            this.Func(this.id);
            //Console.WriteLine(((EventTimer)sender).Sec);     
        }

        void HandlePlsPrint(object tmr, string str)
        {
            //Console.WriteLine(str);
            this.Func(str);
        }
    }
}
