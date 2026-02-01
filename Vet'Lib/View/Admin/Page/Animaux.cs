using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Vet_Lib.View.Class;

namespace Vet_Lib
{
    public partial class Animaux : Form
    {
        Fonction Con;
        private string cheminImage = "";
        private int cle = 0;

        public Animaux()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Con = new Fonction();

            AnimauxList.AllowUserToAddRows = false;
            AnimauxList.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            AnimauxList.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            AnimauxList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AnimauxList.EnableHeadersVisualStyles = false;
            AnimauxList.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 255);

            AfficherAnimaux();
        }

        private void AfficherAnimaux()
        {
            string req = "SELECT * FROM Animaux ORDER BY DateArrivee DESC";
            DataTable dt = Con.RecupererData(req);
            AnimauxList.DataSource = dt;
        }

        private void PhotoBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cheminImage = ofd.FileName;
                PhotoBox.Image = Image.FromFile(cheminImage);
                PhotoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (NomZT.Text == "" || TypeZT.SelectedIndex == -1 || SexeZT.SelectedIndex == -1 || DateNaissanceZT.Text == "")
            {
                MessageBox.Show("Données invalides");
            }
            else
            {
                try
                {
                    string Rnom = NomZT.Text;
                    string Rtype = TypeZT.SelectedItem.ToString();
                    string Rsexe = SexeZT.SelectedItem.ToString();
                    string RdateNaissance = DateNaissanceZT.Value.ToString("yyyy-MM-dd");
                    string RdateArrivee = DateTime.Now.ToString("yyyy-MM-dd");

                    byte[] imageData = null;
                    if (!string.IsNullOrEmpty(cheminImage))
                    {
                        imageData = File.ReadAllBytes(cheminImage);
                    }

                    string Req = "INSERT INTO Animaux (Nom, Type, Sexe, DateNaissance, DateArrivee, Photo) " +
                                 "VALUES (@Nom, @Type, @Sexe, @DateNaissance, @DateArrivee, @Photo)";
                    Con.EnvoyerDataAvecImage(Req, Rnom, Rtype, Rsexe, RdateNaissance, RdateArrivee, imageData);

                    MessageBox.Show("Animal ajouté !");
                    AfficherAnimaux();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cle = Convert.ToInt32(AnimauxList.SelectedRows[0].Cells[0].Value.ToString());

            NomZT.Text = AnimauxList.SelectedRows[0].Cells["Nom"].Value.ToString();
            TypeZT.Text = AnimauxList.SelectedRows[0].Cells["Type"].Value.ToString();
            SexeZT.Text = AnimauxList.SelectedRows[0].Cells["Sexe"].Value.ToString();
            DateNaissanceZT.Text = AnimauxList.SelectedRows[0].Cells["DateNaissance"].Value.ToString();
            DateArriveeZT.Text = AnimauxList.SelectedRows[0].Cells["DateArrivee"].Value.ToString();

            if (AnimauxList.SelectedRows[0].Cells["Photo"].Value != DBNull.Value)
            {
                byte[] imgData = (byte[])AnimauxList.SelectedRows[0].Cells["Photo"].Value;
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    PhotoBox.Image = Image.FromStream(ms);
                    PhotoBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                PhotoBox.Image = null;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (cle == 0)
            {
                MessageBox.Show("Données invalides");
            }
            else
            {
                try
                {
                    string Rnom = NomZT.Text;
                    string Rtype = TypeZT.SelectedItem.ToString();
                    string Rsexe = SexeZT.SelectedItem.ToString();
                    string RdateNaissance = DateNaissanceZT.Value.ToString("yyyy-MM-dd");
                    string RdateArrivee = DateTime.Now.ToString("yyyy-MM-dd");

                    byte[] imageData = null;
                    if (!string.IsNullOrEmpty(cheminImage))
                    {
                        imageData = File.ReadAllBytes(cheminImage);
                    }

                    string Req = "UPDATE Animaux SET Nom = @Nom, Type = @Type, Sexe = @Sexe, DateNaissance = @DateNaissance, DateArrivee = @DateArrivee, Photo = @Photo WHERE Id = @Id";
                    Con.ModifierDataAvecImage(Req, Rnom, Rtype, Rsexe, RdateNaissance, RdateArrivee, imageData, cle);

                    MessageBox.Show("Animal modifié !");
                    AfficherAnimaux();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (cle == 0)
            {
                MessageBox.Show("Veuillez sélectionner un animal.");
            }
            else
            {
                try
                {
                    string Req = "DELETE FROM Animaux WHERE Id = " + cle;
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Animal supprimé !");
                    AfficherAnimaux();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        // Les autres événements non modifiés…
        private void label1_Click(object sender, EventArgs e) { }
        private void PhotoBox_Click(object sender, EventArgs e) { }

    private void label9_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void Dossiers_Click(object sender, EventArgs e) 
        {
            this.Hide();
            Dossiers pageDossiers = new Dossiers();
            pageDossiers.Show();
        }
        private void Adoptants_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptants pageAdoptants = new Adoptants();
            pageAdoptants.Show();
        }
        private void Adoptions_Click(object sender, EventArgs e) 
        {
            this.Hide();
            Adoptions pageAdoptions = new Adoptions();
            pageAdoptions.Show();
        }
        private void Animaux_Load(object sender, EventArgs e) { }
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

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            FormTop formTop = new FormTop();
            formTop.Show();
            this.Hide();
        }
    }
}
