using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_P_6_task_2
{
    interface IInterface
    {
        public void MethodA() { }
        public void MethodB() { }
    }
    internal class MyClass: IInterface
    {
        // Поля
        public int myint;
        private string mystring = "Hello";


        // Конструктори
        public MyClass() { }
        public MyClass(int i)
        {
            this.myint = i;
        }

        // Властивості
        public int myProp
        {
            get { return myint; }
            set { myint = value; }
        }

        private string MyString
        {
            get { return mystring; }
        }

        // Методи
        public void MethodA() { }
        public void MethodB() { }

        private void MethodC(string str, string str2)
        {
            Console.WriteLine(str + str2);
        }

        public void myMethod(int p1, string p2) { }
    }
}
