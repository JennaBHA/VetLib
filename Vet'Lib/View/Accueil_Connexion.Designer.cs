namespace Vet_Lib
{
    partial class Accueil_Connexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil_Connexion));
            ConnexionZT = new Button();
            IscriptionZT = new Button();
            AdminZT = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // ConnexionZT
            // 
            ConnexionZT.BackColor = Color.FromArgb(110, 168, 162);
            ConnexionZT.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            ConnexionZT.ForeColor = Color.White;
            ConnexionZT.Location = new Point(59, 431);
            ConnexionZT.Margin = new Padding(3, 4, 3, 4);
            ConnexionZT.Name = "ConnexionZT";
            ConnexionZT.Size = new Size(272, 65);
            ConnexionZT.TabIndex = 8;
            ConnexionZT.Text = "Connexion";
            ConnexionZT.UseVisualStyleBackColor = false;
            ConnexionZT.Click += ConnexionZT_Click;
            // 
            // IscriptionZT
            // 
            IscriptionZT.BackColor = Color.FromArgb(110, 168, 162);
            IscriptionZT.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            IscriptionZT.ForeColor = Color.White;
            IscriptionZT.Location = new Point(59, 504);
            IscriptionZT.Margin = new Padding(3, 4, 3, 4);
            IscriptionZT.Name = "IscriptionZT";
            IscriptionZT.Size = new Size(272, 65);
            IscriptionZT.TabIndex = 9;
            IscriptionZT.Text = "Inscription";
            IscriptionZT.UseVisualStyleBackColor = false;
            IscriptionZT.Click += IscriptionZT_Click;
            // 
            // AdminZT
            // 
            AdminZT.BackColor = Color.FromArgb(110, 168, 162);
            AdminZT.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            AdminZT.ForeColor = Color.White;
            AdminZT.Location = new Point(59, 577);
            AdminZT.Margin = new Padding(3, 4, 3, 4);
            AdminZT.Name = "AdminZT";
            AdminZT.Size = new Size(272, 65);
            AdminZT.TabIndex = 10;
            AdminZT.Text = "Espace admin";
            AdminZT.UseVisualStyleBackColor = false;
            AdminZT.Click += AdminZT_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 40;
            guna2Elipse1.TargetControl = AdminZT;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 40;
            guna2Elipse2.TargetControl = AdminZT;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 40;
            guna2Elipse3.TargetControl = ConnexionZT;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 40;
            guna2Elipse4.TargetControl = IscriptionZT;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(158, 647);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 28);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Retour";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Accueil_Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 246, 239);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 703);
            Controls.Add(linkLabel1);
            Controls.Add(AdminZT);
            Controls.Add(IscriptionZT);
            Controls.Add(ConnexionZT);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Accueil_Connexion";
            Text = "Accueil_Appli";
            Load += Accueil_Appli_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnexionZT;
        private Button IscriptionZT;
        private Button AdminZT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private LinkLabel linkLabel1;
    }
}