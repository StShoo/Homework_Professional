namespace Homework_P_2_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> customersAndProd = new Dictionary<string, string>();

            customersAndProd.Add("Andrii", "fish");
            customersAndProd.Add("Mikola", "meat");
            customersAndProd.Add("Denis", "fish");
            customersAndProd.Add("Olga", "meat");
            customersAndProd.Add("Max", "fish");
            customersAndProd.Add("Nika", "fish");

            string categoryToPrint;
            customersAndProd.TryGetValue("Mikola", out categoryToPrint);
            Console.WriteLine(categoryToPrint);

            foreach (var item in customersAndProd)
            {
                if (item.Value == "fish")
                {
                    Console.WriteLine($"Name: {item.Key} Product category: {item.Value}");
                }
            }
        }
    }
}