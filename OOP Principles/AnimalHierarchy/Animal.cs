namespace AnimalHierarchy
{
    using AnimalHierarchy.Interfaces;

    public class Animal : ISound
    {
        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public int Age { get; private set; }

        public string Name { get; private set; }

        public Gender Gender { get; private set; }

        public virtual string CreateSound()
        {
            return string.Format("{0} says ", this.Name);
        }
    }
}
