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
            employeeRepo.Add(new Employee { FirstName = "e2" });
            employeeRepo.Add(new Employee { FirstName = "e3" });
            employeeRepo.Save();

            var orgRepo = new GenericRepo<Organization>();
            orgRepo.Add(new Organization { Name = "Org1" });
            orgRepo.Add(new Organization { Name = "Org2" });
            orgRepo.Add(new Organization { Name = "Org3" });
            orgRepo.Save();
            
        }
    }
}
