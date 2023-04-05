using Task_1.Entities.Interfaces;

namespace Task_1.Entities
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating his {food}!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"My cat {Name} is {Age} years old!");
        }
    }
}