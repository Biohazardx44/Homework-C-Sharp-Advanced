using Newtonsoft.Json;
using Task1.Entities;

string folderPath = "../../../OurData";
string filePath = folderPath + "/ourFile.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

void WriteToJson(string json)
{
    using (StreamWriter sw = new StreamWriter(filePath, true))
    {
        sw.WriteLine(json);
    }
}

void ReadFromJson()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}

void PrintFromJson()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            List<Dog> dogs = JsonConvert.DeserializeObject<List<Dog>>(line);

            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
            }
        }
    }
}

Console.WriteLine("Enter dog name:");
string name = Console.ReadLine();

Console.WriteLine("Enter dog age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter dog color:");
string color = Console.ReadLine();

List<Dog> dogList = new List<Dog>();

Dog newDog = new Dog
{
    Name = name,
    Age = age,
    Color = color
};

dogList.Add(newDog);

string Serialized = JsonConvert.SerializeObject(dogList);

WriteToJson(Serialized);
Console.WriteLine("\nJSON FILE:");
ReadFromJson();
Console.WriteLine("All Dogs:");
PrintFromJson();