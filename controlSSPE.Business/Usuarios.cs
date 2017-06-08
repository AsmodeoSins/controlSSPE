using controlSSPE.Datos.Interfaces;
using controlSSPE.Datos;
using controlSSPE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Negocio
{
    public class Usuarios : IUsuario
    {
        private IUnidadDeTrabajo _unitOfWork;
        private ContextoIDb _context;
        public Usuarios()
        {
            _context = new ContextoSSPEDb();
            _unitOfWork = new UnidadDeTrabajo(_context);
        }

        public EntidadUsuario ObtenerUsuario(int id)
        {
            return _unitOfWork.RepositorioUsuario.Obtener(id);
        }

        /// <summary>
        /// metodo para validar usuario que intenta iniciar sesion
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        public Boolean IniciaSesion(string usuario, string contraseña)
        {
            Boolean usuarioValido = false;
            var objUsario = _unitOfWork.RepositorioUsuario.ObtenerPorCorreo(usuario);
            if(objUsario !=  null && objUsario.Contraseña == Encriptar(contraseña))
            {
                usuarioValido = true;
            }
            return usuarioValido;
        }

        public EntidadUsuario Registro(EntidadUsuario usuario)
        {
            var existingUser = _unitOfWork.RepositorioUsuario.ObtenerPorCorreo(usuario.Correo);
            if (existingUser != null )
            {
                throw new InvalidOperationException("Email already exists");
            }
            GuardarUsuario(usuario);
            return usuario;
        }
        public void GuardarUsuario(EntidadUsuario usuario)
        {
            usuario.Contraseña = Encriptar(usuario.Contraseña);
            _unitOfWork.RepositorioUsuario.GuardarUsuario(usuario);
            _unitOfWork.Commit();
        }

        private string Encriptar(string aEncriptar)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            
            md5.ComputeHash(Encoding.ASCII.GetBytes(aEncriptar));
            
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
