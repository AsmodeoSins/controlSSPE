using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Datos.Repositorios
{
    public abstract class RepositorioBase<TEntity>
    {
        protected IEnumerable<TEntity> ALista(OracleCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                List<TEntity> elementos = new List<TEntity>();
                while (reader.Read())
                {
                    var elemento = CreateEntity();
                    Map(reader, elemento);
                    elementos.Add(elemento);
                }
                return elementos;
            }
        }
        protected abstract void Map(OracleDataReader record, TEntity entity);
        protected abstract TEntity CreateEntity();
    }
}
