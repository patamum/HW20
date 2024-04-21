namespace Task20_1
{
    internal class Program
    {
        delegate double MyDelegate(double a);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = LenCircle;
            myDelegate += AreaCircle;
            myDelegate += VolBall;
            myDelegate(r);
        }
        static double LenCircle(double r)
        {
            double l = Math.Round(2 * Math.PI * r, 2);
            Console.WriteLine($"Длина окружности {l} м.");
            return l;
        }
        static double AreaCircle(double r)
        {
            double s = Math.Round(Math.PI * r * r, 2);
            Console.WriteLine($"Площадь круга {s} м. кв.");
            return s;
        }
        static double VolBall(double r)
        {
            double v = Math.Round(4/3 * Math.PI * r * r * r, 2);
            Console.WriteLine($"Объем шара {v} м. куб.");
            return v;
        }

    }
}