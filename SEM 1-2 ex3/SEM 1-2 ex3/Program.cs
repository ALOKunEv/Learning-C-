namespace SEM_1_2_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            char a = '.';
            while (true)
            {
                Console.WriteLine("Введите значение переменной a:");
                try
                {
                    a = char.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Надо ввести значение типа char");
                }



                if (a == ' ') break;
            }
        }
    }
}
