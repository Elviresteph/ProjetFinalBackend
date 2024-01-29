using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinal.classe_et_Dao
{
    public class Article
    {
        private int idArticle;
        private string article;
        private string description;
        private double prix;
        private double prixTotal;
        private int quantite;
        private string categorie;
        public Article()
        {

        }
        public Article(string article, double prix, int quantite, double prixTotal, string categorie)
        {
            this.prixTotal = prixTotal;
            this.article = article;
            this.prix = prix;
            this.quantite = quantite;
            this.categorie = categorie;

        }
        public Article(int idArticle, string article, string description, double prix)
        {
            this.idArticle = idArticle;
            this.article = article;
            this.description = description;
            this.prix = prix;
        }
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public int IdArticle
        {
            get { return idArticle; }
            set { idArticle = value; }
        }
        public string Nom
        {
            get { return article; }
            set { article = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        public double PrixTotal
        {
            get { return prixTotal; }
            set { prixTotal = value; }
        }
    }
}