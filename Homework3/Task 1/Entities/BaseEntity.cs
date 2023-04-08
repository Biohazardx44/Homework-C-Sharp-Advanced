namespace Task_1.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public string FuelType { get; set; } = string.Empty;

        public abstract void Drive(string destinationName);
    }
}