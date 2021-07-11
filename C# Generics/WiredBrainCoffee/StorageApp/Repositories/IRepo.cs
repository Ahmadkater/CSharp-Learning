
using WiredBrainCoffee.StorageApp.Entities;
using System.Collections.Generic;

namespace WiredBrainCoffee.StorageApp.Repo
{
    public interface IReadRepo<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public interface IRepo<T> :IReadRepo<T> where T : IEntity
    {

        void Add(T e);
        void Remove(T e);
        void Save();


    }

}