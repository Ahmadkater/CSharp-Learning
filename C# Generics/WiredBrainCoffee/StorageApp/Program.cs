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
            var mgs = new Manager[]
            {
                new Manager { FirstName = "m1" },
                new Manager { FirstName = "m2" }
            };

            addBatch(mangerRepo,mgs);
        }

        private static void GenerateEmployees(IRepo<Employee> employeeRepo)
        {
            var emps = new Employee[]
            {
                new Employee { FirstName = "e1" },
                new Employee { FirstName = "e2" },

            };

            var emps2 = new Employee[]
            {
                new Employee { FirstName = "e3" },
                new Employee { FirstName = "e4" },

            };

            addBatch<Employee>(employeeRepo , emps) ;
            addBatch(employeeRepo , emps2) ;
        }

        private static void GenerateOrganisations(IRepo<Organization> orgRepo)
        {
            var orgs = new Organization[]
            {
                new Organization { Name = "Org1" },
                new Organization { Name = "Org2" },
                new Organization { Name = "Org3" }
            };

            addBatch(orgRepo , orgs);
            
        }

        private static void addBatch<T> (IWriteRepo<T> repo , T[] entities)
        {
            foreach (var e in entities)
            {
                repo.Add(e);

            }

            repo.Save();
        }

        private static void GetEmployeeById(IRepo<Employee> er, int id)
        {
            var e = er.GetById(id);
            System.Console.WriteLine($"Found Id {id} : {e.FirstName}");
        }

    }
}
