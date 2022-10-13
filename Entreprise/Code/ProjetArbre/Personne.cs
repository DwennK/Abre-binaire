using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Runtime.Serialization; //Permet à la classe d'être Sérialisée

namespace ProjetArbre
{
    [Serializable()] //Permet à la classe d'être Sérialisée
    public class Personne
    {
        private Color couleur;
        private double gain;//Ce qu'on a gangé au final
        private double gainAssocies; //Gain des enfants
        private double gainTheorique; //Ce qu'on aura gangé si la distribution n'aurait pas été faite
        private double niveau; 
        private string nom;
        private string remarque;
        private double volumeGroupe;
        private double volumePersonnel;
        public Personne()
        {
            NomHasard();
            volumePersonnel = 500.00; //Valeur fixe pour tous.
        }
        public Personne(string strNom)
        {
            nom = strNom;
            volumePersonnel = 500.00;
        }
        public string Affiche(bool bTooltip)
        {
            if (bTooltip == true) //Si c'est pour le tooltiptext, la remarque ne doit pas être présente.
            {
                return nom + "\nNiveau: " + niveau + "\nPerso: " + volumePersonnel.ToString("c") + "\nGroupe: " + volumeGroupe.ToString("c") + "\nGain Théorique: " + gainTheorique.ToString("c") + "\nGain net: " + gain.ToString("c") + "\nGain associés: " + gainAssocies.ToString("c");
            }
            else
            {
                return nom + "\nNiveau:\t\t" + niveau + "\nPerso:\t\t" + volumePersonnel.ToString("c") + "\nGroupe:\t\t" + volumeGroupe.ToString("c") + "\nGain Théorique:\t" + gainTheorique.ToString("c") + "\nGain net:\t\t" + gain.ToString("c") + "\nGain associés:\t" + gainAssocies.ToString("c") + "\nRemarque:\n" + remarque;
            }    
        }

        public void CalculNiveau()
        {
            double dblChiffre = VolumeGroupe + VolumePersonnel;
            //Si aucune de ces catégories, le niveau retourne à zero.
            if (dblChiffre < 500)
            {
                Niveau = 1;
                Couleur = Color.Black;
            }
            else if (dblChiffre >= 500 && dblChiffre < 1500)
            {
                Niveau = 3;
                Couleur = Color.DarkGoldenrod;
            }
            else if (dblChiffre >= 1500 && dblChiffre < 2500)
            {
                Niveau = 6;
                Couleur = Color.Cyan;
            }
            else if (dblChiffre >= 2500 && dblChiffre < 4800)
            {
                Niveau = 9;
                Couleur = Color.Firebrick; //Ancien yellow mais la couleur ne se lisait pas bien
            }
            else if (dblChiffre >= 4800 && dblChiffre < 6500)
            {
                Niveau = 12;
                Couleur = Color.Maroon;
            }
            else if (dblChiffre >= 6500 && dblChiffre < 10000)
            {
                Niveau = 15;
                Couleur = Color.Salmon;
            }
            else if (dblChiffre >= 10000 && dblChiffre < 20000)
            {
                Niveau = 18;
                Couleur = Color.Green;
            }
            else
            {
                Niveau = 20;
                Couleur = Color.Red;
            }
          	GainTheorique = dblChiffre * Niveau /100;
            Gain = GainTheorique - GainAssocies;
        }

        public void NomHasard()
        {
            int iNum;
            char cLettre;
            Random _random = new Random();//créadtion du random
            for (int iCpt = 0; iCpt <= 3; iCpt++) //Genere un niom de 4 lettres
            {
                if (iCpt == 1 || iCpt == 3) //Permet de ne generer que des voyelles pour les lettres numero 2 et 4
                {
                    do
                    {
                        iNum = _random.Next(0, 26); // Zero to 25
                    } while (iNum != 0 && iNum != 4 && iNum != 8 && iNum != 14 && iNum != 20 && iNum != 24);//test pour savoir voyelle
                }
                else
                    iNum = _random.Next(0, 26); // Zero to 25
                
                if(iCpt==0)
                    cLettre = (char)('A' + iNum);//transorme le random en lettre majuscule pour le premier caractère
                else
                    cLettre = (char)('a' + iNum);//transorme le random en lettre
                nom += Convert.ToString(cLettre);//insère la lettre au nom
            }
        }
        public Color Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
        public double Gain
        {
            get { return gain; }
            set { gain = value; }
        }
        public double GainAssocies
        {
            get { return gainAssocies; }
            set { gainAssocies = value; }
        }
        public double GainTheorique
        {
            get { return gainTheorique; }
            set { gainTheorique = value; }
        }
        public double Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Remarque
        {
            get { return remarque; }
            set { remarque = value; }
        }
        public double VolumeGroupe
        {
            get { return volumeGroupe; }
            set { volumeGroupe = value; }
        }
        public double VolumePersonnel
        {
            get { return volumePersonnel; }
            set { volumePersonnel = value; }
        }
    }
}
        