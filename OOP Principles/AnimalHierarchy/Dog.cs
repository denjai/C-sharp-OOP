namespace AnimalHierarchy
{
    using AnimalHierarchy.Interfaces;
    /// <summary>
    /// A basic Dog class derrived from class Animal
    /// </summary>
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>What the current animal says as string</returns>
        public override string CreateSound()
        {
            return base.CreateSound() + "Bau";
        }
    }
}
