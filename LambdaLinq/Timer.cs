namespace LambdaLinq
{
    using System;
    using System.Threading;
    public delegate void StrDelegegate(string str);
    public class Timer
    {
        public Timer(StrDelegegate msg)
        {
            this.Func = msg;
        }
        public StrDelegegate Func { get; set; }
        public void Execute(string str, int sec)
        {
            Thread th = new Thread(() =>
            {
                while (true)
                {
                    this.Func(str);
                    Thread.Sleep(sec * 1000);
                }
            });
            th.Start();
        }
    }
}
