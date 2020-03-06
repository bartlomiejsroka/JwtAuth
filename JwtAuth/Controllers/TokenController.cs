using JwtAuth.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace JwtAuth.Controllers
{
    public class TokenController : ApiController
    {
        private List<users> _usersList = new List<users>();

        #region public methods

        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage IHttpActionResult(users user)
        {
           HttpResponseMessage response = new HttpResponseMessage();
            if (CheckUser(user))
            {
                 response.Content = new StringContent(JwtManager.GenerateToken(user.username), Encoding.Unicode);
                
                //return JwtManager.GenerateToken(user.UserName);
                return response;
            }
            response.Content = new StringContent("Wrong username/password", Encoding.Unicode);
            response.StatusCode = HttpStatusCode.Unauthorized;
            return response;
        }

        #endregion
        [HttpGet]
        private HttpResponseMessage Get()
        {
            using (UsersDbEntities dc = new UsersDbEntities())
            {
                _usersList = dc.users.OrderBy(a => a.username).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, _usersList);
                return response;
            }
        }
        private bool CheckUser(users users)
        {
            Get();
            if (users != null && _usersList.Where(x=>x.username.Equals(users.username) && x.password.Equals(users.password)).FirstOrDefault() !=null )
                return true;
            else
                return false;
        }
    }
}
