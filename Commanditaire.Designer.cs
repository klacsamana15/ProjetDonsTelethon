namespace telethon
{
    partial class Commanditaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commanditaire));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnAffichage = new System.Windows.Forms.Button();
            this.lblCommanditaire = new System.Windows.Forms.Label();
            this.txtNomComm = new System.Windows.Forms.TextBox();
            this.lblNomComm = new System.Windows.Forms.Label();
            this.btnCommand = new System.Windows.Forms.Button();
            this.brnDonnateur = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPrenomComm = new System.Windows.Forms.Label();
            this.txtPrenomComm = new System.Windows.Forms.TextBox();
            this.btnAjouterComm = new System.Windows.Forms.Button();
            this.ListComm1 = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgSelected = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogo.Location = new System.Drawing.Point(17, 23);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(204, 106);
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            // 
            // btnAffichage
            // 
            this.btnAffichage.BackColor = System.Drawing.Color.Transparent;
            this.btnAffichage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAffichage.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAffichage.FlatAppearance.BorderSize = 0;
            this.btnAffichage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnAffichage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnAffichage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAffichage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffichage.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAffichage.Location = new System.Drawing.Point(26, 386);
            this.btnAffichage.Name = "btnAffichage";
            this.btnAffichage.Size = new System.Drawing.Size(186, 63);
            this.btnAffichage.TabIndex = 10;
            this.btnAffichage.Text = "Affichage";
            this.btnAffichage.UseMnemonic = false;
            this.btnAffichage.UseVisualStyleBackColor = true;
            this.btnAffichage.Click += new System.EventHandler(this.btnAffichage_Click);
            // 
            // lblCommanditaire
            // 
            this.lblCommanditaire.AutoSize = true;
            this.lblCommanditaire.BackColor = System.Drawing.Color.Transparent;
            this.lblCommanditaire.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.lblCommanditaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblCommanditaire.Location = new System.Drawing.Point(259, 60);
            this.lblCommanditaire.Name = "lblCommanditaire";
            this.lblCommanditaire.Size = new System.Drawing.Size(489, 33);
            this.lblCommanditaire.TabIndex = 11;
            this.lblCommanditaire.Text = "Commanditaire: renseignements personnels";
            // 
            // txtNomComm
            // 
            this.txtNomComm.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNomComm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomComm.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNomComm.Location = new System.Drawing.Point(418, 262);
            this.txtNomComm.Name = "txtNomComm";
            this.txtNomComm.Size = new System.Drawing.Size(225, 37);
            this.txtNomComm.TabIndex = 29;
            this.txtNomComm.Text = "Nom";
            this.txtNomComm.TextChanged += new System.EventHandler(this.txtNomComm_TextChanged);
            this.txtNomComm.Enter += new System.EventHandler(this.txtNomComm_Enter);
            this.txtNomComm.Leave += new System.EventHandler(this.txtNomComm_Leave);
            // 
            // lblNomComm
            // 
            this.lblNomComm.AutoSize = true;
            this.lblNomComm.BackColor = System.Drawing.Color.Transparent;
            this.lblNomComm.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNomComm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblNomComm.Location = new System.Drawing.Point(414, 243);
            this.lblNomComm.Name = "lblNomComm";
            this.lblNomComm.Size = new System.Drawing.Size(39, 19);
            this.lblNomComm.TabIndex = 2;
            this.lblNomComm.Text = "Nom";
            this.lblNomComm.Click += new System.EventHandler(this.btnSuivante_Click);
            // 
            // btnCommand
            // 
            this.btnCommand.BackColor = System.Drawing.Color.Transparent;
            this.btnCommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommand.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCommand.FlatAppearance.BorderSize = 0;
            this.btnCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommand.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommand.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCommand.Location = new System.Drawing.Point(26, 311);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(186, 63);
            this.btnCommand.TabIndex = 14;
            this.btnCommand.Text = "Commanditaire";
            this.btnCommand.UseMnemonic = false;
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnDonnateur
            // 
            this.brnDonnateur.BackColor = System.Drawing.Color.Transparent;
            this.brnDonnateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brnDonnateur.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.brnDonnateur.FlatAppearance.BorderSize = 0;
            this.brnDonnateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.brnDonnateur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.brnDonnateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnDonnateur.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnDonnateur.ForeColor = System.Drawing.Color.GhostWhite;
            this.brnDonnateur.Location = new System.Drawing.Point(26, 236);
            this.brnDonnateur.Name = "brnDonnateur";
            this.brnDonnateur.Size = new System.Drawing.Size(186, 63);
            this.brnDonnateur.TabIndex = 15;
            this.brnDonnateur.Text = "Donateur";
            this.brnDonnateur.UseMnemonic = false;
            this.brnDonnateur.UseVisualStyleBackColor = true;
            this.brnDonnateur.Click += new System.EventHandler(this.brnDonnateur_Click);
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccueil.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnAccueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAccueil.Location = new System.Drawing.Point(26, 161);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(186, 63);
            this.btnAccueil.TabIndex = 16;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseMnemonic = false;
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnnuler.Location = new System.Drawing.Point(382, 423);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(136, 43);
            this.btnAnnuler.TabIndex = 20;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseMnemonic = false;
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(706, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(38, 38);
            this.btnInfo.TabIndex = 27;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(750, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPrenomComm
            // 
            this.lblPrenomComm.AutoSize = true;
            this.lblPrenomComm.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenomComm.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPrenomComm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblPrenomComm.Location = new System.Drawing.Point(413, 168);
            this.lblPrenomComm.Name = "lblPrenomComm";
            this.lblPrenomComm.Size = new System.Drawing.Size(58, 19);
            this.lblPrenomComm.TabIndex = 10;
            this.lblPrenomComm.Text = "Prénom";
            // 
            // txtPrenomComm
            // 
            this.txtPrenomComm.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPrenomComm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomComm.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrenomComm.Location = new System.Drawing.Point(418, 187);
            this.txtPrenomComm.Name = "txtPrenomComm";
            this.txtPrenomComm.Size = new System.Drawing.Size(225, 37);
            this.txtPrenomComm.TabIndex = 30;
            this.txtPrenomComm.Text = "Prénom";
            this.txtPrenomComm.Enter += new System.EventHandler(this.txtPrenomComm_Enter);
            this.txtPrenomComm.Leave += new System.EventHandler(this.txtPrenomComm_Leave);
            // 
            // btnAjouterComm
            // 
            this.btnAjouterComm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnAjouterComm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAjouterComm.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjouterComm.FlatAppearance.BorderSize = 0;
            this.btnAjouterComm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnAjouterComm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnAjouterComm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterComm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterComm.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAjouterComm.Location = new System.Drawing.Point(537, 423);
            this.btnAjouterComm.Name = "btnAjouterComm";
            this.btnAjouterComm.Size = new System.Drawing.Size(136, 43);
            this.btnAjouterComm.TabIndex = 35;
            this.btnAjouterComm.Text = "Suivant";
            this.btnAjouterComm.UseMnemonic = false;
            this.btnAjouterComm.UseVisualStyleBackColor = false;
            this.btnAjouterComm.Click += new System.EventHandler(this.btnAjouterComm_Click);
            // 
            // ListComm1
            // 
            this.ListComm1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListComm1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom});
            this.ListComm1.ForeColor = System.Drawing.Color.Black;
            this.ListComm1.HideSelection = false;
            this.ListComm1.Location = new System.Drawing.Point(679, 86);
            this.ListComm1.Name = "ListComm1";
            this.ListComm1.Scrollable = false;
            this.ListComm1.ShowGroups = false;
            this.ListComm1.Size = new System.Drawing.Size(109, 55);
            this.ListComm1.TabIndex = 36;
            this.ListComm1.UseCompatibleStateImageBehavior = false;
            this.ListComm1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // Nom
            // 
            this.Nom.Width = 40;
            // 
            // imgSelected
            // 
            this.imgSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgSelected.BackgroundImage")));
            this.imgSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSelected.Location = new System.Drawing.Point(478, 386);
            this.imgSelected.Name = "imgSelected";
            this.imgSelected.Size = new System.Drawing.Size(10, 17);
            this.imgSelected.TabIndex = 37;
            this.imgSelected.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(525, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 17);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(569, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 17);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // Commanditaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgSelected);
            this.Controls.Add(this.ListComm1);
            this.Controls.Add(this.btnAjouterComm);
            this.Controls.Add(this.lblPrenomComm);
            this.Controls.Add(this.txtPrenomComm);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.brnDonnateur);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.lblNomComm);
            this.Controls.Add(this.txtNomComm);
            this.Controls.Add(this.lblCommanditaire);
            this.Controls.Add(this.btnAffichage);
            this.Controls.Add(this.imgLogo);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Commanditaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "commanditaire";
            this.Load += new System.EventHandler(this.Commanditaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Label lblCommanditaire;
        private System.Windows.Forms.TextBox txtNomComm;
        private System.Windows.Forms.Label lblNomComm;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Button brnDonnateur;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPrenomComm;
        private System.Windows.Forms.TextBox txtPrenomComm;
        private System.Windows.Forms.Button btnAjouterComm;
        private System.Windows.Forms.ListView ListComm1;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.PictureBox imgSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}