namespace Task_1.Entities
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Validation failed for: {vehicle.Type} with ID: {vehicle.Id} and made in {vehicle.YearOfProduction}!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Validation passed for: {vehicle.Type} with ID: {vehicle.Id} and made in {vehicle.YearOfProduction}!");
                Console.ResetColor();
            }
        }
    }
}