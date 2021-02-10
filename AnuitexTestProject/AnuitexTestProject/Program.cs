using System;

namespace AnuitexTestProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Firm f = new Firm();
            Manager manager = new Manager()
            {
                FirstName = "John",
                LastName = "Fraud",
                Title = "Developer"
            };
            Foreman foreman = new Foreman()
            {
                FirstName = "Karter",
                LastName = "Wernstrum",
                Title = "Senior foreman"
            };
            Worker worker = new Worker()
            {
                FirstName = "Bob",
                LastName = "Jonson",
                Title = "staff"
            };
            f += manager;
            f += foreman;
            f += worker;
            f.Print();
            f -= manager;
            f.Print();
            Console.WriteLine(f.employees.FiendElement(x => x.GetType().Name.Contains("Manager")));
            
            Console.Read();
            
        }
    }
}