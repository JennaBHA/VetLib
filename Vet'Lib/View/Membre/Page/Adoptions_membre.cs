using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Vet_Lib;
using Vet_Lib.View.Class;
using Vet_Lib.View.Membre.Connexion;
using Vet_Lib.View.Membre.Page;

namespace Vet_Lib.View.Membre.Page
{
    public partial class Adoptions_membre : Form
    {
        public Adoptions_membre()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Load += Adoptions_membre_Load;
            AnimauxAdoption.AllowUserToAddRows = false;

        }

        //  Classe statique pour la session utilisateur
        public static class SessionUtilisateur
        {
            public static int IdUtilisateur { get; set; }
            public static string Nom { get; set; }

            public static void Nettoyer()
            {
                IdUtilisateur = 0;
                Nom = null;
            }
        }

        //  Chargement des adoptions pour l'utilisateur
        private void Adoptions_membre_Load(object sender, EventArgs e)
        {
            int idUtilisateur = SessionUtilisateur.IdUtilisateur;

            string requete = $@"
                SELECT a.Id AS [ID Animal], a.Nom AS [Nom de l'animal], ad.DateAdoption AS [Date d'adoption]
                FROM Animaux a
                INNER JOIN Adoptions ad ON a.Id = ad.IdAnimal
                WHERE ad.IdMembre = {idUtilisateur}
                ORDER BY ad.DateAdoption DESC";

            Fonction con = new Fonction();
            DataTable dt = con.RecupererData(requete);

            AnimauxAdoption.DataSource = dt;

            //  Personnalisation de l'affichage
            AnimauxAdoption.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(250, 245, 230);
            AnimauxAdoption.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            AnimauxAdoption.ThemeStyle.HeaderStyle.BackColor = Color.MediumVioletRed;
            AnimauxAdoption.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AnimauxAdoption.ColumnHeadersHeight = 40;
            AnimauxAdoption.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AnimauxAdoption.ReadOnly = true;
        }

        // Gestion du clic sur une cellule (future utilisation possible)
        private void AnimauxAdoption_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Déconnexion
        private void Déconnexion_Click(object sender, EventArgs e)
        {
            SessionUtilisateur.Nettoyer();
            Connexion_membre Connexion_membre = new Connexion_membre();
            Connexion_membre.Show();
            this.Close();
        }

        //  Naviguer vers les autres pages
        private void Adoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptions_membre pageAdoptions_membre = new Adoptions_membre();
            pageAdoptions_membre.Show();
        }

        private void AnimauxZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animaux_membre pageAnimaux_membre = new Animaux_membre();
            pageAnimaux_membre.Show();
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil_Membre pageAccueil_Membre = new Accueil_Membre();
            pageAccueil_Membre.Show();
        }
    }
}
