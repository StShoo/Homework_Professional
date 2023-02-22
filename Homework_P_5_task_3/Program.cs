using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Homework_P_5_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var configuration = new ConfigurationBuilder()
                .AddJsonFile("userSettings.json")
                .Build();*/

            string json = File.ReadAllText("userSettings.json");

            JObject rss = JObject.Parse(json);
            JObject settings = (JObject)rss["Settings"];

            Console.WriteLine("Change color for user to Red/Green?");
            string answer = Console.ReadLine();

            if (answer.Equals("Red"))
            {
                settings["ConsoleColor"] = "Red";
            } else if (answer.Equals("Green"))
            {
                settings["ConsoleColor"] = "Green";
            }

            using (StreamWriter settingsFile = File.CreateText("userSettings.json"))
            {
                JsonSerializer serializer= new JsonSerializer();
                serializer.Serialize(settingsFile, rss);
            }
        }
    }
}