namespace SEM_1_2_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            Console.WriteLine("Введите длины треугольника: ");
            do
            {
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Некорректные данные");
                }
            } while ((a > b + c) || (b > a + c) || (c > a + b));
            double per = (a + b + c) / 2;
            double area = Math.Sqrt(per * (per - a) * (per - b) * (per - c));
            Console.WriteLine("Площадь треугольника с данными сторонами: ");
            Console.WriteLine(area);
        }
    }
}
