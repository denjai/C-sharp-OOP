namespace AnimalHierarchy
{
    using System.Linq;

    public class EntryPoint
    {
        static void Main()
        {
            Cat cat = new Cat("Roni", 5, Gender.Male);
            System.Console.WriteLine(cat.CreateSound());

            Kitten kitten = new Kitten("Puhi", 1);
            System.Console.WriteLine(kitten.CreateSound());

            Frog[] frogs = 
            {
                new Frog("Zeleniq", 1, Gender.Male),
                new Frog("Suzi", 2, Gender.Female),
                new Frog("Jabcho", 3, Gender.Male),
                new Frog("Skoklio", 3, Gender.Male),
                new Frog("Groznata", 2,Gender.Female)
            };
            System.Console.WriteLine(frogs.Average(fr => fr.Age));
        }
    }
}
