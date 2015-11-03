namespace AnimalHierarchy
{
    using AnimalHierarchy.Interfaces;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
        }
    }
}
