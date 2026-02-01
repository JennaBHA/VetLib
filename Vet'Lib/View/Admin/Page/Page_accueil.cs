using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Lib
{
    // Classe principale représentant la page d’accueil de l’application
    public partial class Page_accueil : Form
    {
        // Constructeur du formulaire
        public Page_accueil()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Page_accueil_Load(object sender, EventArgs e){ }

        // Événements vide
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }


        // Méthode permettant de se déconnecter et retourner au formulaire de connexion
        private void Deconnexion_Click(object sender, EventArgs e)
        {
            FormTop formTop = new FormTop();
            formTop.Show();
            this.Hide();
        }

        // Navigation vers les autres pages
        private void Accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Page_accueil pageAccueil = new Page_accueil();
            pageAccueil.Show();
        }

        private void Adoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptions pageAdoption = new Adoptions();
            pageAdoption.Show();
        }

        private void Animaux_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animaux pageAnimaux = new Animaux();
            pageAnimaux.Show();
        }

        private void Adoptants_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptants pageAdoptants = new Adoptants();
            pageAdoptants.Show();
        }

        private void Dossiers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dossiers pageDossiers = new Dossiers();
            pageDossiers.Show();
        }
    }
    public partial class Déconnexion : Form
    {
        public Déconnexion()
        {

        }
    }
}
