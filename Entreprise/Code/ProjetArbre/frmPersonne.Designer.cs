namespace ProjetArbre
{
    partial class frmPersonne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonne));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblVolumePersonnel = new System.Windows.Forms.Label();
            this.lblVolumeGroupe = new System.Windows.Forms.Label();
            this.lblNiveauActuel = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxVolumePersonnel = new System.Windows.Forms.TextBox();
            this.rtbxRemarque = new System.Windows.Forms.RichTextBox();
            this.lblVolumeGroupeValue = new System.Windows.Forms.Label();
            this.lblNiveauActuelValue = new System.Windows.Forms.Label();
            this.lblGainValue = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(13, 12);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblVolumePersonnel
            // 
            this.lblVolumePersonnel.AutoSize = true;
            this.lblVolumePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumePersonnel.Location = new System.Drawing.Point(13, 44);
            this.lblVolumePersonnel.Name = "lblVolumePersonnel";
            this.lblVolumePersonnel.Size = new System.Drawing.Size(123, 15);
            this.lblVolumePersonnel.TabIndex = 1;
            this.lblVolumePersonnel.Text = "Volume personnel";
            // 
            // lblVolumeGroupe
            // 
            this.lblVolumeGroupe.AutoSize = true;
            this.lblVolumeGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeGroupe.Location = new System.Drawing.Point(13, 76);
            this.lblVolumeGroupe.Name = "lblVolumeGroupe";
            this.lblVolumeGroupe.Size = new System.Drawing.Size(124, 15);
            this.lblVolumeGroupe.TabIndex = 2;
            this.lblVolumeGroupe.Text = "Volume de groupe";
            // 
            // lblNiveauActuel
            // 
            this.lblNiveauActuel.AutoSize = true;
            this.lblNiveauActuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveauActuel.Location = new System.Drawing.Point(13, 108);
            this.lblNiveauActuel.Name = "lblNiveauActuel";
            this.lblNiveauActuel.Size = new System.Drawing.Size(94, 15);
            this.lblNiveauActuel.TabIndex = 3;
            this.lblNiveauActuel.Text = "Niveau actuel";
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGain.Location = new System.Drawing.Point(13, 140);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(37, 15);
            this.lblGain.TabIndex = 4;
            this.lblGain.Text = "Gain";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarque.Location = new System.Drawing.Point(13, 172);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(74, 15);
            this.lblRemarque.TabIndex = 5;
            this.lblRemarque.Text = "Remarque";
            // 
            // tbxNom
            // 
            this.tbxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNom.Location = new System.Drawing.Point(143, 8);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(226, 21);
            this.tbxNom.TabIndex = 6;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // tbxVolumePersonnel
            // 
            this.tbxVolumePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVolumePersonnel.Location = new System.Drawing.Point(143, 40);
            this.tbxVolumePersonnel.Name = "tbxVolumePersonnel";
            this.tbxVolumePersonnel.Size = new System.Drawing.Size(226, 21);
            this.tbxVolumePersonnel.TabIndex = 7;
            this.tbxVolumePersonnel.TextChanged += new System.EventHandler(this.tbxVolumePersonnel_Leave);
            this.tbxVolumePersonnel.Leave += new System.EventHandler(this.tbxVolumePersonnel_Leave);
            // 
            // rtbxRemarque
            // 
            this.rtbxRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxRemarque.Location = new System.Drawing.Point(143, 176);
            this.rtbxRemarque.Name = "rtbxRemarque";
            this.rtbxRemarque.Size = new System.Drawing.Size(226, 96);
            this.rtbxRemarque.TabIndex = 8;
            this.rtbxRemarque.Text = "";
            // 
            // lblVolumeGroupeValue
            // 
            this.lblVolumeGroupeValue.AutoSize = true;
            this.lblVolumeGroupeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeGroupeValue.Location = new System.Drawing.Point(143, 75);
            this.lblVolumeGroupeValue.Name = "lblVolumeGroupeValue";
            this.lblVolumeGroupeValue.Size = new System.Drawing.Size(11, 15);
            this.lblVolumeGroupeValue.TabIndex = 9;
            this.lblVolumeGroupeValue.Text = "-";
            // 
            // lblNiveauActuelValue
            // 
            this.lblNiveauActuelValue.AutoSize = true;
            this.lblNiveauActuelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveauActuelValue.Location = new System.Drawing.Point(143, 107);
            this.lblNiveauActuelValue.Name = "lblNiveauActuelValue";
            this.lblNiveauActuelValue.Size = new System.Drawing.Size(11, 15);
            this.lblNiveauActuelValue.TabIndex = 10;
            this.lblNiveauActuelValue.Text = "-";
            // 
            // lblGainValue
            // 
            this.lblGainValue.AutoSize = true;
            this.lblGainValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGainValue.Location = new System.Drawing.Point(143, 139);
            this.lblGainValue.Name = "lblGainValue";
            this.lblGainValue.Size = new System.Drawing.Size(11, 15);
            this.lblGainValue.TabIndex = 11;
            this.lblGainValue.Text = "-";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(211, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(158, 32);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(16, 287);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(162, 32);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 343);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblGainValue);
            this.Controls.Add(this.lblNiveauActuelValue);
            this.Controls.Add(this.lblVolumeGroupeValue);
            this.Controls.Add(this.rtbxRemarque);
            this.Controls.Add(this.tbxVolumePersonnel);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.lblNiveauActuel);
            this.Controls.Add(this.lblVolumeGroupe);
            this.Controls.Add(this.lblVolumePersonnel);
            this.Controls.Add(this.lblNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblVolumePersonnel;
        private System.Windows.Forms.Label lblVolumeGroupe;
        private System.Windows.Forms.Label lblNiveauActuel;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxVolumePersonnel;
        private System.Windows.Forms.RichTextBox rtbxRemarque;
        private System.Windows.Forms.Label lblVolumeGroupeValue;
        private System.Windows.Forms.Label lblNiveauActuelValue;
        private System.Windows.Forms.Label lblGainValue;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
    }
}