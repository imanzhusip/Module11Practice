using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Practice
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            Console.Write("Введите имя сотрудника: ");
            employee.Name = Console.ReadLine();
            Console.Write("Выберите вакансию (0 - Manager, 1 - Developer, 2 - Designer, 3 - Other): ");
            if (Enum.TryParse(Console.ReadLine(), out Vacancies vacancy))
            {
                employee.Vacancy = vacancy;
            }
            else
            {
                Console.WriteLine("ошибка(Other).");
                employee.Vacancy = Vacancies.Other;
            }
            Console.Write("Введите год приема на работу: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                employee.HireDate = new int[3] { year, 0, 0 };
            }
            else
            {
                Console.WriteLine("ошибка");
                employee.HireDate = new int[3] { 0, 0, 0 };
            }
            Console.Write("Введите зарплату: ");
            if (int.TryParse(Console.ReadLine(), out int salary))
            {
                employee.Salary = salary;
            }
            else
            {
                Console.WriteLine("ошибка(зарплата = 0).");
                employee.Salary = 0;
            }
            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine($"Имя: {employee.Name}");
            Console.WriteLine($"Вакансия: {employee.Vacancy}");
            Console.WriteLine($"Дата приема на работу: {employee.HireDate[0]} год");
            Console.WriteLine($"Зарплата: {employee.Salary} рублей");
            Console.ReadKey();
        }
    }
}
