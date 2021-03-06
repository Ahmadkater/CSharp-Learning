using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;
using System ;

namespace WiredBrainCoffee.StorageApp.Repo
{
    public class SqlRepo<T> : IRepo<T> where T:class , IEntity
    {
        private readonly DbContext _dbContext ;
        private readonly DbSet<T> _dbSet;
        
        public  event EventHandler<T> itemAddedCallBack ;

        public SqlRepo(DbContext dbContext)
        {
            _dbContext = dbContext ;
            _dbSet = _dbContext.Set<T>() ;
        }

        public void Add(T e)
        {
            _dbSet.Add(e);
            itemAddedCallBack.Invoke(this , e);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Remove(T e)
        {
            _dbSet.Remove(e);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id) ;
        }

        public IEnumerable<T> GetAll()
        {
            Func<T , int> selectedkey = (t) => t.Id ; 

            return _dbSet.OrderBy(selectedkey).ToList() ;
        }
    }

}