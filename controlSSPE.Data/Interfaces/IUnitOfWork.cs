﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlSSPE.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        void Commit();
        void Dispose();
    }
}
