using System;

namespace Q1Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            /*
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            Console.WriteLine($"Привет, %{name}%, сегодня %{DateTime.Now}%");
            */
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}"); //дата с временем
            Console.WriteLine("Привет, " + name + ", " + "сегодня " + DateTime.Now.ToShortDateString()); //только дата без времени
            Console.WriteLine($"Привет, %{name}%, сегодня %{DateTime.Now.ToShortDateString()}%"); //строка с %
            //Console.WriteLine($"Привет {name}, сегодня 0{day}.0{month}.{year}");
        }
    }
}
