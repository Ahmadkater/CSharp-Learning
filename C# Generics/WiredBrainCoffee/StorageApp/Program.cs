using System;
using WiredBrainCoffee.StorageApp.Repo;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Data;

namespace StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new StorageAppDbContext();

            var employeeRepo = new SqlRepo<Employee>(db);

            GenerateEmployees(employeeRepo);

            GetEmployeeById(employeeRepo , 2) ;

            writeAllToConsole(employeeRepo);

            var orgRepo = new ListRepo<Organization>();

            GenerateOrganisations(orgRepo);

            
            
        }

        private static void writeAllToConsole(IRepo<Employee> employeeRepo)
        {
            var emps = employeeRepo.GetAll();
            foreach (var e in emps)
            {
                System.Console.WriteLine(e);
            }
        }

        private static void GenerateEmployees(IRepo<Employee> employeeRepo)
        {
            employeeRepo.Add(new Employee { FirstName = "e1" });
            employeeRepo.Add(new Employee { FirstName = "e2" });
            employeeRepo.Add(new Employee { FirstName = "e3" });
            employeeRepo.Save();
        }

        private static void GenerateOrganisations(IRepo<Organization> orgRepo)
        {
            orgRepo.Add(new Organization { Name = "Org1" });
            orgRepo.Add(new Organization { Name = "Org2" });
            orgRepo.Add(new Organization { Name = "Org3" });
            orgRepo.Save();
        }

        private static void GetEmployeeById(IRepo<Employee> er , int id)
        {
            var e = er.GetById(id);
            System.Console.WriteLine(e.FirstName);
        }

    }
}
