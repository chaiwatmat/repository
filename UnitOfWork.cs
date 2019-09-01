using System;
using Microsoft.EntityFrameworkCore;

namespace SampleRepository {
    public class UnitOfWork : IUnitOfWork {
        private DbContext _context;

        public UnitOfWork(DbContext context) {
            _context = context;
            User = new UserRepository(_context);
        }

        public IUserRepository User { get; private set; }

        public int Complete() {
            return _context.SaveChanges();
        }

        public void Dispose() {
            _context.Dispose();
        }
    }
}