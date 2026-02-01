using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Vet_Lib.View.Membre.Page;

namespace Vet_Lib.View.Membre.Connexion
{
    public partial class Connexion_membre : Form
    {
        private bool motDePasseVisible = false;

        public Connexion_membre()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MdpZTT.PasswordChar = '●';
            button1.Text = "👁️";
        }

        private void ConnexionYT_Click(object sender, EventArgs e)
        {
            string email = EmailZT.Text.Trim();
            string mdp = MdpZTT.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(mdp))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur");
                return;
            }

            string hashedPassword;
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benha\OneDrive\Documents\VetlibBD.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Membres WHERE Email = @Email AND MotDePasse = @MotDePasse";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MotDePasse", hashedPassword);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            //  Récupérer les infos du membre
                            string infoQuery = "SELECT Id, Nom FROM Membres WHERE Email = @Email";
                            using (SqlCommand infoCmd = new SqlCommand(infoQuery, connection))
                            {
                                infoCmd.Parameters.AddWithValue("@Email", email);
                                using (SqlDataReader reader = infoCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int id = reader.GetInt32(0);
                                        string nom = reader.GetString(1);

                                        Adoptions_membre.SessionUtilisateur.IdUtilisateur = id;
                                        Adoptions_membre.SessionUtilisateur.Nom = nom;
                                    }
                                }
                            }

                            MessageBox.Show("Connexion réussie ✅");
                            Accueil_Membre Accueil = new Accueil_Membre();
                            Accueil.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email ou mot de passe incorrect.", "Erreur");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            motDePasseVisible = !motDePasseVisible;
            MdpZTT.PasswordChar = motDePasseVisible ? '\0' : '●';
            button1.Text = motDePasseVisible ? "🙈" : "👁️";
        }

        private void Connexion_membre_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Accueil_Connexion Accueil_Connexion = new Accueil_Connexion();
            Accueil_Connexion.Show();
            this.Hide();
        }
    }
}
