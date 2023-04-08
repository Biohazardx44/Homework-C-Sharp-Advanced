namespace Task_1.Extensions
{
    public static class Extension
    {
        public static void WriteInColor(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}