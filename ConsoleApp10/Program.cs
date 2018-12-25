using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int a, b, c;
            Console.WriteLine("Введите первое число");
            //Можно выводи число вот так 
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            //Ну а можно и твоим методом
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            //Ну или быть извращенцем
            int.TryParse(Console.ReadLine(), out c);
            program.View(a,b,c);
        }
        public void View(int a,int b,int c) {
            int d = a + b + c;
            for (int i = 0; i < d; i++) {
                Console.WriteLine("HELLO, FUCKING WORLD");
            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
