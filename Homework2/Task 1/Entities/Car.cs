namespace Task_1.Entities
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; } = 0;

        public string[]? CountriesInWhichItIsProduced { get; set; }

        public override string PrintVehicle()
        {
            return $"This is the type of the car: {Type}, and it was produced in these countries: {string.Join(", ", CountriesInWhichItIsProduced)}.";
        }
    }
}