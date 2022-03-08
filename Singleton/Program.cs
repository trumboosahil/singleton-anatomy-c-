using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(sum));
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
           
        }
        static void sum()
        {
            //In case of local variable
            //PriceCalculator priceCalculator = PriceCalculator.Instance;
            //Console.WriteLine("Hello World!");
            //int total = priceCalculator.CalculatePrice(100, 1,10);
            //Console.WriteLine(total.ToString());

            //In case of share variable
            PriceCalculator priceCalculator = PriceCalculator.Instance;
            int totalShare = priceCalculator.CalculatePriceShare(100, 1, 10);
            Console.WriteLine(totalShare.ToString());
            Console.ReadLine();
        }

    }
}
