
namespace Sem_01._11._2025_ex1
{    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    public class BankAccount
    {
        public decimal Balance { get; private set; }
        
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientFundsException($"Недостаточно средств на счете. Запрашиваемая сумма: {amount}, доступно: {Balance}.");

            Balance -= amount;
        }
    }

    class Program
    {
        static void Main()
        {
            var account = new BankAccount(100);
            while (true)
            {
                Console.Write("Введите сумму для снятия: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                {
                    try
                    {
                        account.Withdraw(withdrawAmount);
                        Console.WriteLine($"Операция успешна. Новый баланс: {account.Balance}");
                    }
                    catch (InsufficientFundsException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }

            }
        }
    }
}
