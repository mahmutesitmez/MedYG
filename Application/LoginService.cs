﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Application;
internal class LoginService
{
    public bool Login(string username, string password)
    {
        if (username == "admin" && password == "admin")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
