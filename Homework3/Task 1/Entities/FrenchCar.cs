namespace Task_1.Entities
{
    public class FrenchCar : BaseEntity
    {
        public bool IsOld { get; set; }

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving my French {Brand} {Model} to {destinationName}!");
        }
    }
}