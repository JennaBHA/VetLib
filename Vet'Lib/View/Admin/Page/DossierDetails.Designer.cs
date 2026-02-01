namespace Vet_Lib
{
    partial class DossierDetails
    {
        private System.ComponentModel.IContainer components = null;

        // Déclaration des labels
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Label lblAdoption;
        private System.Windows.Forms.Button btnFermer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNom = new Label();
            lblType = new Label();
            lblSexe = new Label();
            lblNaissance = new Label();
            lblArrivee = new Label();
            lblAdoption = new Label();
            btnFermer = new Button();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.Font = new Font("Segoe UI", 10F);
            lblNom.Location = new Point(30, 30);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(199, 25);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom : ";
            // 
            // lblType
            // 
            lblType.Font = new Font("Segoe UI", 10F);
            lblType.Location = new Point(30, 60);
            lblType.Name = "lblType";
            lblType.Size = new Size(199, 25);
            lblType.TabIndex = 1;
            lblType.Text = "Type : ";
            // 
            // lblSexe
            // 
            lblSexe.Font = new Font("Segoe UI", 10F);
            lblSexe.Location = new Point(30, 90);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new Size(199, 25);
            lblSexe.TabIndex = 2;
            lblSexe.Text = "Sexe : ";
            // 
            // lblNaissance
            // 
            lblNaissance.Font = new Font("Segoe UI", 10F);
            lblNaissance.Location = new Point(30, 120);
            lblNaissance.Name = "lblNaissance";
            lblNaissance.Size = new Size(199, 25);
            lblNaissance.TabIndex = 3;
            lblNaissance.Text = "Date de naissance : ";
            // 
            // lblArrivee
            // 
            lblArrivee.Font = new Font("Segoe UI", 10F);
            lblArrivee.Location = new Point(30, 150);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(199, 25);
            lblArrivee.TabIndex = 4;
            lblArrivee.Text = "Date d’arrivée : ";
            // 
            // lblAdoption
            // 
            lblAdoption.Font = new Font("Segoe UI", 10F);
            lblAdoption.Location = new Point(30, 180);
            lblAdoption.Name = "lblAdoption";
            lblAdoption.Size = new Size(199, 25);
            lblAdoption.TabIndex = 5;
            lblAdoption.Text = "Adoption : ";
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(287, 32);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(151, 173);
            btnFermer.TabIndex = 6;
            btnFermer.Click += btnFermer_Click;
            // 
            // DossierDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            Controls.Add(lblNom);
            Controls.Add(lblType);
            Controls.Add(lblSexe);
            Controls.Add(lblNaissance);
            Controls.Add(lblArrivee);
            Controls.Add(lblAdoption);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DossierDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dossier de l'animal";
            ResumeLayout(false);
        }
    }
}
