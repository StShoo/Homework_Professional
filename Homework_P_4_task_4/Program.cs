using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace Homework_P_4_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string loginPattern = @"^[a-z]+$";
            const string passwordPattern = @"^[a-z0-9_-]+$";
            Regex regex = new Regex(loginPattern, RegexOptions.IgnoreCase);

            while(true)
            {
                Console.WriteLine("Enter login: ");
                string inputString = Console.ReadLine();

                if (!regex.IsMatch(inputString))
                {
                    Console.WriteLine("Login is not valid!");
                    continue;
                }

                Console.WriteLine("Enter password: ");
                inputString = Console.ReadLine();
                regex = new Regex(passwordPattern, RegexOptions.IgnoreCase);

                if(regex.IsMatch(inputString))
                {
                    Console.WriteLine("Autorisation is comlete, welldone!");
                    break;
                }
                else
                {
                    Console.WriteLine("Password is not valid!");
                }
            }
        }
    }
}