using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class ClassB
    {
        //В класса А нет метода который мы вызываем.
        class ClassA { }
        class ClassB
        {
            public int x = 100;
            public void Display1()
            {
                Console.WriteLine("ClassB Display1");
            }
            public void Display2()
            {
                Console.WriteLine("ClassB Display2");
            }
        }
    }
}
