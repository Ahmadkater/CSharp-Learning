using System;
using WiredBrainCoffee.StorageApp.EmployeeRepo;
using WiredBrainCoffee.StorageApp.Entities;

namespace StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo r = new EmployeeRepo();
            r.Add(new Employee{FirstName = "e1" });
            r.Add(new Employee{FirstName = "e2" });
            r.Add(new Employee{FirstName = "e3" });
            r.Save();
        }
    }
}
