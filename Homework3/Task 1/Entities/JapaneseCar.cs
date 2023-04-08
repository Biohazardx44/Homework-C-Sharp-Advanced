namespace Task_1.Entities
{
    public class JapaneseCar : BaseEntity
    {
        public bool DriftMode { get; set; }

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving my Japanese {Brand} {Model} to {destinationName}!");
        }
    }
}