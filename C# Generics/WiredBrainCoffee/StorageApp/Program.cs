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

            GetEmployeeById(employeeRepo, 2);

            GenerateMangers(employeeRepo);

            writeAllToConsole(employeeRepo);


            var orgRepo = new ListRepo<Organization>();

            GenerateOrganisations(orgRepo);

            writeAllToConsole(orgRepo);            

        }

        private static void writeAllToConsole(IReadRepo<IEntity> repo)
        {
            var emps = repo.GetAll();
            foreach (var e in emps)
            {
                System.Console.WriteLine(e);
            }
        }

        private static void GenerateMangers(IWriteRepo<Manager> mangerRepo)
        {
            mangerRepo.Add(new Manager { FirstName = "m1" });
            mangerRepo.Add(new Manager { FirstName = "m2" });
            mangerRepo.Save();
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

        private static void GetEmployeeById(IRepo<Employee> er, int id)
        {
            var e = er.GetById(id);
            System.Console.WriteLine($"Found Id {id} : {e.FirstName}");
        }

    }
}
