using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vet_Lib
{
    public partial class DossierDetails : Form
    {
        // Déclaration du PictureBox
        private PictureBox PhotoDossier;

        public DossierDetails(
            string nom,
            string type,
            string sexe,
            string naissance,
            string arrivee,
            string adoption,
            byte[] photo)
        {
            InitializeComponent();
            InitializeCustomComponents();

            lblNom.Text = "Nom : " + nom;
            lblType.Text = "Type : " + type;
            lblSexe.Text = "Sexe : " + sexe;
            lblNaissance.Text = "Naissance : " + naissance;
            lblArrivee.Text = "Arrivée : " + arrivee;
            lblAdoption.Text = "Adoption : " + (adoption == "True" ? "Oui" : "Non");

            if (photo != null && photo.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(photo))
                {
                    PhotoDossier.Image = Image.FromStream(ms);
                }
            }
            else
            {
                PhotoDossier.Image = null;
                PhotoDossier.BackColor = Color.LightGray;
            }
        }

        // Méthode pour créer le PictureBox manuellement
        private void InitializeCustomComponents()
        {
            PhotoDossier = new PictureBox();
            PhotoDossier.Name = "PhotoDossier";
            //PhotoDossier.Size = new Size(160, 160); // Taille carrée élégante
            //PhotoDossier.Location = new Point((this.Width - PhotoDossier.Width) / 10, 40); // Centré horizontalement
            //PhotoDossier.SizeMode = PictureBoxSizeMode.Zoom;
            //PhotoDossier.BorderStyle = BorderStyle.FixedSingle;
            //PhotoDossier.BackColor = Color.White;
            //this.Controls.Add(PhotoDossier);

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

            //this.Controls.Add(PhotoDossier);
        }
    }
}
