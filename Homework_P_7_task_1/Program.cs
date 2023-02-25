#define TRIAL
//#define PREMIUM

using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Homework_P_7_task_1
{
    
    class MyClass
    {
        [Obsolete("We do not need this function anymore", false)]
        public void SayHallo()
        {
            Console.WriteLine("Hallo");
        }
        [Obsolete("Do not use it!", true)]
        public void SayBye()
        {
            Console.WriteLine("Bye");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.SayHallo();
            myClass.SayBye();
        }
    }
}