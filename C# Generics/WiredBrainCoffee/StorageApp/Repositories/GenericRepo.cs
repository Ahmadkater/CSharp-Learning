using System ;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.GenericRepo
{
    public class GenericRepo<T> where T:Entity
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T e)
        {
            e.Id = _entities.Count + 1 ;
            _entities.Add(e);

        }

        public void Save()
        {
            foreach (var _ in _entities)
            {
                System.Console.WriteLine(_);
            }
        }

        public void Remove(T e)
        {
            _entities.Remove(e) ;
        }

        public T GetById(int id)
        {
            return _entities.Single(item => item.Id == id);
        }

    }

}