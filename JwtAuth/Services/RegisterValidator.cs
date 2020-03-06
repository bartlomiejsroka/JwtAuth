using JwtAuth.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JwtAuth.Services
{
    public class RegisterValidator
    {
        public RegisterValidator()
        {

        }
        public bool Valid(RegisterModel model)
        {
            UsersDbEntities Db = new UsersDbEntities();
            return !Db.users.Any(x=>x.username.Equals(model.UserName));
        }
    }
}