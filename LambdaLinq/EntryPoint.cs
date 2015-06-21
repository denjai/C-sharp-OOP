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

            //zad. 9
            List<int> marks = new List<int> { 3, 4, 5, 6, 6, 5, 5, 3 };
            List<Student> studs = new List<Student>{
                new Student("Nunu", "Ivanov", 22, 445506, "abc@abv.bg", marks,2),
                new Student("Cuci", "Petrov", 22, 315562, "abd@abv.bg", marks, 2),
                new Student("Ivan", "Cecov", 5, 445506, "abe@abv.bg", new List<int>{3,4}, 1),
                new Student("Mundo", "Qnkov", 5, 232564, "abf@abv.bg", marks, 2),
                new Student("Gosho", "Goshov", 22, 445506, "abg@abv.bg", new List<int>{4,5}, 1),
                new Student("Rengo", "Mehdi", 5, 440266, "abh@abv.bg", marks, 3)
            };

            var groupTwo =
                from student in studs
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            //zad. 10
            var groupTwoExt = studs.Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);

            //zad. 11
            var abv =
                from student in studs
                where student.Email.Contains("abv.bg")
                select student;

            //zad. 12
            var phones =
                from student in studs
                where student.FN.ToString().StartsWith("31")
                select student;
            //zad. 13
            var markSix =
                from student in studs
                where student.Marks.Contains(6)
                select new { FirstName = student.FirstName, Marks = student.Marks };
            //zad. 14
            Func<Student, bool> markLambda = st =>
            {
                if (st.Marks.Count == 2)
                    return true;
                else return false;
            };
            var twoMarks = studs.Where(markLambda);

            //zad. 15
            var marks2 =
                from student in studs
                where student.FN.ToString().EndsWith("06")
                select student;
            //zad. 16  |INNER JOIN
            var groups = new List<Group>{
                new Group(2,"Mathematics"),
                new Group(1, "Physics"),
                new Group(3, "Acountants")
            };
            var matStudents =
                from student in studs
                join groupN in groups on student.GroupNumber equals groupN.GroupNumber
                where groupN.DepartmentName == "Mathematics"
                select student;
            //zad. 17
            var list = new List<string>{
                "short",
                "medium string",
                "very very very long"
            };
            string p = GetLongest(list);

            //zad. 18
            PrintGroups(studs);
            //zad. 19
            PrintGroupsExt(studs);

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
            var devisible = numbers.Where(num => num % 3 == 0 && num % 7 == 0);
            return devisible.ToArray();
        }

        public static void Print(string str)
        {
            Console.WriteLine("sec: " + str.ToLower());
        }

        public static void PrintReverse(string str)
        {
            Console.WriteLine(str.Substring(3));
        }

        //zad. 17
        public static string GetLongest(List<String> list)
        {
            var result =(
                from item in list
                where list.Max(i => i.Length) == item.Length
                select item).Single();

            return result;
        }

        //zad. 18
        public static void PrintGroups(List<Student> students)
        {
            var result =
                from student in students
                group student by student.GroupNumber into groups
                select groups;
            foreach (var group in result)
            {
                Console.WriteLine("group {0}",group.First().GroupNumber);
                foreach (var student in group)
                {
                    Console.WriteLine("Name:{0}",student.FirstName);
                }
                
            }
        }
        //zad. 19
        public static void PrintGroupsExt(List<Student> students)
        {
            var result = students.GroupBy(student => student.GroupNumber);

            foreach (var group in result)
            {
                Console.WriteLine("group {0}", group.First().GroupNumber);
                foreach (var student in group)
                {
                    Console.WriteLine("Name:{0}", student.FirstName);
                }
            }
        }
    }
}
