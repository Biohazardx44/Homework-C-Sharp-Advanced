namespace Task_1.Entities
{
    public class AmericanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving my American {Brand} {Model} to {destinationName}!");
        }
    }
}