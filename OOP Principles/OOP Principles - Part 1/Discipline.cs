namespace School
{
    public class Discipline:IComment
    {
        public Discipline(string name, int lectures, int execises)
        {
            this.Name= name;
            this.NumberOfExercises = execises;
            this.NumberOfLectures = lectures;
        }
        public string  Name{ get; private set; }
        public int NumberOfLectures { get; private  set; }
        public int NumberOfExercises { get; private set; }


        public string Comment{ get; private set;}

        public void ChangeComment(string comment)
        {
            this.Comment= comment;
        }
    }
}
