using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
        class Rectangle
    {
        private int a;
        private int b;
        private int S;
        private int P;
        public void Out()
        {
            Console.WriteLine("Введите сторону a:");
            this.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b:");
            this.b = int.Parse(Console.ReadLine());
        }
        public void Perimetr()
        {
            P = (a + b) * 2; 
        }
        public void Ploschad()
        {
            S = a * b;
        }
        public void Vivod()
        {
            Console.WriteLine($"Периметр прямогольника равен: {P}\nПлощадь прямоугольика равна: {S}");
            Console.WriteLine(" ");
        }
    }
}
