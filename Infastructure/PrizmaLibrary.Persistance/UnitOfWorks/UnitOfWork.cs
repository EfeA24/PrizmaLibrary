using PrizmaLibrary.Application.Interfaces.Repositories;
using PrizmaLibrary.Application.Interfaces.UnitOfWorks;
using PrizmaLibrary.Persistance.Context;
using PrizmaLibrary.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Persistance.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AddDbContext _context;
        public UnitOfWork(AddDbContext context) 
        {
            _context = context;
        }
        public async ValueTask DisposeAsync() => await _context.DisposeAsync();

        public int Save() => _context.SaveChanges();

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_context);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(_context);
    }
}
