namespace Task_1.Entities
{
    public class ItalianCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving my Italian {Brand} {Model} to {destinationName}!");
        }
    }
}