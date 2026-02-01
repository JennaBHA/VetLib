using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vet_Lib.View.Membre.Page
{
    public partial class FicheAnimal : Form
    {
        private DataRow row;

        public FicheAnimal(DataRow dataRow)
        {
            row = dataRow;
            InitializeComponent();
            RemplirInfos();
        }

        private void RemplirInfos()
        {
            nomLabel.Text = "Nom : " + row["Nom"];
            typeLabel.Text = "Type : " + row["Type"];
            sexeLabel.Text = "Sexe : " + row["Sexe"];
            naissanceLabel.Text = "Naissance : " + Convert.ToDateTime(row["DateNaissance"]).ToShortDateString();
            arriveeLabel.Text = "Arrivée : " + Convert.ToDateTime(row["DateArrivee"]).ToString();
            adoptionLabel.Text = "Adopté : " + (Convert.ToBoolean(row["EstAdopte"]) ? "Oui" : "Non");

            if (row["Photo"] != DBNull.Value)
            {
                byte[] imageData = (byte[])row["Photo"];
                using MemoryStream ms = new MemoryStream(imageData);
                photoBox.Image = Image.FromStream(ms);
            }
        }

        private void FicheAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
