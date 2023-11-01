using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    internal class Pyramid
    {
        private double h;
        private double S;
        private double n;
        private double V;
        private double r;
        private double P;
        private int v;
        private double a;
        private double A;

       
        public int Vibor()
        {
            Console.WriteLine("Какую фигуру будем рассматривать:\n1 - Конус\n2 - n-угольная пирамида");
            int b = int.Parse(Console.ReadLine());
            v = b;
            if (b == 1) 
            {
                Console.WriteLine("Введите высоту");
                this.h = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите радиус");
                this.r = double.Parse(Console.ReadLine());
            }
            if (b == 2)
            {
                Console.WriteLine("Введите высоту");
                this.h = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество сторон");
                this.n = double.Parse(Console.ReadLine());
                Console.WriteLine("Введие длину основания");
                this.a = double.Parse(Console.ReadLine());
            }
            this.A = a / (double)(2 * Math.Tan(Math.PI / n));
            return b;
        }
        public void Out()
        {
            Console.WriteLine("Введите количествво сторон: ");
            this.n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту: ");
            this.h = int.Parse(Console.ReadLine());
        }
        public void PloshadKonus()
        {
            S = (double)Math.PI * r * (double)Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2)) + (double)Math.PI * (double)Math.Pow(r, 2);
        }
        public void PloshadPiramida()
        {
            S = (double)((a * A * n) / 2) + (double)((a * n * Math.Sqrt(Math.Pow(h, 2) + Math.Pow(A, 2))) / 2);
        }
        public void PerimKonus()
        {
            P = (double)(Math.PI * 2 * r);

        }
        public void PerimPiramida() 
        {
            P = (a * n) + ((double)(Math.Sqrt(Math.Pow(h, 2) + Math.Pow(A, 2))) * n);
        }
        public void VKonus()
        {
            V = (double)(Math.PI * Math.Pow(r, 2) * h) / 3;
        }
        public void VPiramida()
        {
            V = (double)(n * h * Math.Pow(a, 2)) / (double)(12 * Math.Tan(Math.PI / n));
        }
        public void Vivod()
        {
            if (v == 1)
            {
                Console.WriteLine("Площадь конуса равна: " + S);
                Console.WriteLine("Периметр конуса равен: " + P);
                Console.WriteLine("Объем конуса равен: " + V);
            }
            else
            {
                Console.WriteLine("Площадь пирамиды равна: " + S);
                Console.WriteLine("Периметр пирамиды равен: " + P);
                Console.WriteLine("Объем пирамиды равен: " + V);
            }
        }
    }
}
