using Task_1.Entities.Interfaces;

namespace Task_1.Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public void Bark()
        {
            Console.WriteLine("Bark Bark!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"My dog {Name} is {Age} years old!");
        }
    }
}