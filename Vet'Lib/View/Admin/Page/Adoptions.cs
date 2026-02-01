using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vet_Lib.View.Class;

namespace Vet_Lib
{
    public partial class Adoptions : Form
    {
        // Objet pour les requêtes SQL
        Fonction Con = new Fonction();

        // Clé primaire utilisée pour sélectionner un enregistrement
        int cle = 0;

        // Verrou temporaire pour éviter les suppressions multiples simultanées
        bool suppressionEnCours = false;

        // Timer pour recharger les données après suppression
        System.Windows.Forms.Timer rechargeTimer = new System.Windows.Forms.Timer();

        // Constructeur du formulaire Adoptions
        public Adoptions()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Personnalisation du tableau
            AdoptionsList.AllowUserToAddRows = false;
            AdoptionsList.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            AdoptionsList.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            AdoptionsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AdoptionsList.EnableHeadersVisualStyles = false;
            AdoptionsList.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);

            // Remplissage du tableau + bouton "Supprimer"
            AfficherAdoptionts();

            // Association des événements
            AdoptionsList.CellClick += AdoptionsList_CellClick;
            AdoptionsList.CellContentClick += AdoptionsList_CellContentClick;

            // Timer configuré pour une recharge douce après suppression
            rechargeTimer.Interval = 200;
            rechargeTimer.Tick += (s, e) =>
            {
                rechargeTimer.Stop();
                AfficherAdoptionts(); // Recharge du tableau
            };
        }

        // Lors du clic sur une cellule, récupère l'identifiant
        private void AdoptionsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AdoptionsList.Rows[e.RowIndex];
                cle = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }

        // Remplit le tableau avec les données des adoptions
        private void AfficherAdoptionts()
        {
            string req = @"
                SELECT 
                    A.Id,
                    AN.Nom AS Nom_Animal,
                    M.Nom AS Nom_Adoptant,
                    A.DateAdoption
                FROM 
                    Adoptions A
                JOIN 
                    Animaux AN ON A.IdAnimal = AN.Id
                JOIN 
                    Membres M ON A.IdMembre = M.Id
            ";

            DataTable dt = Con.RecupererData(req);
            AdoptionsList.DataSource = dt;

            // Renommage des colonnes affichées
            AdoptionsList.Columns["Nom_Animal"].HeaderText = "Animal";
            AdoptionsList.Columns["Nom_Adoptant"].HeaderText = "Adoptant";
            AdoptionsList.Columns["DateAdoption"].HeaderText = "Date";

            // Ajout du bouton "Supprimer" si non présent
            if (!AdoptionsList.Columns.Contains("SupprimerColonne"))
            {
                DataGridViewButtonColumn btnSupp = new DataGridViewButtonColumn();
                btnSupp.Name = "SupprimerColonne";
                btnSupp.HeaderText = "Supprimer";
                btnSupp.Text = "🗑️";
                btnSupp.UseColumnTextForButtonValue = true;
                btnSupp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                AdoptionsList.Columns.Add(btnSupp);
            }
        }

        // Gestion du clic sur le bouton "Supprimer"
        private void AdoptionsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (suppressionEnCours) return;

            if (e.RowIndex >= 0 && AdoptionsList.Columns[e.ColumnIndex].Name == "SupprimerColonne")
            {
                try
                {
                    suppressionEnCours = true;

                    // Récupère l'id de l'adoption
                    DataGridViewRow row = AdoptionsList.Rows[e.RowIndex];
                    int idAdoption = Convert.ToInt32(row.Cells["Id"].Value);

                    // Trouve l'id de l'animal pour le remettre dispo après suppression
                    string reqGetAnimal = $"SELECT IdAnimal FROM Adoptions WHERE Id = {idAdoption}";
                    DataTable dtAnimal = Con.RecupererData(reqGetAnimal);

                    if (dtAnimal.Rows.Count > 0)
                    {
                        int idAnimal = Convert.ToInt32(dtAnimal.Rows[0][0]);

                        // Supprime l’adoption
                        string reqDelete = $"DELETE FROM Adoptions WHERE Id = {idAdoption}";
                        Con.EnvoyerData(reqDelete);

                        // Met à jour l’état de l’animal
                        string reqUpdate = $"UPDATE Animaux SET EstAdopte = 0 WHERE Id = {idAnimal}";
                        Con.EnvoyerData(reqUpdate);

                        MessageBox.Show("Adoption supprimée avec succès ✨");
                    }

                    // Redémarre le timer pour réactualiser l'affichage
                    rechargeTimer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
                finally
                {
                    suppressionEnCours = false;
                }
            }
        }

        // Evénements et clics non utilisés
        private void label4_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) { }
        private void Supprimer_Click(object sender, EventArgs e) { }
        private void Adoptions_Load(object sender, EventArgs e) { }


        // Navigation vers les autres pages
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

        private void AnimauxZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animaux pageAnimaux = new Animaux();
            pageAnimaux.Show();
        }

        private void AdoptantsZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptants pageAdoptants = new Adoptants();
            pageAdoptants.Show();
        }

        private void AdoptionsZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptions pageAdoptions = new Adoptions();
            pageAdoptions.Show();
        }

        private void Dossiers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dossiers pageDossiers = new Dossiers();
            pageDossiers.Show();
        }

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            FormTop formTop = new FormTop();
            formTop.Show();
            this.Hide();
        }
    }
}
