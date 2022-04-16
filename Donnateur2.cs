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
    public partial class Donnateur2 : Form
    {

        public Donnateur2()
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

        public static string valMontant = "";
        public static string valNumeroCarte = "";
        public static string valDateMM = "";
        public static string valDateYYYY = "";
        public static string valCodeValidation = "";
        public static int valpointsdonnateur = 0;

        private void BtnSuivante_Click(object sender, EventArgs e)
        {
            if ((tbMontant.Text == "Montant") || (tbNumeroCarte.Text == "Numéro de carte") || (tbDateMM.Text == "MM") || (tbDateYYYY.Text == "YYYY") || (tbCodeValidation.Text == "CVV"))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            else
            {
              
                //format numéro de carte: 16 nombres avec ou sans les espaces
                if (Regex.IsMatch(tbNumeroCarte.Text, "^[0-9]{4}[ ]?[0-9]{4}[ ]?[0-9]{4}[ ]?[0-9]{4}[ ]?$") == false)
                {
                    MessageBox.Show("Numéro de carte invalide.", "Numéro de carte", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                //format mois d'expiration: 01 à 12
                if (Regex.IsMatch(tbDateMM.Text, "^(0[1-9]|1[0-2])") == false)
                {
                    MessageBox.Show("Mois invalide.", "Mois d'expiration", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                //format année d'expiration: strictement 4 nombres
                if (Regex.IsMatch(tbDateYYYY.Text, "^[0-9]{4}$") == false)
                {
                    MessageBox.Show("Année invalide.", "Année d'expiration", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                //format cvv: strictement 3 nombres
                if (Regex.IsMatch(tbCodeValidation.Text, "^[0-9]{3}$") == false)
                {
                    MessageBox.Show("CVV invalide.", "Code de validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Bien ajouté.", "Donateur", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                valMontant = tbMontant.Text;
                valNumeroCarte = tbNumeroCarte.Text;
                valDateMM = tbDateMM.Text;
                valDateYYYY = tbDateYYYY.Text;
                valCodeValidation = tbCodeValidation.Text;
                valpointsdonnateur = Int32.Parse(tbMontant.Text);
                valpointsdonnateur = Pointsprix(valpointsdonnateur);


                this.Hide();
                Donnateur3 donnateur3 = new Donnateur3();
                donnateur3.ShowDialog();
            }
        }

        private int Pointsprix(int valeur)
        {
            int montant2 = valeur;
            int pointstotal = 0;

            if (montant2 > 50 & montant2 <= 199)
            {
                return pointstotal += 1;

            }
            else if (montant2 >= 200 & montant2 <= 349)
            {
                return pointstotal += 2;
            }
            else if (montant2 >= 350 & montant2 <= 499)
            {
                return pointstotal += 3;
            }
            else if (montant2 >= 500)
            {
                return pointstotal += 5;
            }

            return pointstotal;
        }

        private void TbMontant_Enter(object sender, EventArgs e)
        {
            if (tbMontant.Text == "Montant")
            {
                tbMontant.Text = "";
                tbMontant.ForeColor = Color.Black;
            }
        }

        private void TbMontant_Leave(object sender, EventArgs e)
        {
            if (tbMontant.Text == "")
            {
                tbMontant.Text = "Montant";
                tbMontant.ForeColor = Color.Silver;
            }
        }


        private void TbNumeroCarte_Enter(object sender, EventArgs e)
        {
            if (tbNumeroCarte.Text == "#### #### #### ####")
            {
                tbNumeroCarte.Text = "";
                tbNumeroCarte.ForeColor = Color.Black;
            }
        }

        private void TbNumeroCarte_Leave(object sender, EventArgs e)
        {
            if (tbNumeroCarte.Text == "")
            {
                tbNumeroCarte.Text = "#### #### #### ####";
                tbNumeroCarte.ForeColor = Color.Silver;
            }
        }

        private void TbDateMM_Enter(object sender, EventArgs e)
        {
            if (tbDateMM.Text == "MM")
            {
                tbDateMM.Text = "";
                tbDateMM.ForeColor = Color.Black;
            }
        }

        private void TbDateMM_Leave(object sender, EventArgs e)
        {
            if (tbDateMM.Text == "")
            {
                tbDateMM.Text = "MM";
                tbDateMM.ForeColor = Color.Silver;
            }
        }


        private void TbDateYYYY_Enter(object sender, EventArgs e)
        {
            if (tbDateYYYY.Text == "YYYY")
            {
                tbDateYYYY.Text = "";
                tbDateYYYY.ForeColor = Color.Black;
            }
        }

        private void TbDateYYYY_Leave(object sender, EventArgs e)
        {
            if (tbDateYYYY.Text == "")
            {
                tbDateYYYY.Text = "YYYY";
                tbDateYYYY.ForeColor = Color.Silver;
            }
        }

        private void TbCodeValidation_Enter(object sender, EventArgs e)
        {
            if (tbCodeValidation.Text == "CVV")
            {
                tbCodeValidation.Text = "";
                tbCodeValidation.ForeColor = Color.Black;
            }
        }

        private void TbCodeValidation_Leave(object sender, EventArgs e)
        {
            if (tbCodeValidation.Text == "")
            {
                tbCodeValidation.Text = "CVV";
                tbCodeValidation.ForeColor = Color.Silver;
            }
        }

        public static string carteDeCredit;

        private void rbAmex_CheckedChanged(object sender, EventArgs e)
        {
            carteDeCredit = "American Express";
        }

        private void rbMC_CheckedChanged(object sender, EventArgs e)
        {
            carteDeCredit = "MasterCard";
        }

        private void rbVisa_CheckedChanged(object sender, EventArgs e)
        {
            carteDeCredit = "Visa";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donnateur donnateur = new Donnateur();
            donnateur.ShowDialog();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }

        private void tbMontant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
