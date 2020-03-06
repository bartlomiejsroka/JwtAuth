using JwtAuth.Model;
using JwtAuth.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace JwtAuth.Controllers
{
    public class RegController : ApiController
    {
       
        private RegisterMapper _mapper;
        private RegisterValidator _valid;
        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage IHttpActionResult([FromBody]RegisterModel model)
        {
            _mapper = new RegisterMapper();
            _valid = new RegisterValidator();
            HttpResponseMessage response = new HttpResponseMessage();
            UsersDbEntities usersDbEntities = new UsersDbEntities();
            if (_valid.Valid(model))
            {
                usersDbEntities.users.Add(_mapper.MapToUser(model));
                usersDbEntities.SaveChanges();
                response.Content = new StringContent("ok", Encoding.Unicode);
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }
            else
            {
                response.Content = new StringContent("user already exist", Encoding.Unicode);
                response.StatusCode = HttpStatusCode.Conflict;
                return response;
            }
           
            //catch (Exception ex)
            //{
            //    // return error message if there was an exception
            //    return response;
            //}
        }
    }
}