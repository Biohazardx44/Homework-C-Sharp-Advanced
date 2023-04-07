namespace Task_1.Entities
{
    public static class StaticDB
    {
        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>
        {
            new Car
            {
                Id = 1,
                Type = "Yugo",
                YearOfProduction = 2021,
                BatchNumber = 12345,
                FuelTank = 50,
                CountriesInWhichItIsProduced = new string[] { "Germany", "UK", "USA" }
            },
            new Bike
            {
                Id = 2,
                Type = "Sport",
                YearOfProduction = 2020,
                BatchNumber = 5678,
                Color = "Green"
            },
            new Vehicle
            {
                Id = 3,
                Type = "Truck",
                YearOfProduction = 2023,
                BatchNumber = 911
            }
        };
    }
}