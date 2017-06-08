using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos.Interfaces
{
    public interface ContextoIDb
    {
        void SaveChanges();
        void Dispose();

    }
}
