namespace Homework_P_1_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter collection size: ");
            int len = int.Parse(Console.ReadLine());
            var human = new HumanCollection(len);
            int i = 0;

            foreach (var item in human)
            {
                human[i] = new HumanData(Console.ReadLine(), int.Parse(Console.ReadLine()));
                i++;
            }
            i = 0;

            Console.WriteLine("Print all:");
            foreach (HumanData item in human)
            {
                Console.WriteLine($"Name: {item.HumanName}; Age: {item.HumanAge}");
            }

            Console.WriteLine("Enter name to delete: ");
            string tempName = Console.ReadLine();

            foreach (HumanData item in human)
            {
                if (item.HumanName == tempName)
                {
                    item.HumanName = null;
                    item.HumanAge = 0;
                    Console.WriteLine($"{tempName} was deleted");
                    i++;
                }
            }

            Console.WriteLine("Enter name to find: ");
            tempName = Console.ReadLine();
            bool flagToPrint = false;

            foreach (HumanData item in human)
            {
                if (item.HumanName == tempName || item == null)
                {
                    flagToPrint = true;
                    Console.WriteLine("Relativs: ");
                    continue;
                }
                if (flagToPrint)
                {
                    Console.WriteLine($"Name: {item.HumanName}; Age: {item.HumanAge}");
                }
            }

            Console.WriteLine("Enter age to find all people: ");
            int age = int.Parse(Console.ReadLine());

            foreach (HumanData item in human)
            {
                if (item.HumanAge == age)
                {
                    Console.WriteLine($"Name: {item.HumanName}; Age: {item.HumanAge}");
                }
            }

            Console.WriteLine("Print all:");
            foreach (HumanData item in human)
            {
                Console.WriteLine($"Name: {item.HumanName}; Age: {item.HumanAge}");
            }
        }
    }
}