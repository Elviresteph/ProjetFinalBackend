using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace ProjetFinal.classe_et_Dao
{
    public class DaoUtilisateurs
    {
        string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=RESTAURANT-AIRE-CS;Integrated Security=True";
        public bool Delete(int id)
        {
            string sql = "delete clients where id = " + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Update(Utilisateurs c)
        {
            string sql = "update clients set password=@password,nom=@nom,prenom=@prenom,adresse=@adresse where id=@id ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = c.Id;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = c.Password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = c.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = c.Prenom;
            command.Parameters.Add("adresse", SqlDbType.NVarChar).Value = c.Adresse;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Insert(Utilisateurs c)
        {
            string sql = "insert into clients values(@id,@password,@nom,@prenom,@adresse)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = c.Id;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = c.Password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = c.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = c.Prenom;
            command.Parameters.Add("adresse", SqlDbType.NVarChar).Value = c.Adresse;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;

        }
        public List<Utilisateurs> SelectAll()
        {
            List<Utilisateurs> liste = new List<Utilisateurs>();
            string sql = "select * from clients";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Utilisateurs c = new Utilisateurs(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7));
                liste.Add(c);

            }
            connection.Close();

            return liste;
        }

        public Utilisateurs SelectById(int id)
        {
            Utilisateurs c = null;
            string sql = "select * from clients where id=" + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                c = new Utilisateurs(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7));
            connection.Close();

            return c;
        }
    }
}