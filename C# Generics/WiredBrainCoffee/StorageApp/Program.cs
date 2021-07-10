using System;
using WiredBrainCoffee.StorageApp.GenericRepo;
using WiredBrainCoffee.StorageApp.Entities;

namespace StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepo = new GenericRepoWithRemove<Employee>();
            employeeRepo.key = 1 ;
            employeeRepo.Add(new Employee { FirstName = "e1" });
            var e2 = new Employee { FirstName = "e2" } ;
            employeeRepo.Add(e2);
            employeeRepo.Add(new Employee { FirstName = "e3" });
            employeeRepo.Remove(e2);
            employeeRepo.Save();

            var orgRepo = new GenericRepo<Organization , string>();
            orgRepo.key = "1" ;
            orgRepo.Add(new Organization { Name = "Org1" });
            orgRepo.Add(new Organization { Name = "Org2" });
            orgRepo.Add(new Organization { Name = "Org3" });
            orgRepo.Save();
            
        }
    }
}
