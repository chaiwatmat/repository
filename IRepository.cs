using System;

namespace Rpository {
    public interface IRepositry<TModel> where TModel : class {
        TModel Get(int id);
        IEnumberable<TModel> GetAll();
        IEnumberable<TModel> Find(Expression<Func<TModel, bool>> predicate);

        void Add(TModel model);
        void AddRanage(IEnumberable<TModel> models);
        void Remove(TModel model);
        void RemoveRanage(IEnumberable<TModel> models);
    }
}