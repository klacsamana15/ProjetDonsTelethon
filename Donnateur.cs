using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telethon
{
    public partial class Donnateur : Form
    {
        public Donnateur()
        {
            InitializeComponent();
        }

        private void BtnAffichage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Affichage affichagePage = new Affichage();
            affichagePage.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commanditaire commanditairePage = new Commanditaire();
            commanditairePage.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainPage = new Main();
            mainPage.ShowDialog(); 
        }

        private void BrnDonnateur_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //donnateur donnateurPage = new donnateur();
            //donnateurPage.ShowDialog();
        }


        private void TbPrenom_Enter(object sender, EventArgs e)
        {
            if (tbPrenom.Text == "Prénom")
            {
                tbPrenom.Text = "";
                tbPrenom.ForeColor = Color.Black;
            }
        }

        private void TbPrenom_Leave(object sender, EventArgs e)
        {
            if (tbPrenom.Text == "")
            {
                tbPrenom.Text = "Prénom";
                tbPrenom.ForeColor = Color.Silver;
            }
        }

        private void TbNom_Enter(object sender, EventArgs e)
        {
            if (tbNom.Text == "Nom")
            {
                tbNom.Text = "";
                tbNom.ForeColor = Color.Black;
            }
        }

        private void TbNom_Leave(object sender, EventArgs e)
        {
            if (tbNom.Text == "")
            {
                tbNom.Text = "Nom";
                tbNom.ForeColor = Color.Silver;
            }
        }

        private void TbTelephone_Enter(object sender, EventArgs e)
        {
            if (tbTelephone.Text == "###-###-####")
            {
                tbTelephone.Text = "";
                tbTelephone.ForeColor = Color.Black;
            }
            
        }

        private void TbTelephone_Leave(object sender, EventArgs e)
        {
            if (tbTelephone.Text == "")
            {
                tbTelephone.Text = "###-###-####";
                tbTelephone.ForeColor = Color.Silver;
            }
        }


        public static string valPrenom = "";
        public static string valNom = "";
        public static string valTelephone = "";
        public static string valCourriel = "";

        private void BtnSuivante_Click(object sender, EventArgs e)
        {
            
            if ((tbPrenom.Text == "Prénom") || (tbNom.Text == "Nom") || (tbTelephone.Text == "Téléphone") || (tbCourriel.Text == "Courriel"))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
           
            }
            else
            {
                //format prénom: n'accepte pas les prénoms combinés (pas d'espaces) et string doit être plus que 2 charactères
                if ((Regex.IsMatch(tbPrenom.Text, @"^[a-zA-Z]+$") == false) || (tbPrenom.Text.Length > 2 == false))
                {
                    MessageBox.Show("Veuillez entrez que des lettres et plus que 2 charactères", "Prénom", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                //format nom: n'accepte pas les noms combinés(pas d'espaces) et string doit être plus que 2 charactères
                if ((Regex.IsMatch(tbNom.Text, @"^[a-zA-Z]+$") == false) || (tbNom.Text.Length > 2 == false))
                {
                    MessageBox.Show("Veuillez entrez que des lettres et plus que 2 charactères", "Nom", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                //format ###-###-#### (accepte avec ou sans les -)
                if (Regex.IsMatch(tbTelephone.Text, "^(\\d{3}[-]?){2}\\d{4}$") == false)
                {
                    MessageBox.Show("Téléphone invalide, svp respectez le format ###-###-####", "Téléphone", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                //format couriel@couriel (check si il y a un @ présent)
                if (Regex.IsMatch(tbCourriel.Text, "^(.+)@(\\S+)$") == false)
                {
                    MessageBox.Show("Courriel invalide, svp respectez le format courriel@courriel", "Adresse Courriel", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Bien ajouté.", "Donateur", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                valPrenom = tbPrenom.Text;
                valNom = tbNom.Text;
                valTelephone = tbTelephone.Text;
                valCourriel = tbCourriel.Text;


                this.Hide();
                Donnateur2 donnateur2 = new Donnateur2();
                donnateur2.ShowDialog();
            }
        }


        private void TbCourriel_Enter(object sender, EventArgs e)
        {
            if (tbCourriel.Text == "Courriel")
            {
                tbCourriel.Text = "";
                tbCourriel.ForeColor = Color.Black;
            }
        }

        private void TbCourriel_Leave(object sender, EventArgs e)
        {
            if (tbCourriel.Text == "")
            {
                tbCourriel.Text = "Courriel";
                tbCourriel.ForeColor = Color.Silver;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainPage = new Main();
            mainPage.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }

        private void Donnateur_Load(object sender, EventArgs e)
        {

        }
    }
}


