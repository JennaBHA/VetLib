namespace Vet_Lib
{
    partial class Adoptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adoptions));
            Supprimer = new Guna.UI2.WinForms.Guna2Button();
            AdoptionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            AdoptionsZ = new Button();
            Dossiers = new Button();
            Déconnexion = new Button();
            AdoptantsZ = new Button();
            AnimauxZ = new Button();
            Accueil = new Button();
            ((System.ComponentModel.ISupportInitialize)AdoptionsList).BeginInit();
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
            Supprimer.Location = new Point(910, 693);
            Supprimer.Margin = new Padding(3, 4, 3, 4);
            Supprimer.Name = "Supprimer";
            Supprimer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Supprimer.Size = new Size(127, 51);
            Supprimer.TabIndex = 19;
            Supprimer.Text = "Supprimer";
            Supprimer.Click += Supprimer_Click;
            // 
            // AdoptionsList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            AdoptionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AdoptionsList.BackgroundColor = Color.FromArgb(255, 249, 231);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AdoptionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AdoptionsList.ColumnHeadersHeight = 30;
            AdoptionsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AdoptionsList.DefaultCellStyle = dataGridViewCellStyle3;
            AdoptionsList.GridColor = Color.FromArgb(231, 229, 255);
            AdoptionsList.Location = new Point(14, 129);
            AdoptionsList.Margin = new Padding(3, 4, 3, 4);
            AdoptionsList.Name = "AdoptionsList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AdoptionsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AdoptionsList.RowHeadersVisible = false;
            AdoptionsList.RowHeadersWidth = 51;
            AdoptionsList.RowTemplate.Height = 30;
            AdoptionsList.Size = new Size(1043, 556);
            AdoptionsList.TabIndex = 0;
            AdoptionsList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            AdoptionsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            AdoptionsList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            AdoptionsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            AdoptionsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            AdoptionsList.ThemeStyle.BackColor = Color.FromArgb(255, 249, 231);
            AdoptionsList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            AdoptionsList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            AdoptionsList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            AdoptionsList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F);
            AdoptionsList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AdoptionsList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AdoptionsList.ThemeStyle.HeaderStyle.Height = 30;
            AdoptionsList.ThemeStyle.ReadOnly = false;
            AdoptionsList.ThemeStyle.RowsStyle.BackColor = Color.White;
            AdoptionsList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AdoptionsList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            AdoptionsList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            AdoptionsList.ThemeStyle.RowsStyle.Height = 30;
            AdoptionsList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            AdoptionsList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            AdoptionsList.CellContentClick += AdoptionsList_CellContentClick;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 10;
            guna2Elipse6.TargetControl = AdoptionsList;
            // 
            // AdoptionsZ
            // 
            AdoptionsZ.BackColor = Color.Transparent;
            AdoptionsZ.Cursor = Cursors.Hand;
            AdoptionsZ.FlatAppearance.BorderSize = 0;
            AdoptionsZ.FlatStyle = FlatStyle.Flat;
            AdoptionsZ.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            AdoptionsZ.ForeColor = Color.FromArgb(44, 62, 80);
            AdoptionsZ.Location = new Point(360, 5);
            AdoptionsZ.Margin = new Padding(3, 4, 3, 4);
            AdoptionsZ.Name = "AdoptionsZ";
            AdoptionsZ.Size = new Size(141, 48);
            AdoptionsZ.TabIndex = 41;
            AdoptionsZ.Text = "Adoptions";
            AdoptionsZ.UseVisualStyleBackColor = false;
            AdoptionsZ.Click += AdoptionsZ_Click;
            // 
            // Dossiers
            // 
            Dossiers.BackColor = Color.Transparent;
            Dossiers.Cursor = Cursors.Hand;
            Dossiers.FlatAppearance.BorderSize = 0;
            Dossiers.FlatStyle = FlatStyle.Flat;
            Dossiers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Dossiers.ForeColor = Color.FromArgb(44, 62, 80);
            Dossiers.Location = new Point(495, 5);
            Dossiers.Margin = new Padding(3, 4, 3, 4);
            Dossiers.Name = "Dossiers";
            Dossiers.Size = new Size(132, 48);
            Dossiers.TabIndex = 40;
            Dossiers.Text = "Dossiers";
            Dossiers.UseVisualStyleBackColor = false;
            Dossiers.Click += Dossiers_Click;
            // 
            // Déconnexion
            // 
            Déconnexion.BackColor = Color.Transparent;
            Déconnexion.Cursor = Cursors.Hand;
            Déconnexion.FlatAppearance.BorderSize = 0;
            Déconnexion.FlatStyle = FlatStyle.Flat;
            Déconnexion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Déconnexion.ForeColor = Color.FromArgb(44, 62, 80);
            Déconnexion.Location = new Point(889, 0);
            Déconnexion.Margin = new Padding(3, 4, 3, 4);
            Déconnexion.Name = "Déconnexion";
            Déconnexion.Size = new Size(177, 48);
            Déconnexion.TabIndex = 39;
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
            AdoptantsZ.Location = new Point(215, 5);
            AdoptantsZ.Margin = new Padding(3, 4, 3, 4);
            AdoptantsZ.Name = "AdoptantsZ";
            AdoptantsZ.Size = new Size(151, 48);
            AdoptantsZ.TabIndex = 38;
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
            AnimauxZ.Location = new Point(98, 5);
            AnimauxZ.Margin = new Padding(3, 4, 3, 4);
            AnimauxZ.Name = "AnimauxZ";
            AnimauxZ.Size = new Size(129, 48);
            AnimauxZ.TabIndex = 37;
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
            Accueil.Location = new Point(-5, 5);
            Accueil.Margin = new Padding(3, 4, 3, 4);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(112, 48);
            Accueil.TabIndex = 36;
            Accueil.Text = "Accueil";
            Accueil.UseVisualStyleBackColor = false;
            Accueil.Click += Accueil_Click;
            // 
            // Adoptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 231);
            ClientSize = new Size(1071, 760);
            Controls.Add(AdoptionsZ);
            Controls.Add(Dossiers);
            Controls.Add(Déconnexion);
            Controls.Add(AdoptantsZ);
            Controls.Add(AnimauxZ);
            Controls.Add(Accueil);
            Controls.Add(AdoptionsList);
            Controls.Add(Supprimer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Adoptions";
            Text = "Adoptions";
            Load += Adoptions_Load;
            ((System.ComponentModel.ISupportInitialize)AdoptionsList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Supprimer;
        private Guna.UI2.WinForms.Guna2DataGridView AdoptionsList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Button AdoptionsZ;
        private Button Dossiers;
        private Button Déconnexion;
        private Button AdoptantsZ;
        private Button AnimauxZ;
        private Button Accueil;
    }
}