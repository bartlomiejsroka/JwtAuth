using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JwtAuth.Model
{
    public class RegisterModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}