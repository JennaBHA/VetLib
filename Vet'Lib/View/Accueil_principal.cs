using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Lib.View
{
    public partial class Accueil_principal : Form
    {
        public Accueil_principal()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Accueil_Click(object sender, EventArgs e)
        {

        }

        private void Animaux_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil_Connexion pageAccueil_Connexion = new Accueil_Connexion();
            pageAccueil_Connexion.Show();
        }

        private void Accueil_principal_Load(object sender, EventArgs e)
        {

        }
    }
}
