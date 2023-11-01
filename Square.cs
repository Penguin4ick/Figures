using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    class Square
    {
        private int a;
        private int P;
        private int S;
        public void Out()
        {
            Console.WriteLine("Введите сторону квадрата: ");
            this.a = int.Parse(Console.ReadLine());
        }
        public void Perimetr()
        {
            P = 4*a;
        }
        public void Ploschad()
        {
            S = a*a;
        }
        public void Vivod()
        {
            Console.WriteLine($"Периметр прямогольника равен: {P}\nПлощадь прямоугольика равна: {S}");
            Console.WriteLine(" ");
        }
    }
}
