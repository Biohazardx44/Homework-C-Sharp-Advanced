using Task_2.Entities.Interfaces;

namespace Task_2.Entities
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking this vehicle! Stand back!");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Fixing this vehicle! *Fixing Sounds*");
        }
    }
}