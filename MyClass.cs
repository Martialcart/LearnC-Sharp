using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSProject
{
    class MyClass
    {
        string name;
        int age;
        public MyClass(string navn, int alder)
        {
            name = navn;
            age = alder;
        }

        public void print()
        {
            Console.WriteLine("navn:" + name + " alder:" + age);
        }
    }
}
