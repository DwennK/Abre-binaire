namespace ProjetArbre
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tvPrincipal = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterPersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherDetailsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierPersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSauver = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnregistrerRapide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPrincipal
            // 
            this.tvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvPrincipal.Location = new System.Drawing.Point(0, 27);
            this.tvPrincipal.Name = "tvPrincipal";
            this.tvPrincipal.ShowNodeToolTips = true;
            this.tvPrincipal.Size = new System.Drawing.Size(367, 410);
            this.tvPrincipal.TabIndex = 0;
            this.tvPrincipal.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.tvPrincipal.DoubleClick += new System.EventHandler(this.ajouterPersonneToolStripMenuItem_Click);
            this.tvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterPersonneToolStripMenuItem,
            this.afficherDetailsStripMenuItem,
            this.modifierPersonneToolStripMenuItem,
            this.supprimerPersonneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 92);
            // 
            // ajouterPersonneToolStripMenuItem
            // 
            this.ajouterPersonneToolStripMenuItem.Name = "ajouterPersonneToolStripMenuItem";
            this.ajouterPersonneToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ajouterPersonneToolStripMenuItem.Text = "Ajouter une personne";
            this.ajouterPersonneToolStripMenuItem.Click += new System.EventHandler(this.ajouterPersonneToolStripMenuItem_Click);
            // 
            // afficherDetailsStripMenuItem
            // 
            this.afficherDetailsStripMenuItem.Name = "afficherDetailsStripMenuItem";
            this.afficherDetailsStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.afficherDetailsStripMenuItem.Text = "Afficher détails";
            this.afficherDetailsStripMenuItem.Click += new System.EventHandler(this.afficherDetailsStripMenuItem_Click);
            // 
            // modifierPersonneToolStripMenuItem
            // 
            this.modifierPersonneToolStripMenuItem.Name = "modifierPersonneToolStripMenuItem";
            this.modifierPersonneToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modifierPersonneToolStripMenuItem.Text = "Modifier personne";
            this.modifierPersonneToolStripMenuItem.Click += new System.EventHandler(this.modifierPersonneToolStripMenuItem_Click);
            // 
            // supprimerPersonneToolStripMenuItem
            // 
            this.supprimerPersonneToolStripMenuItem.Name = "supprimerPersonneToolStripMenuItem";
            this.supprimerPersonneToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.supprimerPersonneToolStripMenuItem.Text = "Supprimer personne";
            this.supprimerPersonneToolStripMenuItem.Click += new System.EventHandler(this.supprimerPersonneToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSauver,
            this.tsmOuvrir,
            this.tsmNouveau});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSauver
            // 
            this.tsmSauver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEnregistrerRapide,
            this.tsmEnregistrerSous});
            this.tsmSauver.Image = global::ProjetArbre.Properties.Resources.save;
            this.tsmSauver.Name = "tsmSauver";
            this.tsmSauver.Size = new System.Drawing.Size(70, 20);
            this.tsmSauver.Text = "Sauver";
            // 
            // tsmEnregistrerRapide
            // 
            this.tsmEnregistrerRapide.Name = "tsmEnregistrerRapide";
            this.tsmEnregistrerRapide.Size = new System.Drawing.Size(163, 22);
            this.tsmEnregistrerRapide.Text = "Enregistrer";
            this.tsmEnregistrerRapide.Click += new System.EventHandler(this.enregisterRapideToolStripMenuItem_Click);
            // 
            // tsmEnregistrerSous
            // 
            this.tsmEnregistrerSous.Name = "tsmEnregistrerSous";
            this.tsmEnregistrerSous.Size = new System.Drawing.Size(163, 22);
            this.tsmEnregistrerSous.Text = "Enregister Sous...";
            this.tsmEnregistrerSous.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // tsmOuvrir
            // 
            this.tsmOuvrir.Image = global::ProjetArbre.Properties.Resources.folder;
            this.tsmOuvrir.Name = "tsmOuvrir";
            this.tsmOuvrir.Size = new System.Drawing.Size(68, 20);
            this.tsmOuvrir.Text = "Ouvrir";
            this.tsmOuvrir.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // tsmNouveau
            // 
            this.tsmNouveau.Image = global::ProjetArbre.Properties.Resources.tab_new_raised;
            this.tsmNouveau.Name = "tsmNouveau";
            this.tsmNouveau.Size = new System.Drawing.Size(83, 20);
            this.tsmNouveau.Text = "Nouveau";
            this.tsmNouveau.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 437);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tvPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente à multi niveau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPrincipal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterPersonneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherDetailsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierPersonneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerPersonneToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmNouveau;
        private System.Windows.Forms.ToolStripMenuItem tsmOuvrir;
        private System.Windows.Forms.ToolStripMenuItem tsmSauver;
        private System.Windows.Forms.ToolStripMenuItem tsmEnregistrerRapide;
        private System.Windows.Forms.ToolStripMenuItem tsmEnregistrerSous;
    }
}

