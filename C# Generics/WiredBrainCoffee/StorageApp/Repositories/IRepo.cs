
using WiredBrainCoffee.StorageApp.Entities ;
using System.Collections.Generic ;

namespace WiredBrainCoffee.StorageApp.Repo
{
    public interface IRepo<T> where T:IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id) ;
        void Add(T e);
        void Remove(T e);
        void Save();

        
    }

}