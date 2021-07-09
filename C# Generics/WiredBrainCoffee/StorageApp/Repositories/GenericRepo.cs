
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.GenericRepo
{
    public class GenericRepo<T>
    {
        protected readonly List<T> _entities = new List<T>();

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

    public class GenericRepoWithRemove<T> : GenericRepo<T> 
    {
        public void Remove(T e)
        {
            _entities.Remove(e) ;
        }
    }
}