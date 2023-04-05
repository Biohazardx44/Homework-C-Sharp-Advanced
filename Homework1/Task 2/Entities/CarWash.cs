using Task_2.Entities.Interfaces;

namespace Task_2.Entities
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing his car. It's very nice!");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Washing his truck. It's very nice!");
        }
    }
}