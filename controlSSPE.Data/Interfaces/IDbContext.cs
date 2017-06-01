using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Data.Interfaces
{
    public interface IDbContext
    {
        void SaveChanges();
        void Dispose();

    }
}
