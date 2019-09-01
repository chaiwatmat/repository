using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SampleRepository {
    public interface IUserRepository : IRepository<User> {
        IEnumerable<User> GetAllEnable();
    }
}