using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Overload
    {
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload: {a}");
        }

        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload: {a}");
        }

        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine($"DisplayOverload: {a} {b}");
        }

        //Ошибка компиляции! Метод не идентифицируется по возвращенному типу,это не полиморфизм.
        /*public void DisplayOverload() { }
        public int DisplayOverload() { }*/

        //Ошибка компиляции! Модификаторы типа static не являются свойствами, идентифицирующими метод.
        /*static void DisplayOverload(int a) { }
        public void DisplayOverload(int a) { }
        public void DisplayOverload(string a) { }*/

        //Ошибка компиляции! На идентификатор метода оказывают влияние только его имя и параметры.
        //Двух методов с одинаковыми идентификаторами существовать не может.
        /*public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload: {a}");
        }

        private void DisplayOverload(out int a)
        {
            a = 100;
        }

        private void DisplayOverload(ref int a) { }*/

        //Ошибка компиляции! Имена параметров должны быть уникальными.
        //Также не могут быть одинаковыми имя параметра метода и имя переменной, созданной в этомже методе.
        /*public void DisplayOverload(int a, string a) { }
        public void Display(int a) { string a; }*/

        public void Display()
        {
            DisplayOverload(100, "Akhil", "Mittal", "OOP");
            DisplayOverload(200, "Akhil");
            DisplayOverload(300);
        }

        private void DisplayOverload(int a, params string [] parameterArray)
        {
            foreach(string str in parameterArray)
                Console.WriteLine(str + " " + a);
        }

        // В этом варианте C#  не понимает, какой же метод ему вызвать.
        /*public void Display()
        {
            DisplayOverload(100, 200, 300);
            DisplayOverload(200, 100);
            DisplayOverload(200);
        }

        private void DisplayOverload(int a, params int[] paramaterArray)
        {
            foreach (var i in paramaterArray)
                Console.WriteLine(i + " " + a);
        }

        private void DisplayOverload(int a, params string[] paramaterArray)
        {
            foreach (var i in paramaterArray)
                Console.WriteLine(i + " " + a);
        }*/

        //Ошибка компиляции! Массив параметров должен быть одномерным.
        /* private void DisplayOverload(int a, params string [] [] parameterArray)
         {

         }
         private void DisplayOverload(int a, params string[,] parameterArray)
         {

         }*/
        //Ошибка компиляции. cannot convert from string[] to string.
        /*public void Display()
        {
            DisplayOverload(100, "200", "300");
            DisplayOverload(200, "100");
            string[] names = { "Akhil", "Ekta", "Arsh" };
            DisplayOverload(200, names, "Akhil");
        }*/

        //C# формирует новый, временный массив.
        /*public void Display()
        {
            int number = 102;
            DisplayOverload(40, 1000, number, 4000);
            Console.WriteLine(number);
        }
        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }*/

        //Приоритет языка в воборе методов.
        /*public void Display()
        {
            DisplayOverload(200);
            DisplayOverload(200, 300);
            DisplayOverload(200, 300, 500, 600);
        }
        private void DisplayOverload(int x, int y)
        {
            Console.WriteLine("The twoo integers " + x + " " + y);
        }
        private void DisplayOverload(params int[] parameterArray)
        {
            Console.WriteLine("parameterArray");
        }*/



    }
}

