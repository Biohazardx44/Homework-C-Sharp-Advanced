namespace Task_1.Entities
{
    public class GenericDb<T> where T : BaseEntity
    {
        public List<T> Entities;

        public GenericDb()
        {
            Entities = new List<T>();
        }

        public void InsertCar(T car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            Entities.Add(car);
            Console.WriteLine($"Added {car.Brand} {car.Model} ({car.Id}) to the database.");
        }

        public T GetCarById(int id)
        {
            return Entities.Find(car => car.Id == id);
        }

        public void PrintAllCars()
        {
            foreach (BaseEntity car in Entities)
            {
                Console.WriteLine($"Brand: {car.Brand}\nModel: {car.Model}\nMax Speed: {car.MaxSpeed}\nHorsepower: {car.HorsePower}\nFuel Type: {car.FuelType}\n");
            }
        }
    }
}