﻿using AM.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Manager
{
    public interface IUserManager
    {
        List<string> GetUserAnimals(int userId);      
    }
}
