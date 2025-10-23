using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    class Pit_Trikotnik
    {
        private double a;
        private double b;
        private double c;

        public Pit_Trikotnik()
        {
            a = 3;
            b = 4;
            c = 5;
        }

        public Pit_Trikotnik(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.c = Math.Sqrt(a * a + b * b);
        }
        public Pit_Trikotnik(Pit_Trikotnik drugo)
        {
            a = drugo.a;
            b = drugo.b;
            c = drugo.c;
        }

        public void Nastavi(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Ploscina()
        {
            double visNaC = a * b / c;
            double ploscina = c * visNaC / 2;
            Console.WriteLine($"Ploščina trikotnika je {ploscina}");
        }

        public void Obseg()
        {
            double obseg = a + b + c;
            Console.WriteLine($"Obseg trikotnika je {obseg}");
        }
    }
}

