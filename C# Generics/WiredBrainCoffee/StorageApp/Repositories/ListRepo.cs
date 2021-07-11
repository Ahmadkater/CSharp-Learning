using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repo
{
    public class ListRepo<T> : IRepo<T> where T:class , IEntity
    {
        private readonly List<T> _entities = new List<T>();
        public void Add(T e)
        {
            e.Id = _entities.Count + 1 ;
            _entities.Add(e);

        }

        public void Save()
        {
            // Every thing is saved already
        }

        public void Remove(T e)
        {
            _entities.Remove(e) ;
        }

        public T GetById(int id)
        {
            return _entities.Single(item => item.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList() ;
        }
    }
}