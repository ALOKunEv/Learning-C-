namespace Sem_1_2_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intCount = 0;
            int doubleCount = 0;
            int nonNumericCount = 0;
            while (true) {
                Console.Write("Введите число (0 для завершения): ");
                string input = Console.ReadLine();

                // Проверка на завершение
                if (input == "0")
                {
                    // Но нужно проверить, что это целое число 0
                    // Поскольку input "0" точно, и int.TryParse для "0" вернет 0, и это будет корректным
                    break;
                }

                // Проверка на int
                if (int.TryParse(input, out int n))
                {
                    intCount++;
                }
                else if (double.TryParse(input, out double d))
                {
                    doubleCount++;
                }
                else
                {
                    nonNumericCount++;
                }
            }
            // Вывод результатов
            Console.WriteLine($"Количество целых чисел: {intCount}");
            Console.WriteLine($"Количество вещественных чисел: {doubleCount}");
            Console.WriteLine($"Количество нечисловых значений: {nonNumericCount}");
        }
    }
}
