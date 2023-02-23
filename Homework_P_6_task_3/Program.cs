using System.Reflection;
using System.Text;

namespace Homework_P_6_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyClass instance = new MyClass();

            ListVariosStats(instance);
            ListMethods(instance);
            ListFields(instance);
            ListProps(instance);
            ListInterfaces(instance);
            ListConstructors(instance);

            Console.WriteLine(new string('-', 60));

            Type type = instance.GetType();

            MethodInfo methodC = type.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
            methodC.Invoke(instance, new object[] { "Hello", " world!" });

            FieldInfo mystring = type.GetField("mystring", BindingFlags.Instance | BindingFlags.NonPublic);
            mystring.SetValue(instance, "New Value!");
        }

        static void ListVariosStats(MyClass cl)
        {
            Console.WriteLine(new string('_', 30) + "\n");
            Type t = cl.GetType();

            Console.WriteLine($"{nameof(t.FullName)}     {t.FullName}    ", t.FullName);
            Console.WriteLine($"{nameof(t.BaseType)}     {t.BaseType}    ", t.BaseType);
            Console.WriteLine($"{nameof(t.IsAbstract)}   {t.IsAbstract}  ", t.IsAbstract);
            Console.WriteLine($"{nameof(t.IsCOMObject)}  {t.IsCOMObject} ", t.IsCOMObject);
            Console.WriteLine($"{nameof(t.IsSealed)}     {t.IsSealed}     ", t.IsSealed);
            Console.WriteLine($"{nameof(t.IsClass)}      {t.IsClass}     ", t.IsClass);
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
                Console.WriteLine("Метод: {0}", m.Name);
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
                Console.WriteLine("Field: {0}", f.Name);
        }

        // Відображення властивостей MyClass.
        static void ListProps(MyClass cl)
        {
            Console.WriteLine(new string('_', 30) + " Властивості класу" + "\n");

            Type t = cl.GetType();
            PropertyInfo[] pi = t.GetProperties(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);

            foreach (PropertyInfo p in pi)
                Console.WriteLine("Властивість: {0}", p.Name);
        }

        // Відображення інтерфесів, реалізованих MyClass.
        static void ListInterfaces(MyClass cl)
        {
            Console.WriteLine(new string('_', 30) + " Інтерфейси, реалізовані класом MyClass" + "\n");

            Type t = cl.GetType();

            Type[] it = t.GetInterfaces();

            foreach (Type i in it)
                Console.WriteLine("Інтерфейс: {0}", i.Name);
        }

        // Відображення конструкторів MyClass.
        static void ListConstructors(MyClass cl)
        {
            Console.WriteLine(new string('_', 30) + " Конструктори класу MyClass" + "\n");

            Type t = cl.GetType();
            ConstructorInfo[] ci = t.GetConstructors();

            foreach (ConstructorInfo m in ci)
                Console.WriteLine("Constructor: {0}", m.Name);
        }
    }
}