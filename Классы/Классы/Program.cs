using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Классы
{

    internal class Program
    {
        //Задание1
        class Tel
        {
            public int day;
            public double time;
            public double price;
            public double Count()
            {
                if (day == 6 || day == 7)
                    return time * price * 0.9;
                else return time * price;
            }
        }
        static void Task1()
        {
            var t = new Tel();
            t.day = 5;
            t.price = 10;
            t.time = 6;
            Console.WriteLine(t.Count());
        }

        //Задание2
        class Tel2
        {
            private int day=0;
            public double time;
            public double price;
            public int Day
            {
                get => day;
                set
                {
                    if (value > 0 && value < 8) day = value;
                    else Console.WriteLine("Кол-во дней в неделе равно 7");
                }
            }
            public double Count()
            {
                if (day == 6 || day == 7)
                    return time * price * 0.9;
                else return time * price;
            }
        }
        static void Task2()
        {
            var t = new Tel2();
            t.price = 10;
            t.time = 6;
            while (t.Day==0) 
            { 
            Console.WriteLine("Введите день недели");
            t.Day = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Счет");
            Console.WriteLine(t.Count());
            }

        //Задание3
        class Counter
        {
            public delegate void PowDelegate();
            public event PowDelegate Overflow;
            public void Pow()
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(i*i);
                    if (i * i > 25) Overflow();
                }
            }
        }
        class Handler
        {
            public void Warning()
            {
                Console.WriteLine("Квадрат числа больше 25!");
            }
        }
        static void Task3()
        {
            Counter counter = new Counter();
            Handler handler = new Handler();

            counter.Overflow += handler.Warning;

            counter.Pow();
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();

            Console.ReadLine();
            
        }
    }
}
