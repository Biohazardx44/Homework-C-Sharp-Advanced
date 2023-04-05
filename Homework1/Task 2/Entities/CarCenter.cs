using Task_2.Entities.Interfaces;

namespace Task_2.Entities
{
    internal class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private bool _isGasFull = false;
        private bool _isBroken = true;

        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking this vehicle! Stand back!");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            if (!_isBroken)
            {
                Console.WriteLine($"Vehicle is already fixed! Go run from the cops!");
            }
            else
            {
                Console.WriteLine($"Fixing this vehicle! *Fixing Sounds*");
                _isBroken = false;
            }
        }

        public void PumpGas(Vehicle vehicle)
        {
            if (_isGasFull)
            {
                Console.WriteLine($"Gas tank for vehicle is full!");
            }
            else
            {
                Console.WriteLine($"Pumping gas into vehicle.");
                _isGasFull = true;
            }
        }

        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing his car it's very nice!");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Washing his truck it's very nice!");
        }
    }
}