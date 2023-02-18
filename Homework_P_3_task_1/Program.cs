using System.IO;

namespace Homework_P_3_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating file...");
            var file = new FileInfo("Text.txt");

            StreamWriter writer = file.CreateText();
            writer.WriteLine("Some information");
            writer.Close();

            Console.WriteLine($"{file.Name} was created");

            Console.WriteLine($"{file.Name} contains: ");
            StreamReader reader = file.OpenText();
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}