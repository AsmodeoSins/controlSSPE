using controlSSPE.Datos.Interfaces;
using controlSSPE.Entidades;
using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos.Repositorios
{
    public class RepositorioUsuario: RepositorioBase<EntidadUsuario>, IRepositorioUsuario
    {
        private ContextoSSPEDb _context;
        public RepositorioUsuario(ContextoSSPEDb context)
        {
            _context = context;
        }

        public EntidadUsuario Obtener(int id)
        {
            using (var commandTable = _context.CreateCommand())
            {
                commandTable.CommandText = "SELECT * FROM Users WHERE Id =:id";
                commandTable.AddParameter("id", id);
                return ALista(commandTable).FirstOrDefault();
            }
        }

        public void GuardarUsuario(EntidadUsuario usuario)
        {
            StringBuilder sbQuery;
            using (var commandTable = _context.CreateCommand())
            {

                sbQuery = new StringBuilder("INSERT INTO Users (Id, Name,LastName,Email,Password) ")
                    .Append(" VALUES(users_seq.nextval, :name, :lastName,  :email, :password)");
                commandTable.CommandText = sbQuery.ToString();
                commandTable.AddParameter("name", usuario.Nombre);
                commandTable.AddParameter("lastName", usuario.Apellidos);
                commandTable.AddParameter("email", usuario.Correo);
                commandTable.AddParameter("password", usuario.Contraseña);
                commandTable.ExecuteNonQuery();
            }
        }

        protected override void Map(OracleDataReader record, EntidadUsuario entidad)
        {
            entidad.Id = record.GetInt32(0);
            if(!record.IsDBNull(1))
            {
                entidad.Nombre = record.GetString(1);
            }
            if (!record.IsDBNull(2))
            {
                entidad.Apellidos = record.GetString(2);
            }
            if (!record.IsDBNull(3))
            {
                entidad.Correo = record.GetString(3);
            }
            if (!record.IsDBNull(4))
            {
                entidad.Contraseña = record.GetString(4);
            }
        }

        protected override EntidadUsuario CreateEntity()
        {
            return new EntidadUsuario();
        }

        public EntidadUsuario ObtenerPorCorreo(string email)
        {
            using (var commandTable = _context.CreateCommand())
            {
                commandTable.CommandText = "SELECT * FROM Users WHERE Email = :email";
                commandTable.AddParameter("email", email);
                return ALista(commandTable).FirstOrDefault();
            }
        }

        
    }
    
}
