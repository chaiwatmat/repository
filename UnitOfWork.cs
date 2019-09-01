using System;
using Microsoft.EntityFrameworkCore;

namespace SampleRepository {
    public class UnitOfWork : IUnitOfWork {
        private SampleContext _context;

        public UnitOfWork(SampleContext context) {
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