using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_mon
{
    public interface IEmployee
    {
        string Name { get; set; } 
        string Surname { get; set; } 
        string Position { get; set; } 
        decimal Salary { get; set; } 
        DateTime HireDate { get; set; } 
        char Gender { get; set; }
    }
}
