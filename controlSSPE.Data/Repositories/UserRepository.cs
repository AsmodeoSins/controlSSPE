using controlSSPE.Data.Interfaces;
using controlSSPE.Entities;
using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Data.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        private SSPEDbContext _context;
        public UserRepository(SSPEDbContext context)
        {
            _context = context;
        }

        public UserEntity Get(int id)
        {
            using (var commandTable = _context.CreateCommand())
            {
                commandTable.CommandText = "SELECT * FROM Users WHERE Id =:id";
                commandTable.AddParameter("id", id);
                return ToList(commandTable).FirstOrDefault();
            }
        }

        public void SaveUser(UserEntity user)
        {
            StringBuilder sbQuery;
            using (var commandTable = _context.CreateCommand())
            {

                sbQuery = new StringBuilder("INSERT INTO Users (Id, Name,LastName,Email,Password) ")
                    .Append(" VALUES(users_seq.nextval, :name, :lastName,  :email, :password)");
                commandTable.CommandText = sbQuery.ToString();
                commandTable.AddParameter("name", user.Name);
                commandTable.AddParameter("lastName", user.LastName);
                commandTable.AddParameter("email", user.Email);
                commandTable.AddParameter("password", user.Password);
                commandTable.ExecuteNonQuery();
            }
        }

        protected override void Map(OracleDataReader record, UserEntity entity)
        {
            entity.Id = record.GetInt32(0);
            if(!record.IsDBNull(1))
            {
                entity.Name = record.GetString(1);
            }
            if (!record.IsDBNull(2))
            {
                entity.LastName = record.GetString(2);
            }
            if (!record.IsDBNull(3))
            {
                entity.Email = record.GetString(3);
            }
            if (!record.IsDBNull(4))
            {
                entity.Password = record.GetString(4);
            }
        }

        protected override UserEntity CreateEntity()
        {
            return new UserEntity();
        }

        public UserEntity GetByEmail(string email)
        {
            using (var commandTable = _context.CreateCommand())
            {
                commandTable.CommandText = "SELECT * FROM Users WHERE Email = :email";
                commandTable.AddParameter("email", email);
                return ToList(commandTable).FirstOrDefault();
            }
        }
    }
    
}
