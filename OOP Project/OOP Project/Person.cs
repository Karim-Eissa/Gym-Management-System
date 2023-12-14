using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public string Type { get; private set; }
        public ObjectId Id { get; set; }
        public DateTime StartDate { get; set; }
        protected Person(string name, int age, string gender, string type, DateTime startDate)
        {
            Id = ObjectId.GenerateNewId();
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Type = type;
            StartDate = startDate;
        }
    }
}
