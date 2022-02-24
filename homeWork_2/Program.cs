using System;

namespace InheritanceAndPolymorphism
{

    public abstract class ClassA
    {
        public int a;
        public void XXX() { }
        abstract public void YYY();
    }

    public class ClassB : ClassA
    {
        public override int YYY() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Перегрузка методов: метод идентифицируется не только по имени,но и по его параметрам.
            /*var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);*/

            //В класса А нет метода который мы вызываем.
            /*ClassA a = new ClassA();
            a.Display1();*/

            //мы не можем создать экземпляр абстрактного класса с помощью ключевого слова new.
            /*ClassA classA = new ClassA();*/

            //реализуем абстрактный метод класса-родителя с помощью ключевого слова override.
            /*ClassB classb = new ClassB();*/

        }



    }


}
