using _2_mon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_mon
{
    public class Student
    {
        public string FullName { get; set; }
        public string Group { get; set; } 
        public double AverageMark { get; set; } 
        public decimal IncomePerFamilyMember { get; set; } 
        public int FamilySize { get; set; } 
        public Gender Gender { get; set; } 
        public EducationForm EducationForm { get; set; } 

        public Student(string fullName, string group, double averageMark, decimal incomePerFamilyMember, int familySize, Gender gender, EducationForm educationForm)
        {
            FullName = fullName;
            Group = group;
            AverageMark = averageMark;
            IncomePerFamilyMember = incomePerFamilyMember;
            FamilySize = familySize;
            Gender = gender;
            EducationForm = educationForm;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Ф.И.О.: {FullName}");
            Console.WriteLine($"Группа: {Group}");
            Console.WriteLine($"Средний балл: {AverageMark}");
            Console.WriteLine($"Доход на члена семьи: {IncomePerFamilyMember}");
            Console.WriteLine($"Состав семьи: {FamilySize}");
            Console.WriteLine($"Пол: {Gender}");
            Console.WriteLine($"Форма обучения: {EducationForm}");
        }
    }
}
