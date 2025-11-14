
namespace Sem_3_4_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathExtensions.StandardDeviation([1, 2, 3]));
            int x = 1;
            int y = MathExtensions.TryCalculateCircle(x);
            Console.WriteLine($"x = {x}\n y = {y}");
        }
    }
}
