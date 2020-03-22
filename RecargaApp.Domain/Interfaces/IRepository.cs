using RecargaApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T:IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
