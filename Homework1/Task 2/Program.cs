using Task_2.Entities;

Car car = new Car();
Truck truck = new Truck();
CarWash carWash = new CarWash();
GasPump gasPump = new GasPump();
RepairService repairService = new RepairService();
CarCenter carCenter = new CarCenter();

car.Drive();
truck.Drive();
Console.WriteLine("========================================");
carWash.WashCar(car);
carWash.WashTrailer(truck);
Console.WriteLine("========================================");
gasPump.PumpGas(car);
Console.WriteLine("========================================");
repairService.CheckVehicle(car);
repairService.FixVehicle(car);
Console.WriteLine("========================================");
carCenter.CheckVehicle(car);
carCenter.FixVehicle(car);
carCenter.FixVehicle(truck);
carCenter.PumpGas(car);
carCenter.PumpGas(truck);
carCenter.WashCar(car);
carCenter.WashTrailer(truck);
Console.WriteLine("========================================");