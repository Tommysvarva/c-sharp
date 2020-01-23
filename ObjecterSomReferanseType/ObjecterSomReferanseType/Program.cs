
using System;

namespace ObjecterSomReferanseType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            DemoSideEffects();

        }

        private static void DemoSideEffects()
        {
            var box = new Box() { Width = 20, Heigth = 30 };
            int i = 7;
            DoSomething(box, i);
        }

        private static void DoSomething(Box box, int i)
        {
            
        }

        private static void DemoString()
        {
            string a = "A";
            string b = "A";
        }
        private static void Demo1()
        {
            var a = new Box()
            {
                Width = 20,
                Heigth = 30
            };

            var b = new Box()
            {
                Width = 5,
                Heigth = 7
            };
        }
        private static void Demo2()
        {


            var a = new Box() { Width = 20, Heigth = 30 };
            var b = new Box() { Width = 20, Heigth = 7 };

            if (a.Width == b.Width) System.Console.WriteLine("a og b er like");
            else System.Console.WriteLine("ikke like");
        }
    }
}
