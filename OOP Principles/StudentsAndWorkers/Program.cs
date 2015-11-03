using System.Collections.Generic;
using System.Linq;
namespace StudentsAndWorkers
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Qnko", "Manchev", 5),
                new Student("Murdjo", "Reksi", 3),
                new Student("Ivan", "Petrov", 3),
                new Student("Bacho", "Qbac", 5),
                new Student("Ceco", "Abadjiev", 6)
            };
            var ordered = students.OrderBy(st => st.Grade);

            List<Worker> workers = new List<Worker>
            {
                new Worker("Qnko", "Ivanov", 80,8),
                new Worker("Reksai", "Petrov", 145,8),
                new Worker("Petar", "Manchev", 77,8),
                new Worker("Kaloqn", "Ganchev", 150,8),
                new Worker("Ivan", "Ivanov", 120,8)
            };

            var richest = workers.OrderBy(st => st.MoneyPerHour());

            //List<Human> human = students;
            //human.AddRange(workers);
        }
    }
}
