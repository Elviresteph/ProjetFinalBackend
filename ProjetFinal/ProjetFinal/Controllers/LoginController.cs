using ProjetFinal.DAL;
using ProjetFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjetFinal.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        // GET: api/Login
        public List<Utilisateurs> Get([FromBody] Authentification login)
        {
            return new DaoUtilisateurs().FindBylogin(login.login);
        }

        // POST: api/Login
        public List<Utilisateurs> Post([FromBody] Authentification value)
        {
            return new DaoUtilisateurs().FindBylogin(value.login);
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
