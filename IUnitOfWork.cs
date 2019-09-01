using System;

namespace SampleRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        int Complete();
    }
}