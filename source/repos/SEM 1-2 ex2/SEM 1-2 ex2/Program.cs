namespace SEM_1_2_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.WriteLine("Введите трехзначное число, которое хотите перевернуть: ");
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException) { Console.WriteLine("Требуется ввести значение типа int"); }
            } while (!((num > 99) && (num < 1000)));

            int rnum = 0;
            while (num != 0)
            {
                rnum = rnum * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Перевернутое число:");
            Console.WriteLine(rnum);
        }
    }
}
