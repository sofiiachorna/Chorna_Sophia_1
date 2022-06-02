using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("James", "Skavo", 4000, 56);
            worker.Calculate();

            Console.WriteLine(worker.Serialize());

            Worker worker2 = worker.Deserialize("{\"Name\":\"Bob\",\"Surname\":\"Dilan\",\"Salary\":123000,\"Days\":12}");
            worker2.Calculate();
        }
    }
}
