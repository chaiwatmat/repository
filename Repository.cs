using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SampleRepository {
    public class Repository<TModel> : IRepository<TModel> where TModel : class {

        protected readonly DbContext Context;

        public Repository(DbContext dbContext) {
            Context = dbContext;
        }

        public TModel Get(int id) {
            return Context.Set<TModel>().Find(id);
        }

        public IEnumerable<TModel> GetAll() {
            return Context.Set<TModel>().ToList();
        }

        public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate) {
            return Context.Set<TModel>().Where(predicate);
        }

        public void Add(TModel model) {
            Context.Set<TModel>().Add(model);
        }

        public void AddRange(IEnumerable<TModel> models) {
            Context.Set<TModel>().AddRange(models);
        }

        public void Remove(TModel model) {
            Context.Set<TModel>().Remove(model);
        }

        public void RemoveRange(IEnumerable<TModel> models) {
            Context.Set<TModel>().RemoveRange(models);
        }
    }
}