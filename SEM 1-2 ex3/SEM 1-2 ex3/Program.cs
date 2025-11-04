using System;

namespace SEM_1_2_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            char a = ' ';
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
                 
                /*
                Console.WriteLine(a.GetType());
                Console.WriteLine(a);
                */

                //Проверка символа
                if (char.IsDigit(a)) f = 100;
                else if (char.IsLetter(a) && !(char.IsUpper(a))) f = 200;
                else if (char.IsUpper(a)) f = 300;
                else f = 400;

                Console.WriteLine(f);

                if (a == ' ') break;
            }
        }
    }
}
