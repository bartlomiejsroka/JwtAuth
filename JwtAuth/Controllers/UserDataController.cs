using JwtAuth.Filters;
using System.Web.Http;

namespace JwtAuth.Controllers
{
    public class UserDataController : ApiController
    {
        // GET: UserData
        [JwtAuthentication]
        public string Get()
        {
            return "value";
        }
    }
}