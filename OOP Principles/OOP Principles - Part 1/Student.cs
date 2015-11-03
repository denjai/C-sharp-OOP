namespace School
{
    public class Student : Person, IComment
    {

        private int classNumber;

        public Student(string name, int number)
            : base(name)
        {
            this.ClassNumber = number;
        }
        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }




        public string Comment { get; set; }

        public void ChangeComment(string comment)
        {
           this.Comment= comment;
        }
    }
}
