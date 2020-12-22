using System;

namespace FirstCSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("the diameter is" + diameter(5));

            MyClass mann = new MyClass("Ringo", 42);
            MyClass dame = new MyClass("Trude", 50);
            mann.print();
            dame.print();
        }
        static double diameter(double circle)
        {
            return circle / 3.14;
        }

    }
}
