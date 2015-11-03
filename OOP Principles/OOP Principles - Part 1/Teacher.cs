using System.Collections.Generic;
namespace School
{
    public class Teacher: Person,IComment
    {
        public Teacher(string name):base(name)
        {
            this.Disciplines = new List<Discipline>();
        }
        public List<Discipline> Disciplines{get; private set;}

        public void AddDiscpline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscpline(string name)
        {
            foreach (var discpline in Disciplines)
            {
                if(discpline.Name==name)
                {
                    this.Disciplines.Remove(discpline);
                }
            }
        }


        public string Comment {get;set;}

        public void ChangeComment(string comment)
        {
            this.Comment=comment;
        }
    }
}
