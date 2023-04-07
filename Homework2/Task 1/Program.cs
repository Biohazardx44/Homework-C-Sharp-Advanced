using Task_1.Entities;

foreach (Vehicle vehicle in StaticDB.Vehicles)
{
    Console.WriteLine(vehicle.PrintVehicle());
}

Console.WriteLine("===============================================");

Vehicle vehicle1 = new Vehicle { Id = 0, Type = "Kompir", YearOfProduction = 5000 };
Vehicle vehicle2 = new Vehicle { Id = 1, Type = "Yugo", YearOfProduction = 2021 };
Vehicle vehicle3 = new Vehicle { Id = 3, Type = "Truck", YearOfProduction = 0 };
Vehicle vehicle4 = new Vehicle { Id = 2, Type = "Sport", YearOfProduction = 2020 };

Validator.Validate(vehicle1);
Validator.Validate(vehicle2);
Validator.Validate(vehicle3);
Validator.Validate(vehicle4);