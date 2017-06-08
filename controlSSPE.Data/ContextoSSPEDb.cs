using controlSSPE.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Oracle.DataAccess.Client;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos
{
    public class ContextoSSPEDb : IDisposable, ContextoIDb
    {
        const string ConnectionStringName = "sspeTest";
        private OracleConnection _connection;
        private bool _ownsConnection = true;
        private OracleTransaction _transaction;

        public ContextoSSPEDb()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            _connection = new OracleConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction(); 
        }

        public OracleCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }

        public void SaveChanges()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException();
            }
            _transaction.Commit();
            _transaction = null;
        }
        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
            if (_connection != null && _ownsConnection)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
    public static class CommandExtensions
    {
        public static void AddParameter(this OracleCommand command, string name, object value)
        {
            if (command == null) throw new ArgumentNullException("command");
            if (name == null) throw new ArgumentNullException("name");
            var p = command.CreateParameter();
            p.ParameterName = name;
            p.Value = value ?? DBNull.Value;
            command.Parameters.Add(p);
        }
    }
}
