using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    class EntryPoint
    {
        static void Main()
        {
            string str = "  new string";
            string[] splited = str.Split(' ','*');

        }
        void test()
        {
            while(true)
            {
                double res = 0.0 / 0.0;
                if (res==double.NaN)
                {
                    Console.WriteLine("error");
                    break;
                }
            }
            Console.WriteLine("over");
        }
    }
}
