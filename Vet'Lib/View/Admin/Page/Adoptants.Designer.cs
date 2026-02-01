namespace Vet_Lib
{
    partial class Adoptants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adoptants));
            Supprimer = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            AdoptantsList = new Guna.UI2.WinForms.Guna2DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Adoptions = new Button();
            Dossiers = new Button();
            Déconnexion = new Button();
            AdoptantsZ = new Button();
            AnimauxZ = new Button();
            Accueil = new Button();
            ((System.ComponentModel.ISupportInitialize)AdoptantsList).BeginInit();
            SuspendLayout();
            // 
            // Supprimer
            // 
            Supprimer.BackColor = Color.Transparent;
            Supprimer.BorderColor = Color.Transparent;
            Supprimer.BorderRadius = 10;
            Supprimer.CustomizableEdges = customizableEdges1;
            Supprimer.DisabledState.BorderColor = Color.DarkGray;
            Supprimer.DisabledState.CustomBorderColor = Color.DarkGray;
            Supprimer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Supprimer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Supprimer.FillColor = Color.FromArgb(110, 168, 162);
            Supprimer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Supprimer.ForeColor = Color.White;
            Supprimer.Location = new Point(912, 693);
            Supprimer.Margin = new Padding(3, 4, 3, 4);
            Supprimer.Name = "Supprimer";
            Supprimer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Supprimer.Size = new Size(127, 51);
            Supprimer.TabIndex = 19;
            Supprimer.Text = "Supprimer";
            Supprimer.Click += Supprimer_Click_1;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 10;
            guna2Elipse6.TargetControl = AdoptantsList;
            // 
            // AdoptantsList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(127, 207, 159);
            AdoptantsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AdoptantsList.BackgroundColor = Color.FromArgb(255, 249, 231);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AdoptantsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AdoptantsList.ColumnHeadersHeight = 30;
            AdoptantsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AdoptantsList.DefaultCellStyle = dataGridViewCellStyle3;
            AdoptantsList.GridColor = Color.FromArgb(231, 229, 255);
            AdoptantsList.Location = new Point(14, 99);
            AdoptantsList.Margin = new Padding(3, 4, 3, 4);
            AdoptantsList.Name = "AdoptantsList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(127, 207, 159);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AdoptantsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AdoptantsList.RowHeadersVisible = false;
            AdoptantsList.RowHeadersWidth = 51;
            AdoptantsList.RowTemplate.Height = 30;
            AdoptantsList.Size = new Size(1043, 573);
            AdoptantsList.TabIndex = 0;
            AdoptantsList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            AdoptantsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            AdoptantsList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            AdoptantsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            AdoptantsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            AdoptantsList.ThemeStyle.BackColor = Color.FromArgb(255, 249, 231);
            AdoptantsList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            AdoptantsList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            AdoptantsList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            AdoptantsList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F);
            AdoptantsList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AdoptantsList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AdoptantsList.ThemeStyle.HeaderStyle.Height = 30;
            AdoptantsList.ThemeStyle.ReadOnly = false;
            AdoptantsList.ThemeStyle.RowsStyle.BackColor = Color.White;
            AdoptantsList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AdoptantsList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            AdoptantsList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            AdoptantsList.ThemeStyle.RowsStyle.Height = 30;
            AdoptantsList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            AdoptantsList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            AdoptantsList.CellContentClick += AdoptantsList_CellContentClick_1;
            // 
            // Adoptions
            // 
            Adoptions.BackColor = Color.Transparent;
            Adoptions.Cursor = Cursors.Hand;
            Adoptions.FlatAppearance.BorderSize = 0;
            Adoptions.FlatStyle = FlatStyle.Flat;
            Adoptions.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Adoptions.ForeColor = Color.FromArgb(44, 62, 80);
            Adoptions.Location = new Point(371, 5);
            Adoptions.Margin = new Padding(3, 4, 3, 4);
            Adoptions.Name = "Adoptions";
            Adoptions.Size = new Size(158, 48);
            Adoptions.TabIndex = 35;
            Adoptions.Text = "Adoptions";
            Adoptions.UseVisualStyleBackColor = false;
            Adoptions.Click += Adoptions_Click;
            // 
            // Dossiers
            // 
            Dossiers.BackColor = Color.Transparent;
            Dossiers.Cursor = Cursors.Hand;
            Dossiers.FlatAppearance.BorderSize = 0;
            Dossiers.FlatStyle = FlatStyle.Flat;
            Dossiers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Dossiers.ForeColor = Color.FromArgb(44, 62, 80);
            Dossiers.Location = new Point(524, 5);
            Dossiers.Margin = new Padding(3, 4, 3, 4);
            Dossiers.Name = "Dossiers";
            Dossiers.Size = new Size(147, 48);
            Dossiers.TabIndex = 34;
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
            Déconnexion.Location = new Point(896, 7);
            Déconnexion.Margin = new Padding(3, 4, 3, 4);
            Déconnexion.Name = "Déconnexion";
            Déconnexion.Size = new Size(177, 48);
            Déconnexion.TabIndex = 33;
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
            AdoptantsZ.Location = new Point(227, 5);
            AdoptantsZ.Margin = new Padding(3, 4, 3, 4);
            AdoptantsZ.Name = "AdoptantsZ";
            AdoptantsZ.Size = new Size(154, 48);
            AdoptantsZ.TabIndex = 32;
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
            AnimauxZ.Size = new Size(139, 48);
            AnimauxZ.TabIndex = 31;
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
            Accueil.Location = new Point(2, 5);
            Accueil.Margin = new Padding(3, 4, 3, 4);
            Accueil.Name = "Accueil";
            Accueil.Size = new Size(112, 48);
            Accueil.TabIndex = 30;
            Accueil.Text = "Accueil";
            Accueil.UseVisualStyleBackColor = false;
            Accueil.Click += Accueil_Click;
            // 
            // Adoptants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 231);
            ClientSize = new Size(1071, 760);
            Controls.Add(Adoptions);
            Controls.Add(Dossiers);
            Controls.Add(Déconnexion);
            Controls.Add(AdoptantsZ);
            Controls.Add(AnimauxZ);
            Controls.Add(Accueil);
            Controls.Add(AdoptantsList);
            Controls.Add(Supprimer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Adoptants";
            Text = "Adoptants";
            Load += Adoptants_Load;
            ((System.ComponentModel.ISupportInitialize)AdoptantsList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Supprimer;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2DataGridView AdoptantsList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private ComboBox TypeZT;
        private Label label10;
        private ComboBox SexeZT;
        private Button Adoptions;
        private Button Dossiers;
        private Button Déconnexion;
        private Button AdoptantsZ;
        private Button AnimauxZ;
        private Button Accueil;
    }
}