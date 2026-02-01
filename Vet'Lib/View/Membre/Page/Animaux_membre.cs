using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Vet_Lib.View.Class;
using System.Data.SqlClient;
using Vet_Lib.View.Membre.Connexion;
using Vet_Lib.View.Membre.Page;

namespace Vet_Lib.View.Membre.Page
{
    public partial class Animaux_membre : Form
    {
        private FlowLayoutPanel ListeAnimauxPanel;

        public Animaux_membre()
        {
            InitializeComponent();
            InitializeInterface();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Animaux_membre_Load(object sender, EventArgs e)
        {
            ListeAnimauxPanel.Controls.Clear();

            Fonction con = new Fonction();
            string requete = "SELECT * FROM Animaux WHERE EstAdopte = 0 ORDER BY DateArrivee DESC";
            DataTable dt = con.RecupererData(requete);

            foreach (DataRow row in dt.Rows)
            {
                ListeAnimauxPanel.Controls.Add(CreateAnimalCard(row));
            }

            // Message de bienvenue
            string nom = Adoptions_membre.SessionUtilisateur.Nom ?? "inconnu";
            this.Text = $"Bienvenue {nom} - Animaux disponibles";
        }

        private void InitializeInterface()
        {
            this.Size = new Size(953, 609);
            ListeAnimauxPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(70),
                BackColor = ColorTranslator.FromHtml("#FFF9E7"),
            };

            this.Controls.Add(ListeAnimauxPanel);
            this.Load += Animaux_membre_Load;
        }

        private Panel CreateAnimalCard(DataRow row)
        {
            Panel panelAnimal = new Panel
            {
                Size = new Size(230, 330),
                BackColor = ColorTranslator.FromHtml("#FFF9E7"),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Padding = new Padding(10)
            };

            PictureBox animauxPic = new PictureBox
            {
                Size = new Size(220, 160),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(0, 0)
            };

            if (row["Photo"] != DBNull.Value)
            {
                byte[] imageData = (byte[])row["Photo"];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    animauxPic.Image = Image.FromStream(ms);
                }
            }

            Label nomAnimal = new Label
            {
                Text = row["Nom"].ToString(),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.MediumVioletRed,
                AutoSize = false,
                Size = new Size(220, 25),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 165),
                BackColor = Color.Transparent,
            };

            Button voirBtn = new Button
            {
                Text = "Voir +",
                Size = new Size(100, 40),
                Location = new Point(10, 260),
                BackColor = Color.White,
            };
            voirBtn.Click += (s, ev) =>
            {
                var fiche = new FicheAnimal(row);
                fiche.ShowDialog();
            };

            bool estAdopte = Convert.ToBoolean(row["EstAdopte"]);
            Button adopterBtn = new Button
            {
                Text = "Adopter",
                Size = new Size(100, 40),
                Location = new Point(120, 260),
                Enabled = !estAdopte,
                BackColor = Color.White,
            };

            adopterBtn.Click += (s, ev) =>
            {
                int idAnimal = Convert.ToInt32(row["Id"]);
                int idMembre = Adoptions_membre.SessionUtilisateur.IdUtilisateur;

                if (idMembre == 0)
                {
                    MessageBox.Show("Aucun membre n'est connecté.", "Erreur d'adoption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show(
                    $"Voulez-vous adopter {row["Nom"]} ? ❤️",
                    "Confirmation d'adoption",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Fonction con = new Fonction();

                    string updateQuery = $"UPDATE Animaux SET EstAdopte = 1 WHERE Id = {idAnimal}";
                    con.ExecuterRequete(updateQuery);

                    string insertQuery = $@"
                        INSERT INTO Adoptions (IdAnimal, IdMembre, DateAdoption)
                        VALUES ({idAnimal}, {idMembre}, '{DateTime.Now:yyyy-MM-dd}')";
                    con.ExecuterRequete(insertQuery);

                    MessageBox.Show($"Félicitations 🎉 Tu as adopté {row["Nom"]} !", "Adoption validée");
                    Animaux_membre_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Pas de souci 😺 Tu peux toujours réfléchir !", "Adoption annulée");
                }
            };

            panelAnimal.Controls.Add(animauxPic);
            panelAnimal.Controls.Add(nomAnimal);
            panelAnimal.Controls.Add(voirBtn);
            panelAnimal.Controls.Add(adopterBtn);

            return panelAnimal;
        }

        //  Naviguer vers les autres pages


        private void Accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil_Membre Accueil_Membre = new Accueil_Membre();
            Accueil_Membre.Show();
        }

        private void AnimauxZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animaux_membre pageAnimaux = new Animaux_membre();
            pageAnimaux.Show();
        }

        private void Adoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptions_membre pageAdoptions = new Adoptions_membre();
            pageAdoptions.Show();
        }

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            Connexion_membre Connexion = new Connexion_membre();
            Connexion.Show();
            this.Hide();
        }

        private void Animaux_membre_Load_1(object sender, EventArgs e)
        {

        }
    }
}
