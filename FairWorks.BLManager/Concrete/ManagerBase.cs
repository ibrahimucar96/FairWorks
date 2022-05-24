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

        public int Add(TEntity model)
        {
           return db.Insert(model);
        }

        public int Delete(TEntity model)
        {
           return db.Delete(model);
        }

        public int Delete(int id)
        {
           return db.Delete(id);
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

        public int Update(TEntity model)
        {
           return db.Update(model);
        }
    }
}
