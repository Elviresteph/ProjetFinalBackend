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
    public class UtilisateursController : ApiController
    {
        //GET: api/Utilisateurs
        public List<Utilisateurs> Get()
        {
            return new DaoUtilisateurs().FindAll();
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }
        // POST: api/Utilisateurs
        public void Post([FromBody]Utilisateurs value)
        {
            new DaoUtilisateurs().Create(value);
        }

        // PUT: api/Utilisateurs/5
        public void Put([FromBody]Utilisateurs value)
        {
            new DaoUtilisateurs().Update(value);
        }

        // DELETE: api/Utilisateurs/5
        public void Delete(int id)
        {
        }
    }
}
