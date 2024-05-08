using System;

namespace demo
{
    class piramit
    {
        static void Main(string[] args)
        {

            Console.Write("Piramitin basamak değerini giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                for (int k = i; k <= 2 * i - 1; k++)
                {
                    Console.Write(k);
                }
                for (int l = 2 * i - 2; l >= i; l--)
                {
                    Console.Write(l);
                }

                Console.WriteLine();
            }

        }
    }
}
