using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Data.Repositories
{
    public abstract class BaseRepository<TEntity>
    {
        protected IEnumerable<TEntity> ToList(OracleCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                List<TEntity> items = new List<TEntity>();
                while (reader.Read())
                {
                    var item = CreateEntity();
                    Map(reader, item);
                    items.Add(item);
                }
                return items;
            }
        }
        protected abstract void Map(IDataRecord record, TEntity entity);
        protected abstract TEntity CreateEntity();
    }
}
