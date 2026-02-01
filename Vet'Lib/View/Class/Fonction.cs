using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Vet_Lib.View.Class
{
    internal class Fonction
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;

        public Fonction()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benha\OneDrive\Documents\VetlibBD.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        // 🔄 Récupérer des données depuis la base
        public DataTable RecupererData(string Req)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, ConStr);
            sda.Fill(dt);
            return dt;
        }

        // 📤 Envoyer une requête SQL simple (INSERT, DELETE, etc.)
        public int EnvoyerData(string req)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = req;
            Cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }

        // 🖼️ Envoyer des données avec image (Ajout)
        public void EnvoyerDataAvecImage(string query, string nom, string type, string sexe, string naissance, string arrivee, byte[] photo)
        {
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Sexe", sexe);
                    cmd.Parameters.AddWithValue("@DateNaissance", naissance);
                    cmd.Parameters.AddWithValue("@DateArrivee", arrivee);
                    cmd.Parameters.AddWithValue("@Photo", (object)photo ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Permet d’exécuter une requête simple (UPDATE, INSERT, DELETE)
        public void ExecuterRequete(string requete)
        {
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(requete, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        // 🖌️ Modifier des données avec image (Update)
        public void ModifierDataAvecImage(string query, string nom, string type, string sexe, string naissance, string arrivee, byte[] photo, int id)
        {
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Sexe", sexe);
                    cmd.Parameters.AddWithValue("@DateNaissance", naissance);
                    cmd.Parameters.AddWithValue("@DateArrivee", arrivee);
                    cmd.Parameters.AddWithValue("@Photo", (object)photo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
