using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class PriceCalculator
    {
        private static readonly Lazy<PriceCalculator> lazy = new Lazy<PriceCalculator>(() => new PriceCalculator());
        public static PriceCalculator Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        static int sharedtotal = 0;
        public  int CalculatePrice(int unit, int unitprice,int quantity)
        {
            int total = 0;
            for (int i = 0; i < quantity; i++)
            {
                total += unit * unitprice;
                Thread.Sleep(100);
            }
            return total;
        }

        public  int CalculatePriceShare(int unit, int unitprice,int quantity)
        {
            Console.WriteLine("new");
            for (int i = 0; i < quantity; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine(thread.ManagedThreadId);
                sharedtotal += unit * unitprice;
                Thread.Sleep(200);
            }
            return sharedtotal;
        }
    }
}
