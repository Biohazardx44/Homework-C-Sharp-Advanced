namespace Task_1.Entities
{
    public class GermanCar : BaseEntity
    {
        public bool NaziOnBoard { get; set; }

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving my German {Brand} {Model} to {destinationName}!");
        }
    }
}