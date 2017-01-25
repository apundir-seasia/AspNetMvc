﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoshi.Domain.Interfaces
{
    public interface IServiceFactory
    {
        IUserService GetUserService();
    }
}