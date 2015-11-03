namespace AnimalHierarchy
{
    using AnimalHierarchy.Interfaces;
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }
        public override string CreateSound()
        {
            return base.CreateSound() + "Kwak";
        }
    }
}
