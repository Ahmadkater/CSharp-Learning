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
            var orgs = new Organization[]
            {
                new Organization { Name = "Org1" },
                new Organization { Name = "Org2" },
                new Organization { Name = "Org3" }
            };

            addBatch(orgRepo , orgs );
            
        }

        private static void addBatch(IRepo<Organization> orgRepo, Organization[] orgs)
        {
            foreach (var o in orgs)
            {
                orgRepo.Add(o);

            }
            
            orgRepo.Save();
        }

        private static void GetEmployeeById(IRepo<Employee> er, int id)
        {
            var e = er.GetById(id);
            System.Console.WriteLine($"Found Id {id} : {e.FirstName}");
        }

    }
}
