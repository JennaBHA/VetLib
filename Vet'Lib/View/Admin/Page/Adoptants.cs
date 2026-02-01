using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Vet_Lib.View.Class;

namespace Vet_Lib
{
    public partial class Adoptants : Form
    {
        // Communication avec la base de données
        Fonction Con = new Fonction();

        // Clé utilisée pour identifier un adoptant sélectionné
        int cle = 0;

        // Constructeur du formulaire
        public Adoptants()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Personnalisation visuelle du DataGridView
            AdoptantsList.AllowUserToAddRows = false;
            AdoptantsList.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            AdoptantsList.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            AdoptantsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AdoptantsList.EnableHeadersVisualStyles = false;
            AdoptantsList.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);

            // Chargement des données et ajout du bouton suppression
            AfficherAdoptants();

            // Lien des événements au clic dans les cellules
            AdoptantsList.CellClick += AdoptantsList_CellClick;
            AdoptantsList.CellContentClick += AdoptantsList_CellContentClick;
        }

        // Fonction d'affichage des adoptants dans le tableau
        private void AfficherAdoptants()
        {
            string req = "SELECT * FROM Membres ORDER BY DateInscription DESC";
            DataTable dt = Con.RecupererData(req);
            AdoptantsList.DataSource = dt;

            // Ajout  du bouton "Supprimer" si non présent
            if (!AdoptantsList.Columns.Contains("SupprimerColonne"))
            {
                DataGridViewButtonColumn btnSupp = new DataGridViewButtonColumn();
                btnSupp.Name = "SupprimerColonne";
                btnSupp.HeaderText = "Supprimer";
                btnSupp.Text = "🗑️";
                btnSupp.UseColumnTextForButtonValue = true;
                btnSupp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                AdoptantsList.Columns.Add(btnSupp);
            }
        }

        // Récupération de l'identifiant de l'adoptant lors d’un clic
        private void AdoptantsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = AdoptantsList.Rows[e.RowIndex];
                    cle = Convert.ToInt32(row.Cells["Id"].Value); // Vérifie que la colonne "Id" existe
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la sélection : " + ex.Message);
                }
            }
        }

        // Suppression d'un adoptant via le bouton dans la grille
        private void AdoptantsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AdoptantsList.Columns[e.ColumnIndex].Name == "SupprimerColonne" && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = AdoptantsList.Rows[e.RowIndex];
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string nom = row.Cells["Nom"].Value.ToString();

                    // Confirmation avant suppression
                    DialogResult result = MessageBox.Show(
                        $"Supprimer l’adoptant {nom} ?",
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        string requete = $"DELETE FROM Membres WHERE Id = '{id}'";
                        Con.EnvoyerData(requete);
                        MessageBox.Show($"L’adoptant {nom} a bien été supprimé !");
                        AfficherAdoptants(); // Mise à jour de la liste
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
        }

        private void Supprimer_Click(object sender, EventArgs e) { }
        private void Supprimer_Click_1(object sender, EventArgs e) { }
        private void AdoptantsList_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        // Navigation entre les différentes pages
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_accueil accueilForm = new Page_accueil();
            accueilForm.Show();
            this.Hide();
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Page_accueil pagePage_accueil = new Page_accueil();
            pagePage_accueil.Show();
        }

        private void Dossiers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dossiers pageDossiers = new Dossiers();
            pageDossiers.Show();
        }

        private void Adoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptions pageAdoptions = new Adoptions();
            pageAdoptions.Show();
        }

        private void AdoptantsZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptants pageAdoptants = new Adoptants();
            pageAdoptants.Show();
        }

        private void AnimauxZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animaux pageAnimaux = new Animaux();
            pageAnimaux.Show();
        }

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            FormTop formTop = new FormTop();
            formTop.Show();
            this.Hide();
        }

        private void Adoptants_Load(object sender, EventArgs e)
        {

        }
    }
}
