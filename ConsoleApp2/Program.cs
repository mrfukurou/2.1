using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("x=");
                float x = float.Parse(Console.ReadLine());
                Console.Write("y=");
                float y = float.Parse(Console.ReadLine());
                if (x < 0 && x > -15 && y < 0 && y > -15)
                    Console.WriteLine("вне");
                else if (((x == -15 || x == 0) && y <= 0 && y >= (-15)) || ((y == -15 || y == 0) && x <= 0 && x >= (-15)))
                    Console.WriteLine("на границе");
                else Console.WriteLine("внутри");
            }
            catch { Console.WriteLine("Некорректный ввод данных"); }

        }
    }
}
