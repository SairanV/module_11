using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников:");
            int n = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите данные для сотрудника №{i + 1}:");
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Фамилия: ");
                string surname = Console.ReadLine();
                Console.Write("Должность: ");
                string position = Console.ReadLine();
                Console.Write("Зарплата: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.Write("Дата приема на работу (дд.мм.гггг): ");
                DateTime hireDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Пол (М/Ж): ");
                char gender = char.Parse(Console.ReadLine());
                employees[i] = new Employee(name, surname, position, salary, hireDate, gender);
            }

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("a. вывести полную информацию обо всех сотрудниках;");
            Console.WriteLine("b. вывести полную информацию о сотрудниках, выбранной должности;");
            Console.WriteLine("c. найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии;");
            Console.WriteLine("d. распечатать информацию обо всех сотрудниках, принятых на работу позже определенной даты (дата передается пользователем), отсортированную в алфавитном порядке по фамилии сотрудника;");
            Console.WriteLine("e. Вывести информацию о всех мужчинах, женщинах в зависимости от того что передаст пользователь. Предусмотреть случай, когда, пользователь не выбирает конкретный пол, т.е. просто хочет получить информацию о всех.");
            char choice = char.Parse(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("Полная информация обо всех сотрудниках:");
                    foreach (Employee e in employees)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine();
                    }
                    break;
                case 'b':
                    Console.WriteLine("Введите должность:");
                    string pos = Console.ReadLine();
                    Console.WriteLine($"Полная информация о сотрудниках, занимающих должность {pos}:");
                    foreach (Employee e in employees)
                    {
                        if (e.Position == pos)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 'c':
                    decimal avgSalary = employees.Where(e => e.Position == "Клерк").Average(e => e.Salary);
                    var managers = employees.Where(e => e.Position == "Менеджер" && e.Salary > avgSalary).OrderBy(e => e.Surname);
                    Console.WriteLine($"Менеджеры, зарплата которых больше средней зарплаты всех клерков ({avgSalary}):");
                    foreach (Employee e in managers)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine();
                    }
                    break;
                case 'd':
                    Console.WriteLine("Введите дату (дд.мм.гггг):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    var hiredLater = employees.Where(e => e.HireDate > date).OrderBy(e => e.Surname);
                    Console.WriteLine($"Сотрудники, принятые на работу позже {date.ToShortDateString()}:");
                    foreach (Employee e in hiredLater)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine();
                    }
                    break;
                case 'e':
                    Console.WriteLine("Введите пол (М/Ж/Все):");
                    char gen = char.Parse(Console.ReadLine());
                    var filtered = employees.Where(e => e.Gender == gen || gen == 'В' || gen == 'в');
                    Console.WriteLine($"Сотрудники, пол которых {gen}:");
                    foreach (Employee e in filtered)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Неверный выбор действия.");
                    break;
            }
        }
    }
}
