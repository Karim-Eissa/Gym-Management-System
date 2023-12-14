using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Staff : Person
    {
        public string Salary { get; set; }
        public string Position { get; set; }
        public Staff(string name, int age, string gender, string type, DateTime StartDate, string salary, string position)
            : base(name, age, gender,type,StartDate)
        {
            this.Salary = salary;
            this.Position = position;
        }
    }
}
