
using WiredBrainCoffee.StorageApp.Entities;
using System.Collections.Generic;

namespace WiredBrainCoffee.StorageApp.Repo
{
    public interface IReadRepo<out T> // Parameter T is Covariant
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

    public interface IWriteRepo<in T> // Parameter T is Contravariant
    {
        void Add(T e);
        void Remove(T e);
        void Save();
    }

    public interface IRepo<T> :IReadRepo<T> , IWriteRepo<T> 
    where T : IEntity
    {

    }

}