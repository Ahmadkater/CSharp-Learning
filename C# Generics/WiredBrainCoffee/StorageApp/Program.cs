using System;
using WiredBrainCoffee.StorageApp.GenericRepo;
using WiredBrainCoffee.StorageApp.Entities;

namespace StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepo = new GenericRepo<Employee>();
            employeeRepo.Add(new Employee { FirstName = "e1" });
            var e2 = new Employee { FirstName = "e2" } ;
            employeeRepo.Add(e2);
            employeeRepo.Add(new Employee { FirstName = "e3" });
            employeeRepo.Remove(e2);

            System.Console.WriteLine( employeeRepo.GetById(3) ) ;

            var orgRepo = new GenericRepo<Organization>();
            orgRepo.Add(new Organization { Name = "Org1" });
            orgRepo.Add(new Organization { Name = "Org2" });
            orgRepo.Add(new Organization { Name = "Org3" });

            System.Console.WriteLine( orgRepo.GetById(2) ) ;

            
        }
    }
}
