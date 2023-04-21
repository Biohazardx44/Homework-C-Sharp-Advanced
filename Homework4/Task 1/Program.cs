using Task_1.Entities;

List<Person> peopleList = Database.People;
List<Person> filteredList = new List<Person>();
List<Person> sortedList = new List<Person>();

Console.WriteLine("All people starting with 'R', ordered by Age - (DESCENDING ORDER):");

sortedList = peopleList.Where(person => person.FirstName.StartsWith("R"))
                       .OrderByDescending(person => person.Age)
                       .ToList();

foreach (Person person in sortedList)
{
    Console.WriteLine(person.FirstName);
}

Console.WriteLine("\nAll brown dogs older than 3 years, ordered by Age - (ASCENDING ORDER):");

List<Dog> brownDogs = new List<Dog>();
List<Dog> dogList = Database.Dogs;

List<Dog> sortedBrownDogs = dogList.Where(dog => dog.Color == "Brown" && dog.Age > 3)
                                   .OrderBy(dog => dog.Age)
                                   .ToList();

foreach (Dog dog in sortedBrownDogs)
{
    Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}");
}

Console.WriteLine("\nAll people with more than 2 dogs, ordered by Name - (DESCENDING ORDER):");
List<Person> peopleWithMoreThanTwoDogs = new List<Person>();

List<Person> sortedPeopleWithMoreThanTwoDogs = peopleList.Where(person => person.Dogs.Count > 2)
                                                         .OrderByDescending(person => person.FirstName)
                                                         .ToList();

foreach (Person person in sortedPeopleWithMoreThanTwoDogs)
{
    Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Number of Dogs: {person.Dogs.Count}");
}

Console.WriteLine("\nAll of Freddy's dogs older than 1 year:");
List<Dog> freddysDogs = peopleList.Where(p => p.FirstName == "Freddy")
                                  .SelectMany(p => p.Dogs)
                                  .Where(d => d.Age > 1)
                                  .ToList();

foreach (Dog dog in freddysDogs)
{
    Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}");
}

Dog? nathensFirstDog = peopleList.Where(p => p.FirstName == "Nathen")
                                 .SelectMany(p => p.Dogs)
                                 .FirstOrDefault();

if (nathensFirstDog != null)
{
    Console.WriteLine($"\nNathen's first dog:\nName: {nathensFirstDog.Name}, Age: {nathensFirstDog.Age}");
}
else
{
    Console.WriteLine("\nNathen does not have any dogs.");
}

Console.WriteLine("\nAll white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - (ASCENDING ORDER):");
List<string> whiteDogsNames = peopleList.Where(p => new[] { "Cristofer", "Freddy", "Erin", "Amelia" }.Contains(p.FirstName))
                                        .SelectMany(p => p.Dogs)
                                        .Where(d => d.Color == "White")
                                        .OrderBy(d => d.Name)
                                        .Select(d => d.Name)
                                        .ToList();

foreach (string name in whiteDogsNames)
{
    Console.WriteLine(name);
}