using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vet_Lib.View.Membre.Connexion;
using Vet_Lib.View.Membre.Page;

namespace Vet_Lib
{
    public partial class Accueil_Membre : Form
    {
        public Accueil_Membre()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil_Membre pageAccueil_Membre = new Accueil_Membre();
            pageAccueil_Membre.Show();
        }

        private void Animaux_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animaux_membre pageAnimaux_membre = new Animaux_membre();
            pageAnimaux_membre.Show();
        }

        private void Adoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptions_membre pageAdoptions_membre = new Adoptions_membre();
            pageAdoptions_membre.Show();
        }

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            Connexion_membre Connexion_membre = new Connexion_membre();
            Connexion_membre.Show();
            this.Hide();
        }

        private void Accueil_Membre_Load(object sender, EventArgs e)
        {

        }
    }
}
