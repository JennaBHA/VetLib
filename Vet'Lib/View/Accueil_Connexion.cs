using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vet_Lib.View;
using Vet_Lib.View.Membre;
using Vet_Lib.View.Membre.Connexion;

namespace Vet_Lib
{
    public partial class Accueil_Connexion : Form
    {
        public Accueil_Connexion()
        {
            InitializeComponent();
            this.Load += Accueil_Appli_Load;

            // Empêcher l’agrandissement et le redimensionnement :
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Accueil_Appli_Load(object sender, EventArgs e)
        {

        }

        private void ConnexionZT_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this.Hide();
            Connexion_membre pageConnexion = new Connexion_membre();
            pageConnexion.Show();
        }

        private void IscriptionZT_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this.Hide();
            Inscription pageInscription = new Inscription();
            pageInscription.Show();
        }

        private void AdminZT_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this.Hide();
            FormTop pageFormTop = new FormTop();
            pageFormTop.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Accueil_principal pageAccueil_principal = new Accueil_principal();
            pageAccueil_principal.Show();
        }
    }
}
