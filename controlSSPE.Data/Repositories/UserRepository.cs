using controlSSPE.Data.Interfaces;
using controlSSPE.Entities;
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
                commandTable.CommandText = "SELECT * FROM Users WHERE Id = @id";
                commandTable.AddParameter("id", id);
                return ToList(commandTable).FirstOrDefault();
            }
        }

        public void SaveUser(UserEntity user)
        {
            using (var commandTable = _context.CreateCommand())
            {
                commandTable.CommandText = @"INSERT INTO Users (Name,LastName,Email,Password) VALUES(@name, @lastName, @password, @email)";
                commandTable.AddParameter("name", user.Name);
                commandTable.AddParameter("lastName", user.LastName);
                commandTable.AddParameter("password", user.Password);
                commandTable.AddParameter("email", user.Email);
                commandTable.ExecuteNonQuery();
            }
        }

        protected override void Map(IDataRecord record, UserEntity entity)
        {
            entity.Id = (int)record["id"];
            entity.Name = (string)record["Name"];
            entity.LastName = (string)record["LastName"];
            entity.Email = (string)record["Email"];
            entity.Password = (string)record["Password"];
        }

        protected override UserEntity CreateEntity()
        {
            return new UserEntity();
        }

        public UserEntity GetByEmail(string email)
        {
            using (var commandTable = _context.CreateCommand())
            {
                commandTable.CommandText = "SELECT * FROM Users WHERE Email = @email";
                commandTable.AddParameter("email", email);
                return ToList(commandTable).FirstOrDefault();
            }
        }
    }
    
}
