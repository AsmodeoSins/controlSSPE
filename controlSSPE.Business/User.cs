using controlSSPE.Business.Interfaces;
using controlSSPE.Data;
using controlSSPE.Data.Interfaces;
using controlSSPE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Business
{
    public class User : IUser
    {
        private IUnitOfWork _unitOfWork;
        private IDbContext _context;
        public User()
        {
            _context = new SSPEDbContext();
            _unitOfWork = new UnitOfWork(_context);
        }

        public UserEntity GetUser(int id)
        {
            return _unitOfWork.UserRepository.Get(id);
        }

        public UserEntity Login(string email, string password)
        {
            var user = _unitOfWork.UserRepository.GetByEmail(email);
            if(user == null)
            {
                throw new InvalidOperationException("Invalid credentials");
            }
            if(user.Password != Encrypt(password))
            {
                throw new InvalidOperationException("Invalid credentials");
            }
            return user;
        }

        public UserEntity SignUp(UserEntity user)
        {
            var existingUser = _unitOfWork.UserRepository.GetByEmail(user.Email);
            if (existingUser != null )
            {
                throw new InvalidOperationException("Email already exists");
            }
            SaveUser(user);
            return user;
        }
        public void SaveUser(UserEntity user)
        {
            user.Password = Encrypt(user.Password);
            _unitOfWork.UserRepository.SaveUser(user);
            _unitOfWork.Commit();
        }

        private string Encrypt(string toEncrypt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            
            md5.ComputeHash(Encoding.ASCII.GetBytes(toEncrypt));
            
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
