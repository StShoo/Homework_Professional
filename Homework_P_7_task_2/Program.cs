using System.Reflection;
using System.Text;

namespace Homework_P_7_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyClass instance = new MyClass();

            ClassAttributs();
            ListMethods(instance);
            ListFields(instance);
        }

        static void ClassAttributs()
        {
            Console.WriteLine(new string('_', 30) + "\n");
            Type t = typeof(MyClass);

            object[] attributes = t.GetCustomAttributes(false);
            foreach (MyAttribute attribute in attributes) 
            {
                Console.WriteLine($"Name: {attribute.Name}, Num: {attribute.Num}");
            }
        }

        // Відображення методів MyClass.
        static void ListMethods(MyClass cl)
        {
            Console.WriteLine(new string('_', 30) + " Методи класу MyClass" + "\n");

            Type t = cl.GetType();
            MethodInfo[] mi = t.GetMethods(
                BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic
                    | BindingFlags.DeclaredOnly);

            foreach (MethodInfo m in mi)
            {
                Console.WriteLine($"Метод: {m.Name}");
                object[] attributes = m.GetCustomAttributes(typeof(MyAttribute), false);
                foreach (MyAttribute attribute in attributes)
                {
                    Console.WriteLine($"Його атрибут з параметрами: Name - {attribute.Name}, Num - {attribute.Num}");
                }
            }
                
        }

        // Відображення полів MyClass.
        static void ListFields(MyClass cl)
        {
            Console.WriteLine(new string('_', 30) + " Поля класу MyClass" + "\n");

            Type t = cl.GetType();
            FieldInfo[] fi =
                t.GetFields(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);

            foreach (FieldInfo f in fi)
            {
                Console.WriteLine($"Field: {f.Name}");
                object[] attributes = f.GetCustomAttributes(typeof(MyAttribute), false);
                foreach (MyAttribute attribute in attributes)
                {
                    Console.WriteLine($"Його атрибут з параметрами: Name - {attribute.Name}, Num - {attribute.Num}");
                }
            }
        }
    }


    [My("MyClass Attribute", Num = 1)]
    [My("MyClass Attribute", Num = 2)]
    class MyClass
    {
        [My("Myint field", Num = 1)]
        [My("Myint field", Num = 2)]
        public int myint;
        [My("Mystring field", Num = 1)]
        private string mystring = "Hello";


        // Конструктори
        [My("MyConstructor", Num = 1)]
        public MyClass() { }
        [My("MyConstructor", Num = 2)]
        public MyClass(int i)
        {
            this.myint = i;
        }

        // Методи
        [My("MyMethodA", Num = 1)]
        public void MethodA() { }
        [My("MyMethodB", Num = 1)]
        [My("MyMethodB", Num = 2)]
        public void MethodB() { }
    }
}