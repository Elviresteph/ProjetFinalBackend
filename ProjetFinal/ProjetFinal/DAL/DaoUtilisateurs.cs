using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetFinal.DAL
{
    public class DaoUtilisateurs
    {
        public List<Utilisateurs> FindAll()
        {
            Entities context = new Entities();
            return context.Utilisateurs.ToList<Utilisateurs>();
        }

        public List<Utilisateurs> FindBylogin(string login)
        {
            Entities context = new Entities();
            return context.Utilisateurs.Where(user => user.login.Equals(login)).ToList();
        }

        public List<Utilisateurs> FindByMail(string EMail)
        {
            Entities context = new Entities();
            return context.Utilisateurs.Where(user => user.e_mail.Equals(EMail)).ToList();
        }

        public Utilisateurs Create(Utilisateurs user)
        {
            Entities context = new Entities();
            context.Utilisateurs.Add(user);
            context.SaveChanges();
            return user;
        }

        public void Delete(int id)
        {
            Entities context = new Entities();
            Utilisateurs user = context.Utilisateurs.Find(id);
            context.Utilisateurs.Remove(user);
            context.SaveChanges();
        }

        public void Update(Utilisateurs user)
        {
            Entities context = new Entities();
            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}