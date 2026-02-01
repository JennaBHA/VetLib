// Importation des bibliothèques nécessaires
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Vet_Lib.View;
using Vet_Lib.View.Class;

namespace Vet_Lib
{
    public partial class FormTop : Form
    {
        Fonction Con;

        // Constructeur du formulaire
        public FormTop()
        {
            InitializeComponent();
            Con = new Fonction();

            // Empêche l’agrandissement de la fenêtre
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Masque les caractères du champ mot de passe
            MdpZT.UseSystemPasswordChar = true;

            // Ajout d’un événement au chargement du formulaire
            this.Load += FormTop_Load;
        }

        // Événement déclenché au chargement du formulaire (actuellement vide)
        private void FormTop_Load(object sender, EventArgs e)
        {
        }

        // Événement déclenché lorsque le bouton de connexion est cliqué
        private void button1_Click(object sender, EventArgs e)
        {
            // Récupération et nettoyage des champs d’identifiant et mot de passe
            string identifiant = IdentifiantZT.Text.Trim();
            string motDePasse = MdpZT.Text.Trim();

            // Vérifie que tous les champs sont remplis
            if (string.IsNullOrEmpty(identifiant) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez compléter tous les champs");
                return;
            }

            // Hachage du mot de passe saisi
            string motDePasseSaisi = HacherMotDePasse(motDePasse);

            // Définition du mot de passe attendu (ici 'Admin')
            string motDePasseClairAttendu = "Admin";
            string motDePasseAttendu = HacherMotDePasse(motDePasseClairAttendu);

            // Vérifie l'identifiant et le mot de passe haché
            if (identifiant.Equals("Admin") && motDePasseSaisi.Equals(motDePasseAttendu))
            {
                // Ouvre la page d’accueil si les identifiants sont corrects
                Page_accueil obj = new Page_accueil();
                obj.Show();
                this.Hide();
            }
            else
            {
                // Affiche un message d’erreur et le hash saisi dans la console
                MessageBox.Show("Identifiants incorrects");
                Console.WriteLine("Hash saisi : " + motDePasseSaisi);
            }
        }

        // Fonction de hachage du mot de passe avec SHA256
        public static string HacherMotDePasse(string motDePasse)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Conversion du mot de passe en tableau d’octets
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));

                // Construction de la chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString(); // Retourne le mot de passe haché
            }
        }

        // Événements inutilisés
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void FormTop_Load_1(object sender, EventArgs e) { }
        private void FormTop_Load_2(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }

        private void Accueil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Accueil_Connexion Accueil_Connexion = new Accueil_Connexion();
            Accueil_Connexion.Show();
            this.Hide();
        }
    }
}
