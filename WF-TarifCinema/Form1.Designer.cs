namespace WF_TarifCinema
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTarifApplicable = new System.Windows.Forms.Label();
            this.cboJour = new System.Windows.Forms.ComboBox();
            this.cboHoraire = new System.Windows.Forms.ComboBox();
            this.btnAutreTicket = new System.Windows.Forms.Button();
            this.btnCalculerTarif = new System.Windows.Forms.Button();
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.lblTarifPlein = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCouponReduc = new System.Windows.Forms.CheckBox();
            this.chkMajoration3D = new System.Windows.Forms.CheckBox();
            this.grbTarifReduit = new System.Windows.Forms.GroupBox();
            this.rdbAutre = new System.Windows.Forms.RadioButton();
            this.rdbEtudiant = new System.Windows.Forms.RadioButton();
            this.rdbCE = new System.Windows.Forms.RadioButton();
            this.lblChoixJour = new System.Windows.Forms.Label();
            this.lblChoixHoraire = new System.Windows.Forms.Label();
            this.lblTarifHoraire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            this.grbTarifReduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTarifApplicable
            // 
            this.lblTarifApplicable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTarifApplicable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifApplicable.Location = new System.Drawing.Point(408, 370);
            this.lblTarifApplicable.Name = "lblTarifApplicable";
            this.lblTarifApplicable.Size = new System.Drawing.Size(165, 42);
            this.lblTarifApplicable.TabIndex = 32;
            this.lblTarifApplicable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboJour
            // 
            this.cboJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJour.FormattingEnabled = true;
            this.cboJour.Items.AddRange(new object[] {
            "lundi",
            "mardi",
            "mercredi",
            "jeudi",
            "vendredi",
            "samedi",
            "dimanche"});
            this.cboJour.Location = new System.Drawing.Point(164, 96);
            this.cboJour.Name = "cboJour";
            this.cboJour.Size = new System.Drawing.Size(112, 28);
            this.cboJour.TabIndex = 31;
            // 
            // cboHoraire
            // 
            this.cboHoraire.DisplayMember = "11h00;14h00;16h45;17h50;19h15;21h45";
            this.cboHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraire.FormattingEnabled = true;
            this.cboHoraire.Location = new System.Drawing.Point(164, 55);
            this.cboHoraire.Name = "cboHoraire";
            this.cboHoraire.Size = new System.Drawing.Size(112, 28);
            this.cboHoraire.Sorted = true;
            this.cboHoraire.TabIndex = 17;
            // 
            // btnAutreTicket
            // 
            this.btnAutreTicket.AutoSize = true;
            this.btnAutreTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutreTicket.Location = new System.Drawing.Point(218, 446);
            this.btnAutreTicket.Name = "btnAutreTicket";
            this.btnAutreTicket.Size = new System.Drawing.Size(173, 39);
            this.btnAutreTicket.TabIndex = 30;
            this.btnAutreTicket.Text = "AUTRE TICKET";
            this.btnAutreTicket.UseVisualStyleBackColor = true;
            // 
            // btnCalculerTarif
            // 
            this.btnCalculerTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculerTarif.Location = new System.Drawing.Point(408, 298);
            this.btnCalculerTarif.Name = "btnCalculerTarif";
            this.btnCalculerTarif.Size = new System.Drawing.Size(165, 67);
            this.btnCalculerTarif.TabIndex = 29;
            this.btnCalculerTarif.Text = "TARIF APPLICABLE";
            this.btnCalculerTarif.UseVisualStyleBackColor = true;
            // 
            // picTicket
            // 
            this.picTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picTicket.Image = ((System.Drawing.Image)(resources.GetObject("picTicket.Image")));
            this.picTicket.Location = new System.Drawing.Point(388, 166);
            this.picTicket.Name = "picTicket";
            this.picTicket.Size = new System.Drawing.Size(208, 118);
            this.picTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTicket.TabIndex = 28;
            this.picTicket.TabStop = false;
            // 
            // lblTarifPlein
            // 
            this.lblTarifPlein.AutoSize = true;
            this.lblTarifPlein.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifPlein.Location = new System.Drawing.Point(150, 19);
            this.lblTarifPlein.Name = "lblTarifPlein";
            this.lblTarifPlein.Size = new System.Drawing.Size(66, 24);
            this.lblTarifPlein.TabIndex = 25;
            this.lblTarifPlein.Text = "8,80 €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Carte vermeil, carte famille nombreuse, demandeur emploi";
            // 
            // chkCouponReduc
            // 
            this.chkCouponReduc.AutoSize = true;
            this.chkCouponReduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCouponReduc.Location = new System.Drawing.Point(15, 384);
            this.chkCouponReduc.Name = "chkCouponReduc";
            this.chkCouponReduc.Size = new System.Drawing.Size(257, 28);
            this.chkCouponReduc.TabIndex = 24;
            this.chkCouponReduc.Text = "Coupon réduction :  -1,00 €";
            this.chkCouponReduc.UseVisualStyleBackColor = true;
            // 
            // chkMajoration3D
            // 
            this.chkMajoration3D.AutoSize = true;
            this.chkMajoration3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMajoration3D.Location = new System.Drawing.Point(15, 350);
            this.chkMajoration3D.Name = "chkMajoration3D";
            this.chkMajoration3D.Size = new System.Drawing.Size(255, 28);
            this.chkMajoration3D.TabIndex = 23;
            this.chkMajoration3D.Text = "Majoration Film 3D :  1,50 €";
            this.chkMajoration3D.UseVisualStyleBackColor = true;
            // 
            // grbTarifReduit
            // 
            this.grbTarifReduit.Controls.Add(this.rdbAutre);
            this.grbTarifReduit.Controls.Add(this.rdbEtudiant);
            this.grbTarifReduit.Controls.Add(this.rdbCE);
            this.grbTarifReduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTarifReduit.Location = new System.Drawing.Point(15, 152);
            this.grbTarifReduit.Name = "grbTarifReduit";
            this.grbTarifReduit.Size = new System.Drawing.Size(344, 192);
            this.grbTarifReduit.TabIndex = 21;
            this.grbTarifReduit.TabStop = false;
            this.grbTarifReduit.Text = "Tarif réduit";
            // 
            // rdbAutre
            // 
            this.rdbAutre.AutoSize = true;
            this.rdbAutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAutre.Location = new System.Drawing.Point(17, 104);
            this.rdbAutre.Name = "rdbAutre";
            this.rdbAutre.Size = new System.Drawing.Size(88, 28);
            this.rdbAutre.TabIndex = 4;
            this.rdbAutre.TabStop = true;
            this.rdbAutre.Text = "Autre : ";
            this.rdbAutre.UseVisualStyleBackColor = true;
            // 
            // rdbEtudiant
            // 
            this.rdbEtudiant.AutoSize = true;
            this.rdbEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEtudiant.Location = new System.Drawing.Point(17, 69);
            this.rdbEtudiant.Name = "rdbEtudiant";
            this.rdbEtudiant.Size = new System.Drawing.Size(202, 28);
            this.rdbEtudiant.TabIndex = 1;
            this.rdbEtudiant.TabStop = true;
            this.rdbEtudiant.Text = "Etudiant ou mineur : ";
            this.rdbEtudiant.UseVisualStyleBackColor = true;
            // 
            // rdbCE
            // 
            this.rdbCE.AutoSize = true;
            this.rdbCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCE.Location = new System.Drawing.Point(17, 36);
            this.rdbCE.Name = "rdbCE";
            this.rdbCE.Size = new System.Drawing.Size(206, 28);
            this.rdbCE.TabIndex = 0;
            this.rdbCE.Text = "Comité d\'entreprise : ";
            this.rdbCE.UseVisualStyleBackColor = true;
            // 
            // lblChoixJour
            // 
            this.lblChoixJour.AutoSize = true;
            this.lblChoixJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixJour.Location = new System.Drawing.Point(12, 97);
            this.lblChoixJour.Name = "lblChoixJour";
            this.lblChoixJour.Size = new System.Drawing.Size(135, 24);
            this.lblChoixJour.TabIndex = 20;
            this.lblChoixJour.Text = "Choisir le jour :";
            // 
            // lblChoixHoraire
            // 
            this.lblChoixHoraire.AutoSize = true;
            this.lblChoixHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixHoraire.Location = new System.Drawing.Point(12, 58);
            this.lblChoixHoraire.Name = "lblChoixHoraire";
            this.lblChoixHoraire.Size = new System.Drawing.Size(150, 24);
            this.lblChoixHoraire.TabIndex = 19;
            this.lblChoixHoraire.Text = "Choisir l\'horaire :";
            // 
            // lblTarifHoraire
            // 
            this.lblTarifHoraire.AutoSize = true;
            this.lblTarifHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifHoraire.Location = new System.Drawing.Point(12, 19);
            this.lblTarifHoraire.Name = "lblTarifHoraire";
            this.lblTarifHoraire.Size = new System.Drawing.Size(132, 24);
            this.lblTarifHoraire.TabIndex = 18;
            this.lblTarifHoraire.Text = "PLEIN TARIF :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 491);
            this.Controls.Add(this.lblTarifApplicable);
            this.Controls.Add(this.cboJour);
            this.Controls.Add(this.cboHoraire);
            this.Controls.Add(this.btnAutreTicket);
            this.Controls.Add(this.btnCalculerTarif);
            this.Controls.Add(this.picTicket);
            this.Controls.Add(this.lblTarifPlein);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkCouponReduc);
            this.Controls.Add(this.chkMajoration3D);
            this.Controls.Add(this.grbTarifReduit);
            this.Controls.Add(this.lblChoixJour);
            this.Controls.Add(this.lblChoixHoraire);
            this.Controls.Add(this.lblTarifHoraire);
            this.Name = "Form1";
            this.Text = "Tarifs - LE MAZARIN";
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            this.grbTarifReduit.ResumeLayout(false);
            this.grbTarifReduit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarifApplicable;
        private System.Windows.Forms.ComboBox cboJour;
        private System.Windows.Forms.ComboBox cboHoraire;
        private System.Windows.Forms.Button btnAutreTicket;
        private System.Windows.Forms.Button btnCalculerTarif;
        private System.Windows.Forms.PictureBox picTicket;
        private System.Windows.Forms.Label lblTarifPlein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCouponReduc;
        private System.Windows.Forms.CheckBox chkMajoration3D;
        private System.Windows.Forms.GroupBox grbTarifReduit;
        private System.Windows.Forms.RadioButton rdbAutre;
        private System.Windows.Forms.RadioButton rdbEtudiant;
        private System.Windows.Forms.RadioButton rdbCE;
        private System.Windows.Forms.Label lblChoixJour;
        private System.Windows.Forms.Label lblChoixHoraire;
        private System.Windows.Forms.Label lblTarifHoraire;
    }
}

