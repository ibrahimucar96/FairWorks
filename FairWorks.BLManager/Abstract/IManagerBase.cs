using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Abstract
{
    public interface IManagerBase<T> where T: class, new()
    {
        int Add(T model);
        int Update(T model);
        int Delete(T model);

        T Find(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null,
                                   params Expression<Func<T, object>>[] include);

    }
}
