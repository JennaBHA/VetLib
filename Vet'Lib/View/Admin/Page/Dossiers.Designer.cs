namespace Vet_Lib
{
    partial class Dossiers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dossiers));
            Supprimer = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            DossierList = new Guna.UI2.WinForms.Guna2DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            AdoptionsZ = new Button();
            DossiersZ = new Button();
            Déconnexion = new Button();
            AdoptantsZ = new Button();
            AnimauxZ = new Button();
            Accueil = new Button();
            ((System.ComponentModel.ISupportInitialize)DossierList).BeginInit();
            SuspendLayout();
            // 
            // Supprimer
            // 
            Supprimer.BackColor = Color.Transparent;
            Supprimer.BorderColor = Color.FromArgb(110, 168, 162);
            Supprimer.BorderRadius = 10;
            Supprimer.CustomizableEdges = customizableEdges1;
            Supprimer.DisabledState.BorderColor = Color.DarkGray;
            Supprimer.DisabledState.CustomBorderColor = Color.DarkGray;
            Supprimer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Supprimer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Supprimer.FillColor = Color.FromArgb(110, 168, 162);
            Supprimer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Supprimer.ForeColor = Color.White;
            Supprimer.Location = new Point(905, 681);
            Supprimer.Margin = new Padding(3, 4, 3, 4);
            Supprimer.Name = "Supprimer";
            Supprimer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Supprimer.Size = new Size(127, 51);
            Supprimer.TabIndex = 19;
            Supprimer.Text = "Supprimer";
            Supprimer.Click += Supprimer_Click;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 10;
            guna2Elipse6.TargetControl = DossierList;
            // 
            // DossierList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DossierList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DossierList.BackgroundColor = Color.FromArgb(255, 249, 231);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DossierList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DossierList.ColumnHeadersHeight = 30;
            DossierList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DossierList.DefaultCellStyle = dataGridViewCellStyle3;
            DossierList.GridColor = Color.FromArgb(231, 229, 255);
            DossierList.Location = new Point(14, 124);
            DossierList.Margin = new Padding(3, 4, 3, 4);
            DossierList.Name = "DossierList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DossierList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DossierList.RowHeadersVisible = false;
            DossierList.RowHeadersWidth = 51;
            DossierList.RowTemplate.Height = 30;
            DossierList.Size = new Size(1043, 529);
            DossierList.TabIndex = 0;
            DossierList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DossierList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DossierList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DossierList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DossierList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DossierList.ThemeStyle.BackColor = Color.FromArgb(255, 249, 231);
            DossierList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DossierList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DossierList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DossierList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F);
            DossierList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DossierList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DossierList.ThemeStyle.HeaderStyle.Height = 30;
            DossierList.ThemeStyle.ReadOnly = false;
            DossierList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DossierList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DossierList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DossierList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DossierList.ThemeStyle.RowsStyle.Height = 30;
            DossierList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DossierList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DossierList.CellContentClick += DossierList_CellContentClick;
            // 
            // AdoptionsZ
            // 
            AdoptionsZ.BackColor = Color.Transparent;
            AdoptionsZ.Cursor = Cursors.Hand;
            AdoptionsZ.FlatAppearance.BorderSize = 0;
            AdoptionsZ.FlatStyle = FlatStyle.Flat;
            AdoptionsZ.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            AdoptionsZ.ForeColor = Color.FromArgb(44, 62, 80);
            AdoptionsZ.Location = new Point(356, 5);
            AdoptionsZ.Margin = new Padding(3, 4, 3, 4);
            AdoptionsZ.Name = "AdoptionsZ";
            AdoptionsZ.Size = new Size(155, 48);
            AdoptionsZ.TabIndex = 47;
            AdoptionsZ.Text = "Adoptions";
            AdoptionsZ.UseVisualStyleBackColor = false;
            AdoptionsZ.Click += AdoptionsZ_Click;
            // 
            // DossiersZ
            // 
            DossiersZ.BackColor = Color.Transparent;
            DossiersZ.Cursor = Cursors.Hand;
            DossiersZ.FlatAppearance.BorderSize = 0;
            DossiersZ.FlatStyle = FlatStyle.Flat;
            DossiersZ.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            DossiersZ.ForeColor = Color.FromArgb(44, 62, 80);
            DossiersZ.Location = new Point(509, 5);
            DossiersZ.Margin = new Padding(3, 4, 3, 4);
            DossiersZ.Name = "DossiersZ";
            DossiersZ.Size = new Size(127, 48);
            DossiersZ.TabIndex = 46;
            DossiersZ.Text = "Dossiers";
            DossiersZ.UseVisualStyleBackColor = false;
            DossiersZ.Click += DossiersZ_Click;
            // 
            // Déconnexion
            // 
            Déconnexion.BackColor = Color.Transparent;
            Déconnexion.Cursor = Cursors.Hand;
            Déconnexion.FlatAppearance.BorderSize = 0;
            Déconnexion.FlatStyle = FlatStyle.Flat;
            Déconnexion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Déconnexion.ForeColor = Color.FromArgb(44, 62, 80);
            Déconnexion.Location = new Point(893, 0);
            Déconnexion.Margin = new Padding(3, 4, 3, 4);
            Déconnexion.Name = "Déconnexion";
            Déconnexion.Size = new Size(177, 48);
            Déconnexion.TabIndex = 45;
            Déconnexion.Text = "Déconnexion";
            Déconnexion.UseVisualStyleBackColor = false;
            Déconnexion.Click += Déconnexion_Click;
            // 
            // AdoptantsZ
            // 
            AdoptantsZ.BackColor = Color.Transparent;
            AdoptantsZ.Cursor = Cursors.Hand;
            AdoptantsZ.FlatAppearance.BorderSize = 0;
            AdoptantsZ.FlatStyle = FlatStyle.Flat;
            AdoptantsZ.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            AdoptantsZ.ForeColor = Color.FromArgb(44, 62, 80);
            AdoptantsZ.Location = new Point(218, 5);
            AdoptantsZ.Margin = new Padding(3, 4, 3, 4);
            AdoptantsZ.Name = "AdoptantsZ";
            AdoptantsZ.Size = new Size(142, 48);
            AdoptantsZ.TabIndex = 44;
            AdoptantsZ.Text = "Adoptants";
            AdoptantsZ.UseVisualStyleBackColor = false;
            AdoptantsZ.Click += AdoptantsZ_Click;
            // 
            // AnimauxZ
            // 
            AnimauxZ.BackColor = Color.Transparent;
            AnimauxZ.Cursor = Cursors.Hand;
            AnimauxZ.FlatAppearance.BorderSize = 0;
            AnimauxZ.FlatStyle = FlatStyle.Flat;
            AnimauxZ.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            AnimauxZ.ForeColor = Color.FromArgb(44, 62, 80);
            AnimauxZ.Location = new Point(96, 5);
            AnimauxZ.Margin = new Padding(3, 4, 3, 4);
            AnimauxZ.Name = "AnimauxZ";
            AnimauxZ.Size = new Size(142, 48);
            AnimauxZ.TabIndex = 43;
            AnimauxZ.Text = "Animaux";
            AnimauxZ.UseVisualStyleBackColor = false;
            AnimauxZ.Click += AnimauxZ_Click;
            // 
            // Accueil
            // 
            Accueil.BackColor = Color.Transparent;
            Accueil.Cursor = Cursors.Hand;
            Accueil.FlatAppearance.BorderSize = 0;
            Accueil.FlatStyle = FlatStyle.Flat;
            Accueil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Accueil.ForeColor = Color.FromArgb(44, 62, 80);
            Accueil.Location = new Point(-1, 5);
            Accueil.Margin = new Padding(3, 4, 3, 4);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(112, 48);
            Accueil.TabIndex = 42;
            Accueil.Text = "Accueil";
            Accueil.UseVisualStyleBackColor = false;
            Accueil.Click += Accueil_Click;
            // 
            // Dossiers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 231);
            ClientSize = new Size(1071, 760);
            Controls.Add(AdoptionsZ);
            Controls.Add(DossiersZ);
            Controls.Add(Déconnexion);
            Controls.Add(AdoptantsZ);
            Controls.Add(AnimauxZ);
            Controls.Add(Accueil);
            Controls.Add(Supprimer);
            Controls.Add(DossierList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dossiers";
            Text = "Dossiers";
            ((System.ComponentModel.ISupportInitialize)DossierList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Button Supprimer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2DataGridView DossierList;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Button AdoptionsZ;
        private Button DossiersZ;
        private Button Déconnexion;
        private Button AdoptantsZ;
        private Button AnimauxZ;
        private Button Accueil;
    }
}