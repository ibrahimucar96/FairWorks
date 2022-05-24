using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Abstract
{
    public interface IManagerBase<TEntity> where TEntity: class, new()
    {
        int Add(TEntity model);
        int Update(TEntity model);
        int Delete(TEntity model);
        int Delete(int id);
        TEntity Find(int id);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> GetAllInclude(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] Include);

    }
}
