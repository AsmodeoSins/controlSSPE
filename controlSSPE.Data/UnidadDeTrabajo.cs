using controlSSPE.Datos.Interfaces;
using controlSSPE.Datos.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo, IDisposable
    {
        private ContextoSSPEDb _contexto;
        private bool disposedValue = false;
        private IRepositorioUsuario _repositorioUsuario;
        public IRepositorioUsuario RepositorioUsuario
        {
            get
            {
                return _repositorioUsuario = _repositorioUsuario ?? (_repositorioUsuario = new RepositorioUsuario(_contexto));
            }
        }

        public UnidadDeTrabajo(ContextoIDb context)
        {
            _contexto = (ContextoSSPEDb)context;
        }

        public void Commit()
        {
            _contexto.SaveChanges();
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
                    _contexto.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}
