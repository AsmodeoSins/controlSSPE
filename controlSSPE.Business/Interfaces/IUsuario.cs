using controlSSPE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos.Interfaces
{
    public interface IUsuario
    {
        EntidadUsuario ObtenerUsuario(int id);
        void GuardarUsuario(EntidadUsuario user);
        Boolean IniciaSesion(string correo, string contraseña);
        EntidadUsuario Registro(EntidadUsuario user);

    }
}
