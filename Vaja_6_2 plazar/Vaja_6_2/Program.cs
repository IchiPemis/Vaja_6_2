using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    class kvader
    {
        private double a;
        private double b;

        public kvader()
        {
            a = 1;
            b = 1;
        }
        public kvader(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void nastavi(double a, double b) 
        {
            this.a = a;
            this.b = b;
        }
        public double plošćina()
        {
            double c = 0;
            return c = a * b;
        }
        public double obseg()
        {
            double c = 0;
            return c = (a + b) * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            kvader k1 = new kvader(3, 3);
            kvader k2 = new kvader(6, 4);
            Console.WriteLine(k1.plošćina());
            Console.WriteLine(k2.plošćina());
        }
    }
}
