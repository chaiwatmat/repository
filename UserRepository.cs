using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SampleRepository {
    public class UserRepository : Repository<User>, IUserRepository {

        public UserRepository(DbContext context) : base(context) { }

        public IEnumerable<User> GetAllEnable() {
            return Context.Set<User>().Where(u => u.Enabled).ToList();
        }

        // public SampleContext SampleContext {
        //     get { return context as SampleContext; }
        // }
    }
}