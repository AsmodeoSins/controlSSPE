using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos.Interfaces
{
    public interface IUnidadDeTrabajo
    {
        IRepositorioUsuario RepositorioUsuario { get; }
        void Commit();
        void Dispose();
    }
}
