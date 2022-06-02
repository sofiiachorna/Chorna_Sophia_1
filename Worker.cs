using Newtonsoft.Json;
using System;

namespace Lab_1
{
    class Worker
    {
        public string Name;
        public string Surname;
        public int Salary;
        public int Days;

        public Worker() { }

        public Worker(string n, string s, int m, int d)
        {
            Name = n;
            Surname = s;
            Salary = m;
            Days = d;

        }
        public void Calculate()
        {
            Console.WriteLine(this.Name + " " + this.Surname + " ");
            Console.WriteLine("salary: " + this.Salary);
            Console.WriteLine("worked for " + this.Days + " days");
            Console.WriteLine("sum=" + Salary * Days + " $");
        }
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        public Worker Deserialize(string json)
        {
            Worker worker = JsonConvert.DeserializeObject<Worker>(json);
            return worker;
        }
    }
}
