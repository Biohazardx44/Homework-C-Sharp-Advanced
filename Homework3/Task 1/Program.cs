using Task_1.Entities;
using Task_1.Extensions;

GenericDb<JapaneseCar> japaneseCar = new GenericDb<JapaneseCar>();
JapaneseCar car1 = new JapaneseCar
{
    Id = 1,
    Brand = "Toyota",
    Model = "Supra",
    MaxSpeed = 500,
    HorsePower = 1000,
    FuelType = "Gasoline",
    DriftMode = true
};

GenericDb<FrenchCar> frenchCar = new GenericDb<FrenchCar>();
FrenchCar car2 = new FrenchCar
{
    Id = 2,
    Brand = "Citroen",
    Model = "C5",
    MaxSpeed = 180,
    HorsePower = 300,
    FuelType = "Diesel",
    IsOld = true
};

GenericDb<GermanCar> germanCar = new GenericDb<GermanCar>();
GermanCar car3 = new GermanCar
{
    Id = 3,
    Brand = "Lamborghini",
    Model = "Aventador",
    MaxSpeed = 450,
    HorsePower = 800,
    FuelType = "Expensive",
    NaziOnBoard = false
};

japaneseCar.InsertCar(car1);
frenchCar.InsertCar(car2);
germanCar.InsertCar(car3);
Console.WriteLine("================================================");
japaneseCar.PrintAllCars();
frenchCar.PrintAllCars();
germanCar.PrintAllCars();
Console.WriteLine("================================================");
JapaneseCar japaneseCarById = japaneseCar.GetCarById(1);
Console.WriteLine($"Japanese Car with ID 1: {japaneseCarById.Brand} {japaneseCarById.Model} ({japaneseCarById.Id})");

FrenchCar frenchCarById = frenchCar.GetCarById(2);
Console.WriteLine($"French Car with ID 2: {frenchCarById.Brand} {frenchCarById.Model} ({frenchCarById.Id})");

GermanCar germanCarById = germanCar.GetCarById(3);
Console.WriteLine($"German Car with ID 3: {germanCarById.Brand} {germanCarById.Model} ({germanCarById.Id})");
Console.WriteLine("================================================");
car1.Drive("Tokyo");
car2.Drive("Paris");
car3.Drive("Berlin");
Console.WriteLine("================================================");
string redText = "Oh no... Red text cant be good :/";
redText.WriteInColor(ConsoleColor.Red);
string greenText = "GREEN!!! Thats what we want to see!!!";
greenText.WriteInColor(ConsoleColor.Green);
string yellowText = "Good enough...";
yellowText.WriteInColor(ConsoleColor.Yellow);