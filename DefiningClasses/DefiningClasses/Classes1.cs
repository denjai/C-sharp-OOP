using System;


namespace DefiningClasses
{
    class Classes1
    {
        static void Main(string[] args)
        {
            Battery bat = new Battery("asd", 5, 5, BatteryType.NiMH);
            GSM myphone = new GSM("1600", "NOKIA");
            myphone.AddCall(new Call("08866553363",150));
            myphone.AddCall(new Call("08866555563", 10));
            myphone.AddCall(new Call("08866559999", 159));

            Console.WriteLine(myphone.ToString());
            Console.WriteLine(myphone.Model);
            foreach (var call in myphone.CallHistory)
            {
                Console.WriteLine(call.DialedNumber+" : "+call.Duration);
            }
            Console.WriteLine(myphone.CalculatePrice(0.37m));
            myphone.DeleteCall();
            Console.WriteLine(myphone.CalculatePrice(0.37m));
            myphone.ClearCalls();
            foreach (var call in myphone.CallHistory)
            {
                Console.WriteLine(call.DialedNumber + " : " + call.Duration);
            }

        }
    }
}
