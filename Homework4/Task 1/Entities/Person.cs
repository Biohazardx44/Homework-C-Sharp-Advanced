namespace Task_1.Entities
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; } = new List<Dog>();

        public Person(string firstName, string lastName, int age, List<Dog> dogs)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Dogs = dogs;
        }
    }
}