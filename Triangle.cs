using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    internal class Triangle
    {
        private int a;
        private int b;
        private int c;
        private double S;
        private double P;
        private string three;
        public void In()
        {
            Console.WriteLine("Введите сторону a: ");
            this.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            this.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c: ");
            this.c = int.Parse(Console.ReadLine());
            if (this.c < this.a+this.b) { Console.WriteLine("Не может существовать такого треугольника, но я все же рассчитаю все для Вас"); }
        }
        public void Perimetr ()
        {
            this.P = this.a + this.b + this.c;
        }
        public void Ploshad()
        {
           double polu = (double)(a + b + c) / 2;
            this.S =(double)Math.Sqrt(polu*(polu-this.a)*(polu - this.b)*(polu-this.c));
        }
        public void vid()
        {
            if (a == b && b == c && a == c)
            {
                this.three = "равносторонний";
            }
            if (a == b || b == c || a == c)
            {
                this.three = "равнобедренный";
            }
            if (a != c && a != b && b != c)
            {
                this.three = "разносторонний";
            }
            if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                this.three = "прямоугольный";   
            }
            if (Math.Pow(c, 2) < (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                this.three = "остроугольный";
            }
            if (Math.Pow(c, 2) > (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                this.three = "тупоугольный";  
            }

        }
        public void Vivod()
        {
            Console.WriteLine($"Периметр прямогольника равен: {P}\nПлощадь прямоугольика равна: {S}");
            Console.WriteLine(" ");
            Console.WriteLine($"Ваш треугольник {three}\n");
        }

    }    
}

