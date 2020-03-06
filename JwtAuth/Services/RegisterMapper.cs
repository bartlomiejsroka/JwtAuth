using JwtAuth.Model;
using System.Linq;

namespace JwtAuth.Services
{
    public class RegisterMapper
    {
        public RegisterMapper()
        {

        }
        public users MapToUser(RegisterModel register)
        {
            UsersDbEntities usersDbEntities = new UsersDbEntities();
            users user = new users()
            {
                password = register.Password,
                username = register.UserName,

            };
            return user;
            
        }
    }
}