namespace Task_1.Entities
{
    public class Vehicle
    {
        public int Id { get; set; } = 0;

        public string Type { get; set; } = string.Empty;

        public int YearOfProduction { get; set; } = 0;

        public int BatchNumber { get; set; } = 0;

        public virtual string PrintVehicle()
        {
            return $"This is the ID: {Id}, and this is the type: {Type}. It was made in {YearOfProduction}.";
        }
    }
}