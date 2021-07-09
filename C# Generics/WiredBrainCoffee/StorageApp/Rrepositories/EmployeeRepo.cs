
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.EmployeeRepo
{
    public class EmployeeRepo
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Add(Employee e)
        {
            _employees.Add(e);

        }

        public void Save()
        {
            foreach (var _ in _employees)
            {
                System.Console.WriteLine(_);
            }
        }
    }
}