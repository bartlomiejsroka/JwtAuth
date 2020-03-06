using JwtAuth.Model;
using JwtAuth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace JwtAuth.Controllers
{
    public class RegisterControler : ApiController
    {
        private RegisterMapper _mapper;
        private RegisterValidator _validator;

        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage IHttpActionResult([FromBody]RegisterModel model)
        {
            // map model to entity
            HttpResponseMessage response = new HttpResponseMessage();
            UsersDbEntities usersDbEntities = new UsersDbEntities();
            try
            {
                // create user
                usersDbEntities.users.Add(_mapper.MapToUser(model));
                usersDbEntities.SaveChanges();
                return response;
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return response;
            }
        }
    }
}