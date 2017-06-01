using controlSSPE.Data.Interfaces;
using controlSSPE.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private SSPEDbContext _context;
        private bool disposedValue = false;
        private IUserRepository _userRepository;
        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository = _userRepository ?? (_userRepository = new UserRepository(_context));
            }
        }

        public UnitOfWork(IDbContext context)
        {
            _context = (SSPEDbContext)context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}
