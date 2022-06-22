using FairWorks.BLManager.Abstract;
using FairWorks.DAL.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Concrete
{
    public class ManagerBase<TEntity> : IManagerBase<TEntity> where TEntity : class, new()
    {
        protected FairWorksDbRepository<TEntity> db;

        public ManagerBase()
        {
            db = new FairWorksDbRepository<TEntity>();
        }

        public void Add(TEntity model)
        {
            db.Insert(model);
            
        }

        public void Delete(TEntity model)
        {
            db.Delete(model);
        }

        public void Delete(int id)
        {
            //var entity = Find(id);
            //if(entity != null)
            //    db.Delete(entity);

            db.Delete(id);
        }

        public TEntity Find(int id)
        {
           return db.GetById(id);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return db.GetAll(filter);
        }

        public IQueryable<TEntity> GetAllInclude(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] Include)
        {
            return db.GetAllInclude(filter, Include);
        }

        public void Update(TEntity model)
        {
            db.Update(model);
        }

       
    }
}
