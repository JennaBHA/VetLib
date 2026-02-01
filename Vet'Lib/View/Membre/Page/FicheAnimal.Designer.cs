using System.Drawing;
using System.Windows.Forms;

namespace Vet_Lib.View.Membre.Page
{
    partial class FicheAnimal
    {
        private System.ComponentModel.IContainer components = null;

        private Label nomLabel, typeLabel, sexeLabel, naissanceLabel, arriveeLabel, adoptionLabel;
        private PictureBox photoBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nomLabel = new Label();
            typeLabel = new Label();
            sexeLabel = new Label();
            naissanceLabel = new Label();
            arriveeLabel = new Label();
            adoptionLabel = new Label();
            photoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)photoBox).BeginInit();
            SuspendLayout();
            // 
            // nomLabel
            // 
            nomLabel.Location = new Point(0, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new Size(100, 23);
            nomLabel.TabIndex = 0;
            // 
            // typeLabel
            // 
            typeLabel.Location = new Point(0, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(100, 23);
            typeLabel.TabIndex = 1;
            // 
            // sexeLabel
            // 
            sexeLabel.Location = new Point(0, 0);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new Size(100, 23);
            sexeLabel.TabIndex = 2;
            // 
            // naissanceLabel
            // 
            naissanceLabel.Location = new Point(0, 0);
            naissanceLabel.Name = "naissanceLabel";
            naissanceLabel.Size = new Size(100, 23);
            naissanceLabel.TabIndex = 3;
            // 
            // arriveeLabel
            // 
            arriveeLabel.Location = new Point(0, 0);
            arriveeLabel.Name = "arriveeLabel";
            arriveeLabel.Size = new Size(100, 23);
            arriveeLabel.TabIndex = 4;
            // 
            // adoptionLabel
            // 
            adoptionLabel.Location = new Point(0, 0);
            adoptionLabel.Name = "adoptionLabel";
            adoptionLabel.Size = new Size(100, 23);
            adoptionLabel.TabIndex = 5;
            // 
            // photoBox
            // 
            photoBox.Location = new Point(0, 0);
            photoBox.Name = "photoBox";
            photoBox.Size = new Size(100, 50);
            photoBox.TabIndex = 6;
            photoBox.TabStop = false;
            // 
            // FicheAnimal
            // 
            ClientSize = new Size(404, 321);
            Controls.Add(nomLabel);
            Controls.Add(typeLabel);
            Controls.Add(sexeLabel);
            Controls.Add(naissanceLabel);
            Controls.Add(arriveeLabel);
            Controls.Add(adoptionLabel);
            Controls.Add(photoBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FicheAnimal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dossier de l'animal";
            Load += FicheAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)photoBox).EndInit();
            ResumeLayout(false);
        }
    }
}
