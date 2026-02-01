namespace Vet_Lib
{
    partial class FormTop
    {
        private System.ComponentModel.IContainer components = null;
        private Button ConnexionZT;
        private LinkLabel Button_reintialiser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox IdentifiantZT;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTop));
            ConnexionZT = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            IdentifiantZT = new Guna.UI2.WinForms.Guna2TextBox();
            MdpZT = new Guna.UI2.WinForms.Guna2TextBox();
            Accueil = new LinkLabel();
            SuspendLayout();
            // 
            // ConnexionZT
            // 
            ConnexionZT.BackColor = Color.FromArgb(110, 168, 162);
            ConnexionZT.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            ConnexionZT.ForeColor = Color.White;
            ConnexionZT.Location = new Point(60, 456);
            ConnexionZT.Name = "ConnexionZT";
            ConnexionZT.Size = new Size(238, 49);
            ConnexionZT.TabIndex = 7;
            ConnexionZT.Text = "Se connecter";
            ConnexionZT.UseVisualStyleBackColor = false;
            ConnexionZT.Click += button1_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 40;
            guna2Elipse1.TargetControl = ConnexionZT;
            // 
            // IdentifiantZT
            // 
            IdentifiantZT.BorderColor = Color.FromArgb(177, 105, 28);
            IdentifiantZT.BorderThickness = 2;
            IdentifiantZT.CustomizableEdges = customizableEdges1;
            IdentifiantZT.DefaultText = "";
            IdentifiantZT.FillColor = Color.FromArgb(253, 246, 239);
            IdentifiantZT.Font = new Font("Microsoft Sans Serif", 12F);
            IdentifiantZT.ForeColor = Color.FromArgb(74, 74, 74);
            IdentifiantZT.Location = new Point(60, 370);
            IdentifiantZT.Name = "IdentifiantZT";
            IdentifiantZT.PlaceholderForeColor = Color.Gray;
            IdentifiantZT.PlaceholderText = "Identifiant";
            IdentifiantZT.SelectedText = "";
            IdentifiantZT.ShadowDecoration.CustomizableEdges = customizableEdges2;
            IdentifiantZT.Size = new Size(238, 37);
            IdentifiantZT.TabIndex = 12;
            IdentifiantZT.TextChanged += guna2TextBox1_TextChanged;
            // 
            // MdpZT
            // 
            MdpZT.BorderColor = Color.FromArgb(177, 105, 28);
            MdpZT.BorderThickness = 2;
            MdpZT.CustomizableEdges = customizableEdges3;
            MdpZT.DefaultText = "";
            MdpZT.FillColor = Color.FromArgb(253, 246, 239);
            MdpZT.Font = new Font("Microsoft Sans Serif", 12F);
            MdpZT.ForeColor = Color.FromArgb(74, 74, 74);
            MdpZT.Location = new Point(60, 413);
            MdpZT.Name = "MdpZT";
            MdpZT.PlaceholderForeColor = Color.Gray;
            MdpZT.PlaceholderText = "Mot de passe";
            MdpZT.SelectedText = "";
            MdpZT.ShadowDecoration.CustomizableEdges = customizableEdges4;
            MdpZT.Size = new Size(237, 37);
            MdpZT.TabIndex = 13;
            MdpZT.TextChanged += guna2TextBox2_TextChanged;
            // 
            // Accueil
            // 
            Accueil.AutoSize = true;
            Accueil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Accueil.LinkColor = Color.Black;
            Accueil.Location = new Point(147, 508);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(61, 21);
            Accueil.TabIndex = 14;
            Accueil.TabStop = true;
            Accueil.Text = "Retour";
            Accueil.TextAlign = ContentAlignment.TopCenter;
            Accueil.LinkClicked += Accueil_LinkClicked;
            // 
            // FormTop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 246, 239);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(366, 566);
            Controls.Add(Accueil);
            Controls.Add(ConnexionZT);
            Controls.Add(MdpZT);
            Controls.Add(IdentifiantZT);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTop";
            Text = "FormTop";
            Load += FormTop_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }
        private Guna.UI2.WinForms.Guna2TextBox MdpZT;
        private LinkLabel Accueil;
    }
}
