using controlSSPE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos.Interfaces
{
    public interface IRepositorioUsuario
    {
        EntidadUsuario Obtener(int id);
        EntidadUsuario ObtenerPorCorreo(string correo);
        void GuardarUsuario(EntidadUsuario usuario);
    }
}
