
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.GenericRepo
{
    public class GenericRepo<T>
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T e)
        {
            _entities.Add(e);

        }

        public void Save()
        {
            foreach (var _ in _entities)
            {
                System.Console.WriteLine(_);
            }
        }
    }
}