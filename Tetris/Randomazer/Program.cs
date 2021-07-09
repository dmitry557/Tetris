using System;

namespace Randomazer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           

            for (int i = 0; i < 20; i++)
            {
                int value = random.Next(0, 5);
                Console.WriteLine(value);
            }
        }
    }
}
