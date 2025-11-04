namespace Sem_01._11._2025_ex2
{
    public class MathOperationException : Exception
    {
        public MathOperationException(string message) : base(message) { }
    }
    public class DivisionByZeroException : MathOperationException
    {
        public DivisionByZeroException(string message) : base(message) { }
    }
    public class NegativeRadicalException : MathOperationException
    {
        public NegativeRadicalException(string message) : base(message) { }
    }

    // Статический класс Calculator с методами
    public static class Calculator
    {
        public static int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivisionByZeroException("Деление на ноль недопустимо.");

            return a / b;
        }

        public static double SquareRoot(int a)
        {
            if (a < 0)
                throw new NegativeRadicalException("Нельзя извлекать квадратный корень из отрицательного числа.");

            return Math.Sqrt(a);
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Вызовы методов, которые могут вызвать исключения
                Console.WriteLine(Calculator.Divide(10, 0)); // Деление на 0 → DivisionByZeroException
            }
            catch (DivisionByZeroException ex)
            {
                Console.WriteLine($"Обработка DivisionByZeroException: {ex.Message}");
            }
            catch (NegativeRadicalException ex)
            {
                Console.WriteLine($"Обработка NegativeRadicalException: {ex.Message}");
            }
            catch (MathOperationException ex) when (ex.GetType() != typeof(DivisionByZeroException) && ex.GetType() != typeof(NegativeRadicalException))
            {
                Console.WriteLine($"Обработка другого MathOperationException: {ex.GetType().Name} — {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка");
            }

            try
            {
                Console.WriteLine(Calculator.SquareRoot(-4)); // Корень из отрицательного → NegativeRadicalException
            }
            catch (DivisionByZeroException ex)
            {
                Console.WriteLine($"Обработка DivisionByZeroException: {ex.Message}");
            }
            catch (NegativeRadicalException ex)
            {
                Console.WriteLine($"Обработка NegativeRadicalException: {ex.Message}");
            }
            catch (MathOperationException ex) when (ex.GetType() != typeof(DivisionByZeroException) && ex.GetType() != typeof(NegativeRadicalException))
            {
                Console.WriteLine($"Обработка другого MathOperationException: {ex.GetType().Name} — {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка");
            }
        }
    }
}
