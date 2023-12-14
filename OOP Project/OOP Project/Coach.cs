using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Coach : Person
    {
        public string FeesPerMonth { get; set; }

        public Coach(string name, int age, string gender, string type, DateTime StartDate, string feesPerMonth)
            : base(name, age, gender,type, StartDate)
        {
            this.FeesPerMonth = feesPerMonth;
        }
    }
}
