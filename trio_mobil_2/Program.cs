using System;

namespace trio_mobil_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi=0, sayi1=0, sayi2=0;
            int bolunenlerT = 0;

            Console.WriteLine("Başlangıç");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bölen");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi; i <= sayi1; i++)
            {
                if (i % sayi2 == 0)
                {
                    bolunenlerT += i;
                }
                else
                {
                }
            }
            Console.WriteLine(bolunenlerT);
            Console.ReadLine();
        }
    }
}
