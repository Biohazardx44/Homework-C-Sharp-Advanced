namespace Task_1.Entities
{
    public class Bike : Vehicle
    {
        public string Color { get; set; } = string.Empty;

        public override string PrintVehicle()
        {
            return $"This bike was produced in {YearOfProduction}, and it's color is {Color}.";
        }
    }
}