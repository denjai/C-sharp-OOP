namespace LambdaLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using LambdaLinq.Extensions;
    class EntryPoint
    {
        static void Main()
        {
            //zad. 1
            StringBuilder test = new StringBuilder("Helloe noobs are ready ?");
            StringBuilder subStr = new StringBuilder();
            subStr = test.Substring(7);
            Console.WriteLine(subStr.ToString());

            //zad. 2
            List<int> age = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine("Sum is: {0}", age.sum());
            Console.WriteLine("Product is: {0}", age.product());
            Console.WriteLine("Average is: {0}", age.Average());

            //zad 3
            Student[] students = new Student[]
            {
                new Student("Ivan", "Ivanov", 5),
                new Student("Stoqn", "Anabolov", 33),
                new Student("Chocho", "Horror", 22),
                new Student("Kuzman", "Ivanov", 17),
                new Student("Ivan", "Petkov", 66)
            };

            FirstBeforeLast(students);
            //zad. 4
            var filtered =
               from student in students
               where student.Age > 18 && student.Age < 24
               select new { FirstNaME = student.FirstName, LastName = student.LastName };

            //zad. 5
            var ordered = students
                .OrderByDescending(n => n.FirstName)
                .ThenByDescending(st => st.LastName);

            var orderedLinQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            foreach (var item in orderedLinQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            //zad. 6
            int[] numbers = new int[] { 1, 3, 7, 21, 42 };
            var res = Devisible(numbers);
            var res2 = DevisibleEx(numbers);
           
            //zad. 7
            Action<string> func = Print;
            StrDelegegate func2 = PrintReverse;
            StrDelegegate func3 = Print;
            string str = "My name is: MUNDO";
            string str2 = "Goes where....";
            //Timer timer1 = new Timer(func3);
            //timer1.Execute(str, 4);
            //Timer timer2 = new Timer(func2);
            //timer2.Execute(str2, 7);
            
            //zad. 8
            EventTimer timer3 = new EventTimer(5);
            EventTimer timer4 = new EventTimer(2);
            Subscriber executor = new Subscriber("WTF HELLO noob", timer3, func2);
            Subscriber executor2 = new Subscriber(timer4, func3);
            timer3.Execute();
            timer4.Execute();
        }
        public static IEnumerable<Student> FirstBeforeLast(Student[] students)
        {
            IEnumerable<Student> filtered =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return filtered;
        }

        public static int[] Devisible(int[] numbers)
        {
            var devisible =
                from num in numbers
                where num % 3 == 0 && num % 7 == 0
                select num;
            return devisible.ToArray();
        }
        public static int[] DevisibleEx(int[] numbers)
        {
            var devisible = numbers.Where( num => num%3==0&& num%7==0);  
            return devisible.ToArray();
        }

        public static void  Print(string str)
        {
            Console.WriteLine("sec: "+str.ToLower()); 
        }

        public static void PrintReverse(string str)
        {
            Console.WriteLine(str.Substring(3));
        }
    }
}
