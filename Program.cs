using System.Drawing;
namespace Figuri
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать! Тут мы за вас посчитаем периметр и площадь фигуры");
            var key = new ConsoleKeyInfo();
            while (key.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1 - Прямоугольник");
                Console.WriteLine("2 - Треугольник");
                Console.WriteLine("3 - Круг");
                Console.WriteLine("4 - Квадрат");
                Console.WriteLine("5 - Пирамида");
                Console.WriteLine("Для выхода нажмите Escape");
                key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {                        
                            Rectangle rec = new Rectangle();
                            rec.Out();
                            rec.Perimetr();
                            rec.Ploschad();
                            rec.Vivod();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Triangle trg = new Triangle();
                            trg.In();
                            trg.Perimetr();
                            trg.Ploshad();
                            trg.vid();
                            trg.Vivod();                           
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Circle cr = new Circle();
                            cr.Out();
                            cr.Perimetr();
                            cr.Ploschad();
                            cr.Vivod();
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            Square sq = new Square();
                            sq.Out();
                            sq.Perimetr();
                            sq.Ploschad();
                            sq.Vivod();
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            int v;
                            Pyramid py = new Pyramid();
                            v = py.Vibor(); 
                            if (v == 1 ) //конус
                            {
                                py.PloshadKonus();
                                py.PerimKonus();
                                py.VKonus();
                                py.Vivod();
                            }
                            if (v == 2) //пирамида
                            {
                                py.PloshadPiramida();
                                py.PerimPiramida();
                                py.VPiramida();
                                py.Vivod();
                            }
                            break;
                        
                        }
                }
            }
        }
    }
}