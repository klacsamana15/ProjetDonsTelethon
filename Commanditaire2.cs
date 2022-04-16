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
    public partial class Commanditaire2 : Form

    {
        public ListView _listView { get; set; }

        public Commanditaire2()
        {
            InitializeComponent();
            
        }

        public Commanditaire2(ListView listView)
        {
            _listView = listView;
            InitializeComponent();
        }

        private void Commanditaire2_Load(object sender, EventArgs e)
        {
            ListComm1.Hide();
            ListPrix1.Hide();
            ListComm1.Items.AddRange((from ListViewItem item in _listView.Items
                                      select (ListViewItem)item.Clone()).ToArray());

        }

        private void btnAffichage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Affichage affichagePage = new Affichage();
            affichagePage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commanditaire commanditairePage = new Commanditaire();
            commanditairePage.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private String getSelected()
        {
            if (rdioTv.Checked)
            {
                return "Television";
            }
            else if (rdioCalendriee.Checked)
            {
                return "Calendrier";
            }
            else if (rdBbq.Checked)
            {
                return "BBQ";
            }
            else if (rdRepas.Checked)
            {
                return "Repas por 2";
            }
            return "none";


        }

        public static string valQuantite = "";
        public static string valPoints = "";

        private void btnAjouterComm_Click(object sender, EventArgs e)
        {
            if ((txtQuantite.Text == "Quantité"))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            else
            {
                //format 000: strictement nombres
                if (Regex.IsMatch(txtQuantite.Text, "^[0-9]+$") == false)
                {
                    MessageBox.Show("Entrez la quantité.", "Quantité", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
            }
            
            //Convert AttribuePrix int en String
            
            AjouterPrix(txtQuantite.Text, getSelected(), Convert.ToString(AtribuePrix()));
            MessageBox.Show("Bien ajouté.", "Prix", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

            valQuantite = txtQuantite.Text;
            valPoints = Convert.ToString(AtribuePrix());

            this.Hide();
            Commanditaire3 commanditaire3 = new Commanditaire3(ListComm1, ListPrix1);

            commanditaire3.ShowDialog();
        }

        private void AjouterPrix(String quantiteComm, String prixComm, String prixAttribue)
        {

           
            /// Tableau
            String[] rowPrix = new String[] { quantiteComm, prixComm, prixAttribue };

            ListViewItem item = new ListViewItem(rowPrix);

            //add item
            ListPrix1.Items.Add(item);
        }


        private int AtribuePrix()
        {
            
            int prix = 0;

            if (rdioTv.Checked)
            {
                return prix = 20 * Int32.Parse(txtQuantite.Text);
            }
            else if (rdioCalendriee.Checked)
            {
                return prix = 1 * Int32.Parse(txtQuantite.Text);
            }
            else if (rdBbq.Checked)
            {
                return prix = 15 * Int32.Parse(txtQuantite.Text);
            }
            else if (rdRepas.Checked)
            {
                return prix = 10 * Int32.Parse(txtQuantite.Text);
            }

            return prix;
        }

        
        private void btnSuivante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commanditaire3 commanditaire3 = new Commanditaire3(ListComm1,ListPrix1);
           
            commanditaire3.ShowDialog();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commanditaire commanditairePage = new Commanditaire();
            commanditairePage.ShowDialog();
        }

        private void ListPrix1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListComm1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantite_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }

        public static string prixChoisi;

        private void rdioTv_CheckedChanged(object sender, EventArgs e)
        {
            prixChoisi = "Télévision";
        }

        private void rdioCalendriee_CheckedChanged(object sender, EventArgs e)
        {
            prixChoisi = "Calendrier";
        }

        private void rdRepas_CheckedChanged(object sender, EventArgs e)
        {
            prixChoisi = "Repas pour deux";
        }

        private void rdBbq_CheckedChanged(object sender, EventArgs e)
        {
            prixChoisi = "BBQ";
        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantite_Leave(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "")
            {
                txtQuantite.Text = "Quantité";
                txtQuantite.ForeColor = Color.Silver;
            }
        }

        private void txtQuantite_Enter(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "Quantité")
            {
                txtQuantite.Text = "";
                txtQuantite.ForeColor = Color.Black;
            }
        }

        private void lblDonnateur_Click(object sender, EventArgs e)
        {

        }
    }
}
