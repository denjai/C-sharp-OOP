namespace AnimalHierarchy
{
    using AnimalHierarchy.Interfaces;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override string CreateSound()
        {
            return base.CreateSound() + "MYAU";
        }
    }
}
