using controlSSPE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Data.Interfaces
{
    public interface IUserRepository
    {
        UserEntity Get(int id);
        UserEntity GetByEmail(string email);
        void SaveUser(UserEntity user);
    }
}
