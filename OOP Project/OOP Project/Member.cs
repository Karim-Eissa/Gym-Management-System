using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Member : Person
    {
        public int Months { get; set; }
        public Member(string name, int age, string gender, string type, DateTime StartDate, int Months)
            : base(name, age, gender, type,StartDate)
        {
            this.Months = Months;
        }
    }
}
