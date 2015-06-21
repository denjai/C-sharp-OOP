using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LambdaLinq
{
    public class EventTimer
    {
        public event EventHandler myEvent;
        public event EventHandler<string> PlsPrint;
        public EventTimer(int sec)
        {
            this.Sec = sec;
        }

        public int Sec { get; set; }
        public void Execute()
        {
            Thread th = new Thread(()=> {
            while (true)
            {

                Thread.Sleep(this.Sec * 1000);
                OnMyEvent(EventArgs.Empty);
                OnPlsPrint(this.Sec.ToString());
            }});
            th.Start();
        }
        protected virtual void OnMyEvent(EventArgs e)
        {
            if(this.myEvent!=null)
            {
                this.myEvent(this, e);
            }

        }

        protected virtual void OnPlsPrint(string e)
        {
            if (this.PlsPrint != null)
            {
                this.PlsPrint(this, e);
            }

        }
    }
}
