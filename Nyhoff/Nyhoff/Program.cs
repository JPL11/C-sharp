using System;

namespace Nyhoff
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 2;
            {
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine(number);

                    number *= 10;
                }
            }
        }
    }
}
