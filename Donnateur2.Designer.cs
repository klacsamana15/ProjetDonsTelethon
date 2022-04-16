namespace telethon
{
    partial class Donnateur2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donnateur2));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnAffichage = new System.Windows.Forms.Button();
            this.lblDonnateur = new System.Windows.Forms.Label();
            this.tbNumeroCarte = new System.Windows.Forms.TextBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.brnDonnateur = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.btnSuivante = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tbMontant = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblNumeroCarte = new System.Windows.Forms.Label();
            this.tbDateMM = new System.Windows.Forms.TextBox();
            this.tbCodeValidation = new System.Windows.Forms.TextBox();
            this.lblDateExpiration = new System.Windows.Forms.Label();
            this.lblCodeVerification = new System.Windows.Forms.Label();
            this.tbDateYYYY = new System.Windows.Forms.TextBox();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.rbMC = new System.Windows.Forms.RadioButton();
            this.rbAmex = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.imgSelected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelected)).BeginInit();
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
            this.btnAffichage.Click += new System.EventHandler(this.BtnAffichage_Click);
            // 
            // lblDonnateur
            // 
            this.lblDonnateur.AutoSize = true;
            this.lblDonnateur.BackColor = System.Drawing.Color.Transparent;
            this.lblDonnateur.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonnateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblDonnateur.Location = new System.Drawing.Point(259, 60);
            this.lblDonnateur.Name = "lblDonnateur";
            this.lblDonnateur.Size = new System.Drawing.Size(344, 33);
            this.lblDonnateur.TabIndex = 11;
            this.lblDonnateur.Text = "Donateur: détails du paiement";
            // 
            // tbNumeroCarte
            // 
            this.tbNumeroCarte.BackColor = System.Drawing.Color.GhostWhite;
            this.tbNumeroCarte.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroCarte.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNumeroCarte.Location = new System.Drawing.Point(265, 241);
            this.tbNumeroCarte.Name = "tbNumeroCarte";
            this.tbNumeroCarte.Size = new System.Drawing.Size(454, 37);
            this.tbNumeroCarte.TabIndex = 26;
            this.tbNumeroCarte.Text = "#### #### #### ####";
            this.tbNumeroCarte.Enter += new System.EventHandler(this.TbNumeroCarte_Enter);
            this.tbNumeroCarte.Leave += new System.EventHandler(this.TbNumeroCarte_Leave);
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
            this.btnCommand.Click += new System.EventHandler(this.Button1_Click);
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
            this.brnDonnateur.Click += new System.EventHandler(this.BrnDonnateur_Click);
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
            this.btnAccueil.Click += new System.EventHandler(this.BtnAccueil_Click);
            // 
            // btnSuivante
            // 
            this.btnSuivante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnSuivante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuivante.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuivante.FlatAppearance.BorderSize = 0;
            this.btnSuivante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnSuivante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnSuivante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivante.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSuivante.Location = new System.Drawing.Point(537, 423);
            this.btnSuivante.Name = "btnSuivante";
            this.btnSuivante.Size = new System.Drawing.Size(136, 43);
            this.btnSuivante.TabIndex = 17;
            this.btnSuivante.Text = "Suivante";
            this.btnSuivante.UseMnemonic = false;
            this.btnSuivante.UseVisualStyleBackColor = false;
            this.btnSuivante.Click += new System.EventHandler(this.BtnSuivante_Click);
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
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(706, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(38, 38);
            this.btnInfo.TabIndex = 23;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tbMontant
            // 
            this.tbMontant.BackColor = System.Drawing.Color.GhostWhite;
            this.tbMontant.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMontant.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbMontant.Location = new System.Drawing.Point(265, 133);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.Size = new System.Drawing.Size(454, 37);
            this.tbMontant.TabIndex = 24;
            this.tbMontant.Text = "Montant";
            this.tbMontant.TextChanged += new System.EventHandler(this.tbMontant_TextChanged);
            this.tbMontant.Enter += new System.EventHandler(this.TbMontant_Enter);
            this.tbMontant.Leave += new System.EventHandler(this.TbMontant_Leave);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.CausesValidation = false;
            this.lblMontant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblMontant.Location = new System.Drawing.Point(261, 114);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(64, 19);
            this.lblMontant.TabIndex = 27;
            this.lblMontant.Text = "Montant";
            // 
            // lblNumeroCarte
            // 
            this.lblNumeroCarte.AutoSize = true;
            this.lblNumeroCarte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCarte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblNumeroCarte.Location = new System.Drawing.Point(261, 222);
            this.lblNumeroCarte.Name = "lblNumeroCarte";
            this.lblNumeroCarte.Size = new System.Drawing.Size(117, 19);
            this.lblNumeroCarte.TabIndex = 29;
            this.lblNumeroCarte.Text = "Numéro de carte";
            // 
            // tbDateMM
            // 
            this.tbDateMM.BackColor = System.Drawing.Color.GhostWhite;
            this.tbDateMM.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateMM.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDateMM.Location = new System.Drawing.Point(265, 311);
            this.tbDateMM.Name = "tbDateMM";
            this.tbDateMM.Size = new System.Drawing.Size(82, 37);
            this.tbDateMM.TabIndex = 27;
            this.tbDateMM.Text = "MM";
            this.tbDateMM.Enter += new System.EventHandler(this.TbDateMM_Enter);
            this.tbDateMM.Leave += new System.EventHandler(this.TbDateMM_Leave);
            // 
            // tbCodeValidation
            // 
            this.tbCodeValidation.BackColor = System.Drawing.Color.GhostWhite;
            this.tbCodeValidation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbCodeValidation.Location = new System.Drawing.Point(496, 311);
            this.tbCodeValidation.Name = "tbCodeValidation";
            this.tbCodeValidation.Size = new System.Drawing.Size(223, 37);
            this.tbCodeValidation.TabIndex = 28;
            this.tbCodeValidation.Text = "CVV";
            this.tbCodeValidation.Enter += new System.EventHandler(this.TbCodeValidation_Enter);
            this.tbCodeValidation.Leave += new System.EventHandler(this.TbCodeValidation_Leave);
            // 
            // lblDateExpiration
            // 
            this.lblDateExpiration.AutoSize = true;
            this.lblDateExpiration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpiration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblDateExpiration.Location = new System.Drawing.Point(261, 292);
            this.lblDateExpiration.Name = "lblDateExpiration";
            this.lblDateExpiration.Size = new System.Drawing.Size(121, 19);
            this.lblDateExpiration.TabIndex = 35;
            this.lblDateExpiration.Text = "Date d\'expiration";
            // 
            // lblCodeVerification
            // 
            this.lblCodeVerification.AutoSize = true;
            this.lblCodeVerification.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeVerification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(93)))));
            this.lblCodeVerification.Location = new System.Drawing.Point(492, 292);
            this.lblCodeVerification.Name = "lblCodeVerification";
            this.lblCodeVerification.Size = new System.Drawing.Size(130, 19);
            this.lblCodeVerification.TabIndex = 36;
            this.lblCodeVerification.Text = "Code de validation";
            // 
            // tbDateYYYY
            // 
            this.tbDateYYYY.BackColor = System.Drawing.Color.GhostWhite;
            this.tbDateYYYY.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateYYYY.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDateYYYY.Location = new System.Drawing.Point(353, 311);
            this.tbDateYYYY.Name = "tbDateYYYY";
            this.tbDateYYYY.Size = new System.Drawing.Size(137, 37);
            this.tbDateYYYY.TabIndex = 37;
            this.tbDateYYYY.Text = "YYYY";
            this.tbDateYYYY.Enter += new System.EventHandler(this.TbDateYYYY_Enter);
            this.tbDateYYYY.Leave += new System.EventHandler(this.TbDateYYYY_Leave);
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Image = global::telethon.Properties.Resources.visa1;
            this.rbVisa.Location = new System.Drawing.Point(265, 174);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(62, 48);
            this.rbVisa.TabIndex = 38;
            this.rbVisa.TabStop = true;
            this.rbVisa.UseVisualStyleBackColor = true;
            this.rbVisa.CheckedChanged += new System.EventHandler(this.rbVisa_CheckedChanged);
            // 
            // rbMC
            // 
            this.rbMC.AutoSize = true;
            this.rbMC.Image = global::telethon.Properties.Resources.mc1;
            this.rbMC.Location = new System.Drawing.Point(344, 174);
            this.rbMC.Name = "rbMC";
            this.rbMC.Size = new System.Drawing.Size(62, 48);
            this.rbMC.TabIndex = 39;
            this.rbMC.TabStop = true;
            this.rbMC.UseVisualStyleBackColor = true;
            this.rbMC.CheckedChanged += new System.EventHandler(this.rbMC_CheckedChanged);
            // 
            // rbAmex
            // 
            this.rbAmex.AutoSize = true;
            this.rbAmex.Image = global::telethon.Properties.Resources.amex1;
            this.rbAmex.Location = new System.Drawing.Point(423, 174);
            this.rbAmex.Name = "rbAmex";
            this.rbAmex.Size = new System.Drawing.Size(62, 48);
            this.rbAmex.TabIndex = 40;
            this.rbAmex.TabStop = true;
            this.rbAmex.UseVisualStyleBackColor = true;
            this.rbAmex.CheckedChanged += new System.EventHandler(this.rbAmex_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(569, 386);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 17);
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(525, 386);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 17);
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // imgSelected
            // 
            this.imgSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgSelected.BackgroundImage")));
            this.imgSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSelected.Location = new System.Drawing.Point(478, 386);
            this.imgSelected.Name = "imgSelected";
            this.imgSelected.Size = new System.Drawing.Size(10, 17);
            this.imgSelected.TabIndex = 48;
            this.imgSelected.TabStop = false;
            // 
            // Donnateur2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.imgSelected);
            this.Controls.Add(this.rbAmex);
            this.Controls.Add(this.rbMC);
            this.Controls.Add(this.rbVisa);
            this.Controls.Add(this.tbDateYYYY);
            this.Controls.Add(this.lblCodeVerification);
            this.Controls.Add(this.lblDateExpiration);
            this.Controls.Add(this.tbCodeValidation);
            this.Controls.Add(this.tbDateMM);
            this.Controls.Add(this.lblNumeroCarte);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.tbMontant);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSuivante);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.brnDonnateur);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.tbNumeroCarte);
            this.Controls.Add(this.lblDonnateur);
            this.Controls.Add(this.btnAffichage);
            this.Controls.Add(this.imgLogo);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Donnateur2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "donnateur";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnAffichage;
        private System.Windows.Forms.Label lblDonnateur;
        private System.Windows.Forms.TextBox tbNumeroCarte;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Button brnDonnateur;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnSuivante;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox tbMontant;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblNumeroCarte;
        private System.Windows.Forms.TextBox tbDateMM;
        private System.Windows.Forms.TextBox tbCodeValidation;
        private System.Windows.Forms.Label lblDateExpiration;
        private System.Windows.Forms.Label lblCodeVerification;
        private System.Windows.Forms.TextBox tbDateYYYY;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.RadioButton rbMC;
        private System.Windows.Forms.RadioButton rbAmex;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox imgSelected;
    }
}