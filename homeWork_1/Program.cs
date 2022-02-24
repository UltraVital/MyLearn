using System;

namespace homeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vitaliy";
            int age = 29;
            float height = 1.83f;
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Рост: {height}.");

            short minDay = 1440;
            sbyte hoursDay = 24;
            bool isDay = true;
            Console.WriteLine($"Минут: {minDay}, Часов: {hoursDay}, Утверждение: {isDay}.");

            char coin = '$';
            double coursesCoin = 2.54;
            long youSalary = 150000;
            Console.WriteLine($"Валюта: {coin}, Курс: {coursesCoin}, Зарплата: {youSalary}.");

            object device = "HDD";
            byte sizeTb = 1;
            ulong sizeByte = 1099511627776;
            Console.WriteLine($"Устройство: {device}, Тэрабайт: {sizeTb}, Байт: {sizeByte}.");

            dynamic power = 12.459;
            uint years = 5;
            decimal total = 747540m;
            Console.WriteLine($"Мощность: {power}, Года: {years}, Сумма: {total}.");

            int a = 10;
            int b = a * 2;
            int c = a / 5;
            int d = a + 2;
            int e = a - 5;
            int f = 20;
            f++;
            int g = 20;
            g--;
            Console.WriteLine("Умножение:" + b);
            Console.WriteLine("Деление:" + c);
            Console.WriteLine("Сложение:" + d);
            Console.WriteLine("Вычитание:" + e);
            Console.WriteLine("Инкремент:" + f);
            Console.WriteLine("Декремент:" + g);

            double x = 10;
            double z = x % 4;
            Console.WriteLine("Остаток:" + z);

            int Num1 = 10;
            int Num2 = 50;
            bool A = Num1 > Num2;
            bool B = Num1 < Num2;
            bool result1 = !A;
            bool result2 = A & B;
            bool result3 = A ^ B;
            bool result4 = A | B;
            bool result5 = A && B;
            bool result6 = A || B;
            bool result7 = A == B;
            bool result8 = A != B;
            Console.WriteLine("Логическое отрицинае: " + result1);
            Console.WriteLine("Логическое И: " + result2);
            Console.WriteLine("Исключение ИЛИ: " + result3);
            Console.WriteLine("Логическое ИЛИ: " + result4);
            Console.WriteLine("КЗ: " + result5);
            Console.WriteLine("Условный ИЛИ: " + result6);
            Console.WriteLine("Равенство: " + result7);
            Console.WriteLine("Неравенство: " + result8);

            int i = 27;
            Console.WriteLine(i is System.IFormattable);

            string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";
            Console.WriteLine(GetWeatherDisplay(15)); 
            Console.WriteLine(GetWeatherDisplay(27));

            string str1 = @"Hello ""Friend"", how do you do?";
            Console.WriteLine(str1);
        }
    }
}
