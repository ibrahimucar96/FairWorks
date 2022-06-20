using FairWorks.DAL.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.DAL.EFCore
{
    public class FairWorksDbRepository<TEntity> : IFairWorksDbRepository<TEntity> where TEntity : class, new()
    {
        FairWorksDbContext dbContext;

        public FairWorksDbRepository()
        {
            dbContext = new FairWorksDbContext();
        }

        public TEntity GetById(int Id)
        {
            return dbContext.Set<TEntity>().Find(Id);
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return dbContext.Set<TEntity>().ToList();
            }
            else
            {
                return dbContext.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Delete(TEntity entity)
        {

            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();
        }

        public int Delete(int id)
        {            
            var entity = dbContext.Set<TEntity>().Find(id);
            dbContext.Set<TEntity>().Remove(entity);
            return dbContext.SaveChanges();
        }       

        public IQueryable<TEntity> GetAllInclude(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] include)
        {
                var query = dbContext.Set<TEntity>().Where(filter);
            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }        
        public void Insert(TEntity entity)
        {
           dbContext.Set<TEntity>().Add(entity);
           dbContext.SaveChanges(); 
        }

        public void Update(TEntity entity)
        {
            
            dbContext.Entry<TEntity>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
