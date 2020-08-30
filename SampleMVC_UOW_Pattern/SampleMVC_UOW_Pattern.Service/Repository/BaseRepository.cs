using SampleMVC_UOW_Pattern.DataAccess;
using SampleMVC_UOW_Pattern.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SampleMVC_UOW_Pattern.Service.Repository
{
    public class BaseRepository<T> where T : class
    {
        IDbFactory _dbFactory;        
        public BaseRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        private NorthwindDB_SampleEntities _northwindDB;
        public NorthwindDB_SampleEntities InitNorthwindDb { 
            get { return _northwindDB ?? (_northwindDB = _dbFactory.InitNorthwindDb); } 
        }

        public IEnumerable<T> GetTable(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> dbEntity = _dbFactory.InitNorthwindDb.Set<T>();

            if (filter != null)
            {
                dbEntity = dbEntity.Where(filter);
            }

            return dbEntity.ToList();
        }

        public void Add(T entity)
        {
            _dbFactory.InitNorthwindDb.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            var dbEntity = _dbFactory.InitNorthwindDb.Entry<T>(entity);
            dbEntity.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            var dbEntity = _dbFactory.InitNorthwindDb.Entry<T>(entity);
            dbEntity.State = EntityState.Deleted;
        }

        public void DeleteById(T entity, int id)
        {
            var dbEntity = _dbFactory.InitNorthwindDb.Set<T>();
            var md = dbEntity.Find(id);
            this.Delete(md);
        }

        public void SaveChange()
        {
            _dbFactory.InitNorthwindDb.SaveChanges();
        }
    }
}
