using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SampleRpository {
    public interface IRepositry<TModel> where TModel : class {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate);

        void Add(TModel model);
        void AddRanage(IEnumerable<TModel> models);
        void Remove(TModel model);
        void RemoveRanage(IEnumerable<TModel> models);
    }
}