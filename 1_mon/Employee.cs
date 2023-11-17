using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_mon
{
    public struct Employee : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public char Gender { get; set; }

        public Employee(string name, string surname, string position, decimal salary, DateTime hireDate, char gender)
        {
            Name = name;
            Surname = surname;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nДолжность: {Position}\nЗарплата: {Salary}\nДата приема на работу: {HireDate.ToShortDateString()}\nПол: {Gender}";
        }
    }
}
