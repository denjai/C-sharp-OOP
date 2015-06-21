namespace LambdaLinq
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string p1;
        private string p2;
        private int p3;
        private string p4;

        public Student(string fName, string lName, int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
        }

        public Student(string fName, string lName, int age, int fn, string email, List<int> marks, int gn): this (fName,lName,age)
        {
            this.FN = fn;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = gn;
        }

        public Student(string p1, string p2, int p3, string p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("Age must be between 0 and 150");
                }
                this.age = value;
            }
        }

        public int FN { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }


        public override string ToString()
        {
            return this.firstName + " " + this.lastName + ", " + this.age + "-years-old";
        }
    }
}