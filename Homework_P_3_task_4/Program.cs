using System.IO;

namespace Homework_P_3_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++) 
            {
                string filename = "Folder_" + i;
                var file = new FileInfo(filename);
                FileStream stream = file.Create();
                stream.Close();
            }

            Console.WriteLine("Files created");
            Console.ReadKey();

            for (int i = 0; i < 100; i++)
            {
                string filename = "Folder_" + i;
                var file = new FileInfo(filename);
                file.Delete();
            }
        }
    }
}