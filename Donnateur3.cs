using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace telethon
{
    public partial class Donnateur3 : Form
    {
        public Donnateur3()
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

        private void BtnSuivante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donnateur donnateur = new Donnateur();
            donnateur.ShowDialog();
        }
        string date = DateTime.Now.ToLongDateString();
        private void Donnateur3_Load(object sender, EventArgs e)
        {
            lblOutputPersonnels.Text = "Prénom: " + Donnateur.valPrenom + "\nNom: " + Donnateur.valNom + "\nTéléphone: " + Donnateur.valTelephone + "\nCourriel: " + Donnateur.valCourriel + "\nPoints attribués: " + Donnateur2.valpointsdonnateur;
            lblOutputPersonnels.ForeColor = Color.Black;
            lblOutputPaiement.Text = "Montant: " + Donnateur2.valMontant + "\nCarte de crédit: " + Donnateur2.carteDeCredit + "\nNuméro de Carte: " + Donnateur2.valNumeroCarte + "\nDate d'expiration: " + Donnateur2.valDateMM + "/" + Donnateur2.valDateYYYY + "\nDate: " + date;
            lblOutputPaiement.ForeColor = Color.Black;

           
        }

        private void btnEnregistrer_Click(object sender, EventArgs e) 
        {
            //initial = creating a customized ID
            string initial = "00" + Donnateur.valPrenom.Substring(0, 3) + Donnateur.valNom.Substring(0, 2);
            StreamWriter saveDonateur = new StreamWriter("donateurs.txt", true);

            saveDonateur.WriteLine(initial + "/" + Donnateur.valPrenom + "/" + Donnateur.valNom);
            saveDonateur.Close();


            StreamWriter saveDon = new StreamWriter("dons.txt", true);

            saveDon.WriteLine(initial + "/" + Donnateur2.valMontant + "/" + date + "/" + Donnateur2.valpointsdonnateur);
            saveDon.Close();

            MessageBox.Show("Excellent!", "Enregistré", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

            this.Hide();
            Donnateur donnateur = new Donnateur();
            donnateur.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }
    }
}
