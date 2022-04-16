using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace telethon
{
    public partial class Commanditaire : Form
    {
        public Commanditaire()
        {
            InitializeComponent();
           
        }

        private void btnAffichage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Affichage affichagePage = new Affichage();
            affichagePage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //commanditaire commanditairePage = new commanditaire();
            //commanditairePage.ShowDialog();
        }

    

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainPage = new Main();
            mainPage.ShowDialog();
        }

        private void brnDonnateur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donnateur donnateurPage = new Donnateur();
            donnateurPage.ShowDialog();
        }


        public static string valPrenom = "";
        public static string valNom = "";

        private void btnAjouterComm_Click(object sender, EventArgs e)
        {
            if ((txtPrenomComm.Text == "Prénom") || (txtNomComm.Text == "Nom"))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;

            }
            else
            {
                //format prénom: n'accepte pas les prénoms combinés (pas d'espaces) et string doit être plus que 2 charactères
                if ((Regex.IsMatch(txtPrenomComm.Text, @"^[a-zA-Z]+$") == false) || (txtPrenomComm.Text.Length > 2 == false)) 
                {
                    MessageBox.Show("Veuillez entrez que des lettres et plus que 2 charactères", "Prénom", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                //format nom: n'accepte pas les noms combinés(pas d'espaces) et string doit être plus que 2 charactères
                if ((Regex.IsMatch(txtNomComm.Text, @"^[a-zA-Z]+$") == false) || (txtNomComm.Text.Length > 2 == false)) 
                {
                    MessageBox.Show("Veuillez entrez que des lettres et plus que 2 charactères", "Nom", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
            }
                //AjouterComm(txtNomComm.Text, txtPrenomComm.Text);
            MessageBox.Show("Bien ajouté.", "Commanditaire", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

            valPrenom = txtPrenomComm.Text;
            valNom = txtNomComm.Text;


            this.Hide();
            Commanditaire2 commanditaire2 = new Commanditaire2(ListComm1);
            commanditaire2.ShowDialog();
        }

        private void AjouterComm(String nomComm, String prenomComm)
        {
            /// Tableau
           String[] rowCommanditaires = new String[] { nomComm, prenomComm};

            //Listview
            ListViewItem item = new ListViewItem(rowCommanditaires);

            ////add item
            ListComm1.Items.Add(item);
        }

        private void Commanditaire_Load(object sender, EventArgs e)
        {
            //ListComm1.Hide();
            //propietes
           //ListComm1.View = View.List;
           
            //items
            //ListComm1.Items.Add("Nom", 150);
            //ListComm1.Items.Add("Prenom", 150);

        }

        private void btnSuivante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commanditaire2 commanditaire2 = new Commanditaire2(ListComm1);
            commanditaire2.ShowDialog();

           
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

        private void txtNomComm_Enter(object sender, EventArgs e)
        {
            if (txtNomComm.Text == "Nom")
            {
                txtNomComm.Text = "";
                txtNomComm.ForeColor = Color.Black;
            }
        }

        private void txtNomComm_Leave(object sender, EventArgs e)
        {
            if (txtNomComm.Text == "")
            {
                txtNomComm.Text = "Nom";
                txtNomComm.ForeColor = Color.Silver;
            }
        }

        private void txtPrenomComm_Enter(object sender, EventArgs e)
        {
            if (txtPrenomComm.Text == "Prénom")
            {
                txtPrenomComm.Text = "";
                txtPrenomComm.ForeColor = Color.Black;
            }
        }

        private void txtPrenomComm_Leave(object sender, EventArgs e)
        {
            if (txtPrenomComm.Text == "")
            {
                txtPrenomComm.Text = "Prénom";
                txtPrenomComm.ForeColor = Color.Silver;
            }
        }

        private void txtNomComm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
