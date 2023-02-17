namespace Homework_P_1_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5 };

            var collection = new ArrayToCollection(ints);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}