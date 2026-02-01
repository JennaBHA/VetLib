using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Vet_Lib.View.Membre.Connexion;

namespace Vet_Lib.View.Membre
{
    public partial class Inscription : Form
    {
        private bool motDePasseVisible = false;

        public Inscription()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MdpZT.PasswordChar = '●';
            button1.Text = "👁️";
        }

        private void NomZT_TextChanged(object sender, EventArgs e)
        {
        }

        private void InscriptionYT_Click(object sender, EventArgs e)
        {
            string nom = NomZT.Text.Trim();
            string email = EmailZT.Text.Trim();
            string telephone = TelephoneZT.Text.Trim();
            string mdp = MdpZT.Text;
            DateTime dateInscription = DateTime.Now;

            //  Vérification des champs
            if (string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telephone) ||
                string.IsNullOrWhiteSpace(mdp))
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Erreur");
                return;
            }

            // Validation Email
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    MessageBox.Show("Email invalide.", "Erreur");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Email invalide.", "Erreur");
                return;
            }

            //  Validation Téléphone
            if (!telephone.All(char.IsDigit) || telephone.Length != 10 || !telephone.StartsWith("0"))
            {
                MessageBox.Show("Le numéro doit faire 10 chiffres et commencer par 0.", "Erreur");
                return;
            }

            //  Hachage du mot de passe
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

                    //  Vérifier si l’email existe déjà
                    string checkQuery = "SELECT COUNT(*) FROM Membres WHERE Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Cet email est déjà enregistré.", "Erreur");
                            return;
                        }
                    }

                    // 📝 Insertion du membre
                    string insertQuery = @"
                        INSERT INTO Membres (Nom, Email, MotDePasse, DateInscription, Telephone)
                        VALUES (@Nom, @Email, @MotDePasse, @DateInscription, @Telephone)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Nom", nom);
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@MotDePasse", hashedPassword);
                        insertCmd.Parameters.AddWithValue("@DateInscription", dateInscription);
                        insertCmd.Parameters.AddWithValue("@Telephone", telephone);

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Inscription réussie 🎉 Bienvenue dans la famille VetLib !");

                            Connexion_membre connexionForm = new Connexion_membre();
                            connexionForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'inscription.");
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
            MdpZT.PasswordChar = motDePasseVisible ? '\0' : '●';
            button1.Text = motDePasseVisible ? "🙈" : "👁️";
        }

        private void Inscription_Load(object sender, EventArgs e)
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
