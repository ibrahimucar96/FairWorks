﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.DAL.Abstract
{
    public interface IFairWorksDbRepository<TEntity> where TEntity : class,new()
    {
        public int Insert(TEntity entity);
        public int Update(TEntity entity);
        public int Delete(TEntity entity);
        public int Delete(int id);

        public TEntity GetById(int id);
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        public IQueryable<TEntity> GetAllInclude(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] include);
    }
}
