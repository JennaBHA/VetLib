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
    public partial class Dossiers : Form
    {
        Fonction Con;

        public Dossiers()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Con = new Fonction();
            AfficherDossier();
            DossierList.CellContentClick += DossiersList_CellContentClick;
        }

        private void AfficherDossier()
        {
            string Req = @"
                SELECT  
                    A.Id, 
                    AN.Nom AS Nom_Animal, 
                    AN.Type, 
                    AN.Sexe, 
                    AN.DateNaissance, 
                    AN.DateArrivee, 
                    AN.EstAdopte, 
                    AN.Photo,
                    M.Nom AS Nom_Adoptant, 
                    A.DateAdoption 
                FROM Adoptions A
                JOIN Animaux AN ON A.IdAnimal = AN.Id
                JOIN Membres M ON A.IdMembre = M.Id";

            DossierList.AllowUserToAddRows = false;
            DossierList.DataSource = Con.RecupererData(Req);

            if (!DossierList.Columns.Contains("btnOuvrir"))
            {
                DataGridViewButtonColumn btnOuvrir = new DataGridViewButtonColumn();
                btnOuvrir.HeaderText = "Dossier";
                btnOuvrir.Text = "Ouvrir";
                btnOuvrir.Name = "btnOuvrir";
                btnOuvrir.UseColumnTextForButtonValue = true;
                DossierList.Columns.Add(btnOuvrir);

                if (DossierList.Columns.Contains("EstAdopte"))
                {
                    DossierList.Columns["EstAdopte"].ReadOnly = true;
                }
            }
        }

        private void DossiersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DossierList.Columns[e.ColumnIndex].Name == "btnOuvrir" && e.RowIndex >= 0)
            {
                DataGridViewRow row = DossierList.Rows[e.RowIndex];

                string nom = row.Cells["Nom_Animal"].Value?.ToString() ?? "";
                string type = row.Cells["Type"].Value?.ToString() ?? "";
                string sexe = row.Cells["Sexe"].Value?.ToString() ?? "";
                string naissance = row.Cells["DateNaissance"].Value?.ToString() ?? "";
                string arrivee = row.Cells["DateArrivee"].Value?.ToString() ?? "";
                string adoption = row.Cells["EstAdopte"].Value?.ToString() ?? "";

                byte[] photo = null;
                if (row.Cells["Photo"].Value != DBNull.Value)
                {
                    photo = (byte[])row.Cells["Photo"].Value;
                }

                DossierDetails popup = new DossierDetails(nom, type, sexe, naissance, arrivee, adoption, photo);
                popup.ShowDialog();
            }
        }

        private void DossierList_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (DossierList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DossierList.SelectedRows[0];
                string id = selectedRow.Cells["Id"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer ce dossier d’adoption ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    string requete = $"DELETE FROM Adoptions WHERE Id = {id};";

                    try
                    {
                        int res = Con.EnvoyerData(requete);

                        if (res > 0)
                            MessageBox.Show("Dossier supprimé avec succès.");
                        else
                            MessageBox.Show("La suppression n’a pas été effectuée.");

                        AfficherDossier();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une ligne à supprimer.");
            }
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

        private void DossiersZ_Click(object sender, EventArgs e)
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

