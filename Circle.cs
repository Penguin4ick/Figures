using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    class Circle
    {
        private double S;
        private double P;
        private double r;
        public void Out()
        {
            Console.WriteLine("Введите радиус окружности: ");
            this.r = double.Parse(Console.ReadLine());
        }
        public void Ploschad()
        {
            S = Math.PI*Math.Pow(r,2);
        }
        public void Perimetr()
        {
            P = 2 * Math.PI * r;
        }
        public void Vivod()
        {
            Console.WriteLine($"Периметр круга равен: {P}\nПлощадь круга равна: {S}");
            Console.WriteLine(" ");
        }
    }
}
