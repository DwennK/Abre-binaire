using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetArbre
{
    public partial class frmPersonne : Form
    {
        public Personne Pmod;
        bool bValideVol = true;
        bool bValideNom = true;
        public frmPersonne(Personne P)
        {
            InitializeComponent();
            AcceptButton = btnOk; //A la pression du bouton "Enter", va simuler un clic sur la touche Ok.
            Pmod = P;
            tbxNom.Text = P.Nom;
            tbxVolumePersonnel.Text = Convert.ToString(P.VolumePersonnel);
            lblVolumeGroupeValue.Text = P.VolumeGroupe.ToString("c");
            double dblNiveau = P.Niveau / 100; //Variable utilisée suite a l'erreur d'affichage sur le formulaire de modification Car affichais 300,00% au lieux de 3,00%
            lblNiveauActuelValue.Text = dblNiveau.ToString("p");
            lblGainValue.Text = P.Gain.ToString("c");
            rtbxRemarque.Text = P.Remarque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char cA = ',';
            char cB = '.';
            tbxVolumePersonnel.Text = tbxVolumePersonnel.Text.Replace(cB, cA); //Permet de transformer les "." en "," pour que ça soit valide pour les conversions futures du double.
            double dblVol = Convert.ToDouble(tbxVolumePersonnel.Text);
            dblVol = ((int)((dblVol * 20) + 0.5));//Arrondis de la monnaie au 5ct près
            dblVol /= 20;

            Pmod.Remarque = rtbxRemarque.Text;
            Pmod.Nom = tbxNom.Text;
            Pmod.VolumePersonnel = dblVol;
        }

        private void tbxVolumePersonnel_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxVolumePersonnel.Text, @"^[0-9]*(?:[\, , \.][0-9]?[0-9])?$") && tbxVolumePersonnel.Text!="")
            {
                bValideVol = true;
                tbxVolumePersonnel.ForeColor = Color.Black;

                if (bValideNom == true && bValideVol == true)
                {
                    btnOk.Enabled = true;
                }
                else
                {
                    btnOk.Enabled = false;
                }
            }
            else
            {
                bValideVol = false;
                tbxVolumePersonnel.ForeColor = Color.Red;
                btnOk.Enabled = false;
            }
        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxNom.Text, @"^[A-Z,a-z, ,\-,.]*?$") && tbxNom.Text != "")
            {
                bValideNom = true;
                tbxNom.ForeColor = Color.Black;
                if (bValideNom == true && bValideVol == true)
                {
                    btnOk.Enabled = true;
                }
                else
                {
                    btnOk.Enabled = false;
                }
            }
            else
            {
                bValideNom = false;
                tbxNom.ForeColor = Color.Red;
                btnOk.Enabled = false;
            }
        }
    }
}
