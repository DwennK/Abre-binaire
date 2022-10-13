using System;
using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary; //Permet la Serialization
using System.IO;
using System.Drawing.Printing;

namespace ProjetArbre
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Personne pMoi;
        Personne P;
        TreeNode tnCourant;
        string strChemin = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            pMoi = new Personne("Moi");
            tnCourant = new TreeNode();
            tnCourant.Tag = pMoi;
            tnCourant.ToolTipText = pMoi.Affiche(true);
            tnCourant.ContextMenuStrip = contextMenuStrip1;
            tnCourant.ForeColor = pMoi.Couleur;
            tvPrincipal.Nodes.Add(tnCourant);
            Parcourir(tvPrincipal.Nodes[0]);
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Sélectionne la node cliquée
            tvPrincipal.SelectedNode = e.Node;

            //Intercepte le clic gauche de la souris
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(tvPrincipal, e.Location);
            }
        }
        private void ajouterPersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P = new Personne();
            tnCourant = new TreeNode();
            tnCourant.Tag = P;
            tnCourant.ToolTipText = P.Affiche(true);
            tnCourant.ContextMenuStrip = contextMenuStrip1;
            tnCourant.ForeColor = P.Couleur;
            tvPrincipal.SelectedNode.Nodes.Add(tnCourant);
            tvPrincipal.SelectedNode.Expand();
            Parcourir(tvPrincipal.Nodes[0]); //On y envoie le début du Treeview
        }
        private void afficherDetailsStripMenuItem_Click(object sender, EventArgs e)
        {
            P = (Personne)(tvPrincipal.SelectedNode.Tag);
            MessageBox.Show(P.Affiche(false), "Affichage détails personne");
        }
        private void supprimerPersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode PositionApres = tvPrincipal.SelectedNode.Parent; //Permet de se repositionner sur la bonne TreeNode après avoir supprimé la node à Supprimer.
            if (tvPrincipal.SelectedNode.Level != 0) //Permet d'éviter la suppression du Noeud initial. A chaque sous-noeud, incrémente de 1. Donc empêche la supression du noeud père.
            {
                TreeNode tnClone = (TreeNode)tvPrincipal.SelectedNode.Clone();

                for (int i = 0; i < tnClone.Nodes.Count; i++) //Parcours toutes les nodes du niveau en cours
                {
                    tvPrincipal.SelectedNode.Parent.Nodes.Add(tnClone.Nodes[i]); //Ajoute toutes les notes du niveau en cours au Parent, ce qui va les mettre au meme niveau que les nodes du parent de celles supprimées.
                }
                tvPrincipal.SelectedNode.Remove(); //Finalement, supprime la node de base qui a servi de modèle à la copie.
                tvPrincipal.SelectedNode = PositionApres;
            }
            tvPrincipal.ExpandAll();
            Parcourir(tvPrincipal.Nodes[0]);

        }
        private void modifierPersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P = (Personne)(tvPrincipal.SelectedNode.Tag); //Passage du TAG dans la personne
            frmPersonne mod = new frmPersonne(P); //Création Form Dialogue
            if (mod.ShowDialog() == DialogResult.OK)//Test si pression "OK" si oui attribuation de la personne modifier
            {

                P = mod.Pmod;
                P.CalculNiveau();
                tvPrincipal.SelectedNode.Tag = P;
                tvPrincipal.SelectedNode.ToolTipText = P.Affiche(true);
                tvPrincipal.SelectedNode.ForeColor = P.Couleur;
            }
            Parcourir(tvPrincipal.Nodes[0]);

        }
        private double Parcourir(TreeNode tnParent)
        {
            double dblTotal = 0;
            double dblGainAss = 0; //Gain Associeé de l'enfant
            //P = (Personne)(Parent.Tag); Ancienne ligne qui posait problème
            Personne P = (Personne)(tnParent.Tag); //Création d'une autre personne car fonctionne mais le nom reste identique.

            foreach (TreeNode tnEnfant in tnParent.Nodes)
            {
                dblTotal += Parcourir(tnEnfant);
                Personne P2 = (Personne)(tnEnfant.Tag); //Création d'une autre personne car fonctionne mais le nom reste identique.
                P2.CalculNiveau();
                dblGainAss += P2.GainTheorique;
            }
            P.VolumeGroupe = dblTotal;
            P.GainAssocies = dblGainAss;            
            dblTotal += P.VolumePersonnel;
            P.CalculNiveau();
            tnParent.Tag = P;
            tnParent.Text = P.Nom + " " + (P.Gain).ToString("c");
            tnParent.ForeColor = P.Couleur;
            tnParent.ToolTipText = P.Affiche(true);

            return dblTotal;
        }
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drNouveau = MessageBox.Show("Voulez vous sauvegarder votre travail actuel ? \nTout travail non sauvegardé sera perdu!", "Nouveau projet", MessageBoxButtons.YesNoCancel);
            if (drNouveau == DialogResult.Yes)
            {
                Sauvegarder();
            }
            else if (drNouveau == DialogResult.No)
            {
                //Restart le programme
                tvPrincipal.Nodes[0].Remove();
                tnCourant = new TreeNode();
                tnCourant.Tag = pMoi;
                tnCourant.ToolTipText = pMoi.Affiche(true);
                tnCourant.ContextMenuStrip = contextMenuStrip1;
                tnCourant.ForeColor = pMoi.Couleur;
                tvPrincipal.Nodes.Add(tnCourant);
                Parcourir(tvPrincipal.Nodes[0]);
            }
        }
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sauvegarder();
        }
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)//Problème : à l'ouverture le programme ne peut plus parcourir
        {
            DialogResult drOuvrir = MessageBox.Show("Voulez vous sauvegarder votre travail actuel ? \nTout travail non sauvegardé sera perdu!", "Ouvrir un projet", MessageBoxButtons.YesNoCancel);
            if (drOuvrir == DialogResult.Yes)
            {
                Sauvegarder(); // Si la réponse de la personne est oui il va d'abbord y avoir la sauvegarde de l'arbre
                Ouvrir();
            }
            else if (drOuvrir == DialogResult.No)
            {
                Ouvrir();
            }
        }
		//Pour l’aide je suis partie de se site : http://stackoverflow.com/questions/5868790/saving-content-of-a-treeview-to-a-file-and-load-it-later
        private void Sauvegarder()
        {
            SaveFileDialog sfdEnregistrer = new SaveFileDialog();
            sfdEnregistrer.DefaultExt = "txt";
            sfdEnregistrer.Filter = "Fichier Text (*.txt)|*.txt"; //Permet de filtrer l'affichage
            sfdEnregistrer.FileName = strChemin;
            sfdEnregistrer.ShowDialog();
            if (sfdEnregistrer.FileName.Length > 0)
            {
                using (Stream sFile = File.Open(sfdEnregistrer.FileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(sFile, tvPrincipal.Nodes.Cast<TreeNode>().ToList());
                }
                strChemin = sfdEnregistrer.FileName;
            }
        }
        private void Ouvrir()
        {
            try
            {
                OpenFileDialog ofdOuvrir = new OpenFileDialog();
                ofdOuvrir.DefaultExt = "txt";
                ofdOuvrir.Filter = "Fichier Text (*.txt)|*.txt"; //Permet de filtrer l'affichage
                ofdOuvrir.ShowDialog();
                if (ofdOuvrir.FileName.Length > 0)
                {
                    using (Stream sFile = File.Open(ofdOuvrir.FileName, FileMode.Open))
                    {
                        tvPrincipal.SelectedNode = tvPrincipal.Nodes[0];
                        tvPrincipal.SelectedNode.Remove();

                        BinaryFormatter bf = new BinaryFormatter();
                        object obj = bf.Deserialize(sFile);

                        TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                        tvPrincipal.Nodes.AddRange(nodeList);
                        strChemin = ofdOuvrir.FileName;
                    }
                    tvPrincipal.ExpandAll();
                }

            }
            catch
            {
                MessageBox.Show("Problème lors du chargement du fichier, veuillez réessayer", "Erreur");
                Application.Restart();
                Ouvrir();
            }
        }
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            //Va capturer les touches pressées, afin de réagir aux raccourcis claviers courants.
            //La méthode PerformClick() simule un clic sur un bouton
            if(e.KeyData == (Keys.Control | Keys.N))
            {
                tsmNouveau.PerformClick();
            }
            if (e.KeyData == (Keys.Control | Keys.O))
            {
                tsmOuvrir.PerformClick();
            }
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                if (strChemin != "")
                {
                    tsmEnregistrerRapide.PerformClick();
                }
                else
                {
                    Sauvegarder();
                }
            }
        }
        private void enregisterRapideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strChemin != "")
            {
                using (Stream file = File.Open(strChemin, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, tvPrincipal.Nodes.Cast<TreeNode>().ToList());
                }
            }
            else
            {
                Sauvegarder();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drFermeture = MessageBox.Show("Voulez vous sauvegarder votre travail actuel ? \nTout travail non sauvegardé sera perdu!", "Fermeture du programme", MessageBoxButtons.YesNoCancel);
            if (drFermeture == DialogResult.Yes)
            {
                Sauvegarder(); //Sauvegarde avant fermeture du programme
            }
            else if (drFermeture == DialogResult.No)
            {
                //Fermeture du programme
            }
            else if (drFermeture==DialogResult.Cancel)
            {
                e.Cancel = true;//Annulation de la fermeture
            }
        }     
    }
}    