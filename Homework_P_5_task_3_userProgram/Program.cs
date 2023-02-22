using Microsoft.Extensions.Configuration;

namespace Homework_P_5_task_3_userProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("C:\\Users\\lumen\\Documents\\Projects\\Lessons_C#_Professional\\Homework_Professional\\Homework_P_5_task_3\\bin\\Debug\\net6.0\\userSettings.json")
                .Build();

            var consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), configuration["Settings:ConsoleColor"]);
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("User program");
        }
    }
}