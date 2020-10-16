using System;

namespace Solo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sus, kol, ots;
            try
            {
                Console.WriteLine("Сколько нужно пиромид - ");
                sus = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                sus = 10000;
            }
            try
            {
                
                Console.WriteLine("Высота пирамид - ");
                kol = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                kol = 230;
            }
            try
            {
                Console.WriteLine("Отступ пирамид - ");
                ots = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                ots = 0;
            }
            Console.Clear();

            int count = 1;

            for (int i = 0; i<sus;i++)
            {
                for (int q = 0; q<kol-11;q++)
                {
                    Console.Write("#");
                }
                kol--;
                for (int q = 0;q<10;q++)
                {
                    Console.Write(" ");
                }
                for (int q = 0;q<count;q++)
                {
                    Console.Write("#");
                }
                count++;
            }
        }
    }
}
