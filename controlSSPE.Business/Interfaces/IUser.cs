using controlSSPE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Business.Interfaces
{
    public interface IUser
    {
        UserEntity GetUser(int id);
        void SaveUser(UserEntity user);
        UserEntity Login(string email, string password);
        UserEntity SignUp(UserEntity user);

    }
}
