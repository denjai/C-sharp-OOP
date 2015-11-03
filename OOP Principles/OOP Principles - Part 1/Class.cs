namespace School
{
    using System.Collections.Generic;

    public class Class:IComment
    {
        public Class(string id)
        {
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
            this.ID = id;
        }
        public string ID {  get; private set; }

        public List<Student> Students { get; private set; }

        public List<Teacher> Teachers { get; private set; }


        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(string name)
        {
            foreach (var student in Students)
            {
                if(student.Name==name)
                {
                    Students.Remove(student);
                }
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(string name)
        {
            foreach (var teacher  in Teachers)
            {
                if (teacher.Name == name)
                {
                    Teachers.Remove(teacher);
                }
            }
        }

        public string Comment{get; set;}

        public void ChangeComment(string comment)
        {
            this.Comment = comment;
        }
    }
}
