namespace CustomExeptions
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                throw new InvalidRangeException<int>("error",3,9);
            }
            catch (InvalidRangeException<int> e)
            {

                System.Console.WriteLine(e.Message+e.Start+e.End);
            }

        }
    }
}
