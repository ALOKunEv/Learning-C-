using System.Dynamic;
using System.Reflection;

namespace Sem_3_4_ex1
{
    class Employee
    {
        public const string CompanyName = "Comp";
        public readonly static DateTime CompanyFoundedDate;
        public static int NumberOfEmployees { get; private set; } = 0;
        public int EmployeeId { get; private set; } = 0;
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public void GetEmployeeInfo()
        {
            Console.WriteLine($"Name: {this.Name};\n" +
                $" Id: {this.EmployeeId};\n" +
                $" Salary: {this.BaseSalary}");
        }

        static Employee()
        {
            CompanyFoundedDate = new DateTime(2005, 05, 31);
            Console.WriteLine("Вызван статический конструктор");
            Console.WriteLine(CompanyFoundedDate);
        }
        public Employee(string Name, decimal BaseSalary)
        {
            NumberOfEmployees++;
            this.Name = Name;
            this.BaseSalary = BaseSalary;
            EmployeeId = NumberOfEmployees;
        }

        class Manager : Employee
        {
            public decimal Bonus { get; private set; }
            public Manager(string Name, decimal BaseSalary, decimal Bonus)
                : base(Name, BaseSalary)
            {
                this.Bonus = Bonus;
            }

            public override decimal CalculateSalary()
            {
                return Bonus + BaseSalary;
            }
        }

        public class Developer : Employee
        {
            public int CompletedProjects { get; private set; }
            const decimal ProjectBonus = 100;

            public override decimal CalculateSalary()
            {
                return BaseSalary + ProjectBonus * CompletedProjects;
            }

            public Developer(string Name, decimal BaseSalary, int CompletedProjects)
                : base(Name, BaseSalary)
            {
                this.CompletedProjects = CompletedProjects;
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(Employee.CompanyName);
                Employee[] EmpList = new Employee[]
                {
                    new Employee("Хуй Джобс", 2000),
                    new Manager("Полина Андреевна", 2000, 400),
                    new Developer("Стив Хуйс", 1500, 6)
                };

                foreach (Employee emp in EmpList)
                {
                    emp.GetEmployeeInfo();

                }
                foreach (Employee emp in EmpList)
                {
                    Console.WriteLine(emp.CalculateSalary());
                }

            }
        }
    }
}
