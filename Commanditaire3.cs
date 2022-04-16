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
    public partial class Commanditaire3 : Form
    {
        public ListView _listView { get; set; }
        public ListView _listPrix { get; set; }

        public Commanditaire3()
        {
            InitializeComponent();
        }

        public Commanditaire3(ListView listView, ListView listPrix)
        {
            _listView = listView;
            InitializeComponent();
            _listPrix = listPrix;
         }

        private void Commanditaire_Load(object sender, EventArgs e)
        {
            lblOutputPersonnels.Text = "Prénom: " + Commanditaire.valPrenom + "\nNom: " + Commanditaire.valNom;
            lblOutputPersonnels.ForeColor = Color.Black;
            lblOutputPrix.Text = "Quantité: " + Commanditaire2.valQuantite + "\nPrix choisi: " + Commanditaire2.prixChoisi + "\nPoints Cummulés: " + Commanditaire2.valPoints;
            lblOutputPrix.ForeColor = Color.Black;

            //ListComm1.Items.AddRange((from ListViewItem item in _listView.Items
                                      //select (ListViewItem)item.Clone()).ToArray());

            //ListPrix1.Items.AddRange((from ListViewItem item in _listPrix.Items
                                      //select (ListViewItem)item.Clone()).ToArray());

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

       
        private void AjouterComm(String nomComm, String prenomComm, String quantiteComm, String prixComm)
        {
            /// Tableau
            String[] rowComm = new String[] { nomComm, prenomComm, quantiteComm, prixComm };

            ListViewItem item = new ListViewItem(rowComm);

            //add item
            //ListComm1.Items.Add(item);
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string initial = "00" + Commanditaire.valPrenom.Substring(0, 3) + Commanditaire.valNom.Substring(0, 2);
            StreamWriter saveListComm1 = new StreamWriter("ListComm1.txt", true);

            saveListComm1.WriteLine(initial + "/" + Commanditaire.valPrenom + "/" + Commanditaire.valNom);
            

            /*foreach (ListViewItem listComm1 in ListComm1.Items)
            {
                saveListComm1.WriteLine(listComm1.SubItems[1].Text + " " + listComm1.SubItems[0].Text);
            }*/

            saveListComm1.Close();



            StreamWriter saveListPrix = new StreamWriter("ListPrix1.txt", true);

            saveListPrix.WriteLine(initial + "/" + Commanditaire2.valQuantite + "/" + Commanditaire2.prixChoisi + "/" + Commanditaire2.valPoints);


            /*foreach (ListViewItem listComm1 in ListComm1.Items)
            {
                saveListComm1.WriteLine(listComm1.SubItems[0].Text + " " + listComm1.SubItems[1].Text);
            }*/

            saveListPrix.Close();

            MessageBox.Show("Excellent!", "Enregistré", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

            this.Hide();
            Commanditaire commanditairePage = new Commanditaire();
            commanditairePage.ShowDialog();
        }

        private void ListPrix1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSuivante_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commanditaire commanditairePage = new Commanditaire();
            commanditairePage.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }
    }
}
