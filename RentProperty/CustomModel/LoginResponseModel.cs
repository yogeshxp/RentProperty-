﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentProperty.CustomModel
{
    public class LoginResponseModel
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
    }
}