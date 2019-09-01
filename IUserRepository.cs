using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SampleRpository {
    public interface IUserRepository : IRepository<User> {
        IEnumerable<User> GetAllEnable();
    }
}