using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repo
{
    public class SqlRepo<T> : IRepo<T> where T:class , IEntity
    {
        private readonly DbContext _dbContext ;
        private readonly DbSet<T> _dbSet;

        public SqlRepo(DbContext dbContext)
        {
            _dbContext = dbContext ;
            _dbSet = _dbContext.Set<T>() ;
        }

        public void Add(T e)
        {
            _dbSet.Add(e);
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
            return _dbSet.ToList() ;
        }
    }

}