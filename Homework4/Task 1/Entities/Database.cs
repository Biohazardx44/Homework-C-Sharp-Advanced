namespace Task_1.Entities
{
    public static class Database
    {
        public static List<Person> People { get; set; }
        public static List<Dog> Dogs { get; set; }

        static Database()
        {
            Dogs = new List<Dog>
            {
                new Dog("Jeff", 2, "Red"),
                new Dog("Max", 1, "Brown"),
                new Dog("Bobby", 5, "White"),
                new Dog("Abe", 3, "White"),
                new Dog("Tony",4,"Brown"),
                new Dog("Jim",1,"White"),
                new Dog("Peter",6,"Black"),
                new Dog("Sara",1,"Brown"),
            };

            People = new List<Person>
            {
                new Person("Ricky", "Rock", 30, new List<Dog> { Dogs[0], Dogs[2], Dogs[3], Dogs[6] }),
                new Person("Freddy", "Hutson", 25, new List<Dog> { Dogs[1], Dogs[2], Dogs[4] }),
                new Person("Nathen", "Cruise", 40, new List<Dog> { Dogs[2], Dogs[4] }),
                new Person("Rocky", "Rock", 22, new List<Dog> { Dogs[1], Dogs[5] }),
                new Person("Cristofer", "Keeves", 22, new List<Dog> { Dogs[1], Dogs[6], Dogs[7] }),
                new Person("Erin", "Foster", 22, new List<Dog> { Dogs[0], Dogs[4]}),
                new Person("Amelia", "Heard", 22, new List<Dog> {Dogs[3], Dogs[6]}),
                new Person("Joe", "Jhones", 22, new List<Dog> ())
            };
        }
    }
}