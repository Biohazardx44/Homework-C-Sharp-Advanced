using Task_2.Entities.Interfaces;

namespace Task_2.Entities
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Pumping gas into the vehicle.");
        }
    }
}