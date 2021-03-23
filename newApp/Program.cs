using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя:");
            string s = Console.ReadLine();
            Console.WriteLine("Введено:" + s);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.Read();
            Console.Clear();
        }
    }
}
