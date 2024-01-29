using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinal.classe_et_Dao
{
    public class Achat
    {
        private int idArticle;
        private string nomArticle;
        private int quantite;
        private int prixArticle;

        public Achat()
        {
        }

        public Achat(int idArticle, string nomArticle, int quantite, int prixArticle)
        {
            this.idArticle = idArticle;
            this.nomArticle = nomArticle;
            this.quantite = quantite;
            this.prixArticle = prixArticle;
        }
        public int IdArticle
        {
            get { return idArticle; }
            set { idArticle = value; }
        }
        public string NomArticle
        {
            get { return nomArticle; }
            set { nomArticle = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        public int PrixArticle
        {
            get { return prixArticle; }
            set { prixArticle = value; }
        }

        public int GetPrixTotal()
        {
            
            return Quantite * PrixArticle;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
