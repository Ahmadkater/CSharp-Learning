
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.GenericRepo
{
    public class GenericRepo<T,Tkey>
    {
        public Tkey key { get; set; }
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

    public class GenericRepoWithRemove<T,K> : GenericRepo<T,K>
    {
        public void Remove(T e)
        {
            _entities.Remove(e) ;
        }
    }
}