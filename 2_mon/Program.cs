using _2_mon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new System.Collections.Generic.List<Student>();
            students.Add(new Student("Джонатан Джостар", "А-11", 4.5, 50000, 3, Gender.Male, EducationForm.FullTime));
            students.Add(new Student("Жан-Пьер Польнарефф", "Б-11", 3.8, 60000, 4, Gender.Male, EducationForm.PartTime));
            students.Add(new Student("Муххамед Абдул", "В-12", 4.2, 40000, 2, Gender.Male, EducationForm.Distance));
            students.Add(new Student("Роберт Спидвагон", "А-11", 4.7, 45000, 3, Gender.Female, EducationForm.FullTime));
            students.Add(new Student("Нориаки Какёин", "Б-12", 3.9, 55000, 4, Gender.Female, EducationForm.PartTime));
            students.Add(new Student("Дио Брандо", "В-11", 4.3, 35000, 2, Gender.Female, EducationForm.Distance));

            Console.WriteLine("Выберите отчет:");
            Console.WriteLine("1. Общежитие в первую очередь предоставляется тем, у кого доход на члена семьи меньше двух минимальных зарплат, затем остальным в порядке уменьшения среднего балла. Отобразить данный список.");
            Console.WriteLine("2. Вывести список очередности предоставления мест в общежитии. При этом первые 10 мест выделить зеленым цветом, вторые 10 оранжевым, остальные красным.");
            Console.WriteLine("3. Вывести список студентов, у которых не полная семья.");
            Console.WriteLine("4. Вывести 10 студентов, отличников с самым высоким баллом.");
            Console.WriteLine("5. Вывести 10 студентов, отличников с самым низким баллом.");
            Console.WriteLine("6. Вывести 3 студентов, с самым низким доходом семьи, а так у которых неполноценная семья.");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    decimal minSalary = 85000;
                    var sorted = students.OrderBy(s => s.IncomePerFamilyMember > minSalary).ThenByDescending(s => s.AverageMark);
                    Console.WriteLine("Список студентов, которым предоставляется общежитие:");
                    foreach (Student s in sorted)
                    {
                        s.PrintInfo();
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    var ordered = students.OrderByDescending(s => s.AverageMark);
                    Console.WriteLine("Список очередности предоставления мест в общежитии:");
                    int i = 0; // Счетчик мест
                    foreach (Student s in ordered)
                    {
                        i++;
                        ConsoleColor color;
                        if (i <= 10)
                        {
                            color = ConsoleColor.Green;
                        }
                        else if (i <= 20)
                        {
                            color = ConsoleColor.Yellow;
                        }
                        else
                        {
                            color = ConsoleColor.Red;
                        }
                        Console.ForegroundColor = color;
                        Console.WriteLine($"Место {i}:");
                        s.PrintInfo();
                        Console.WriteLine();
                    }
                    Console.ResetColor();
                    break;
                case 3:
                    var incomplete = students.Where(s => s.FamilySize < 3);
                    Console.WriteLine("Список студентов, у которых не полная семья:");
                    foreach (Student s in incomplete)
                    {
                        s.PrintInfo();
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    var top = students.Where(s => s.AverageMark >= 4.5).OrderByDescending(s => s.AverageMark).Take(10);
                    Console.WriteLine("Список 10 студентов, отличников с самым высоким баллом:");
                    foreach (Student s in top)
                    {
                        s.PrintInfo();
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    var bottom = students.Where(s => s.AverageMark >= 4.5).OrderBy(s => s.AverageMark).Take(10);
                    Console.WriteLine("Список 10 студенов, отличников с самым низким баллом:");
                    foreach (Student s in bottom)
                    {
                        s.PrintInfo();
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    var lowIncomeAndIncompleteFamily = students.OrderBy(s => s.IncomePerFamilyMember).ThenBy(s => s.FamilySize).Take(3);
                    Console.WriteLine("Список 3 студентов с самым низким доходом семьи и неполноценной семьей:");
                    foreach (Student s in lowIncomeAndIncompleteFamily)
                    {
                        s.PrintInfo();
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Некорректный выбор отчета.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
