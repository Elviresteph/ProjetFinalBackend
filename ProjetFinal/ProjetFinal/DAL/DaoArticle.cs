using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinal.DAL
{
    public class DaoArticle
    {
        public List<Articles_> FindAll()
        {
            Entities context = new Entities();
            return context.Articles_.ToList<Articles_>();
        }
    }
}