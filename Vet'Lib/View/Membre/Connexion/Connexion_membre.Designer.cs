namespace Vet_Lib.View.Membre.Connexion
{
    partial class Connexion_membre
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion_membre));
            ConnexionYT = new Button();
            MdpZTT = new Guna.UI2.WinForms.Guna2TextBox();
            EmailZT = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // ConnexionYT
            // 
            ConnexionYT.BackColor = Color.FromArgb(110, 168, 162);
            ConnexionYT.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            ConnexionYT.ForeColor = Color.White;
            ConnexionYT.Location = new Point(58, 421);
            ConnexionYT.Name = "ConnexionYT";
            ConnexionYT.Size = new Size(238, 49);
            ConnexionYT.TabIndex = 14;
            ConnexionYT.Text = "Se connecter";
            ConnexionYT.UseVisualStyleBackColor = false;
            ConnexionYT.Click += ConnexionYT_Click;
            // 
            // MdpZTT
            // 
            MdpZTT.BorderColor = Color.FromArgb(177, 105, 28);
            MdpZTT.BorderThickness = 2;
            MdpZTT.CustomizableEdges = customizableEdges1;
            MdpZTT.DefaultText = "";
            MdpZTT.FillColor = Color.FromArgb(253, 246, 239);
            MdpZTT.Font = new Font("Microsoft Sans Serif", 12F);
            MdpZTT.ForeColor = Color.FromArgb(74, 74, 74);
            MdpZTT.Location = new Point(58, 378);
            MdpZTT.Name = "MdpZTT";
            MdpZTT.PlaceholderForeColor = Color.Gray;
            MdpZTT.PlaceholderText = "Mot de passe";
            MdpZTT.SelectedText = "";
            MdpZTT.ShadowDecoration.CustomizableEdges = customizableEdges2;
            MdpZTT.Size = new Size(237, 37);
            MdpZTT.TabIndex = 16;
            // 
            // EmailZT
            // 
            EmailZT.BorderColor = Color.FromArgb(177, 105, 28);
            EmailZT.BorderThickness = 2;
            EmailZT.CustomizableEdges = customizableEdges3;
            EmailZT.DefaultText = "";
            EmailZT.FillColor = Color.FromArgb(253, 246, 239);
            EmailZT.Font = new Font("Microsoft Sans Serif", 12F);
            EmailZT.ForeColor = Color.FromArgb(74, 74, 74);
            EmailZT.Location = new Point(58, 335);
            EmailZT.Name = "EmailZT";
            EmailZT.PlaceholderForeColor = Color.Gray;
            EmailZT.PlaceholderText = "Email";
            EmailZT.SelectedText = "";
            EmailZT.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EmailZT.Size = new Size(238, 37);
            EmailZT.TabIndex = 15;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 40;
            guna2Elipse1.TargetControl = ConnexionYT;
            // 
            // button1
            // 
            button1.Location = new Point(256, 386);
            button1.Name = "button1";
            button1.Size = new Size(30, 21);
            button1.TabIndex = 24;
            button1.Text = "AfficherMdpBTN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(142, 473);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 21);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Retour";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Connexion_membre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(350, 527);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(ConnexionYT);
            Controls.Add(MdpZTT);
            Controls.Add(EmailZT);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Connexion_membre";
            Text = "Connexion";
            Load += Connexion_membre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnexionYT;
        private Guna.UI2.WinForms.Guna2TextBox MdpZTT;
        private Guna.UI2.WinForms.Guna2TextBox EmailZT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}