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
    public partial class Affichage : Form
    {
        public ListView _listView { get;  }
        public ListView _listPrix { get; }
        public Affichage()
        {
            InitializeComponent();
        }

        private void btnAffichage_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //affichage affichagePage = new affichage();
            //affichagePage.ShowDialog();
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

        private void lblDonnateur_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void btnListedonnateurs_Click(object sender, EventArgs e)
        {
            //clears list every time I click on a button
            if (lsvListe.Items != null)
            {
                lsvListe.Items.Clear();
                lsvListe.Columns.Clear();
                lsvListe.Clear();
            }
            lsvListe.View = View.Details;
            lsvListe.Columns.Add("ID");
            lsvListe.Columns.Add("Prénom");
            lsvListe.Columns.Add("Nom");


            StreamReader readListDon = new StreamReader("donateurs.txt");
            string ligne;

            //while data in file, read line by line
            while ((ligne = readListDon.ReadLine()) != null)
            {
                
                string[] tabLigne = ligne.Split('/');
                //displays data in between slash
                string[] data = { tabLigne[0], tabLigne[1], tabLigne[2] };

                ListViewItem donList = new ListViewItem(data);
                lsvListe.Items.Add(donList);
            }
            readListDon.Close();

            for (int i = 0; i < lsvListe.Columns.Count; i++)
            {
                lsvListe.Columns[i].Width = -2; //auto-size columns
            }


         
        }

        private void lsvListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnListecommanditeurs_Click(object sender, EventArgs e)
        {
            if (lsvListe.Items != null)
            {
                lsvListe.Items.Clear();
                lsvListe.Columns.Clear();
                lsvListe.Clear();
            }
            lsvListe.View = View.Details;
            lsvListe.Columns.Add("ID");
            lsvListe.Columns.Add("Prénom");
            lsvListe.Columns.Add("Nom");
            

            StreamReader readListComm = new StreamReader("ListComm1.txt");
            string ligne;

            while ((ligne = readListComm.ReadLine()) != null)
            {
                string[] tabLigne = ligne.Split('/');
                string[] data = { tabLigne[0], tabLigne[1], tabLigne[2] };

                ListViewItem commList = new ListViewItem(data);
                lsvListe.Items.Add(commList);
            }
            readListComm.Close();

            for (int i = 0; i < lsvListe.Columns.Count; i++)
            {
                lsvListe.Columns[i].Width = -2; //auto-size columns
            }



        }

        private void btnListeprix_Click(object sender, EventArgs e)
        {
            if (lsvListe.Items != null)
            {
                lsvListe.Items.Clear();
                lsvListe.Columns.Clear();
                lsvListe.Clear();
            }
            lsvListe.View = View.Details;
            lsvListe.Columns.Add("ID");
            lsvListe.Columns.Add("Quantité");
            lsvListe.Columns.Add("Prix Choisi");
            lsvListe.Columns.Add("Points Cumulés");


       
            StreamReader readListPrix = new StreamReader("ListPrix1.txt");
            string ligne;

            while ((ligne = readListPrix.ReadLine()) != null)
            {
                string[] tabLigne = ligne.Split('/');
                
                string[] data = {tabLigne[0], tabLigne[1], tabLigne[2], tabLigne[3]};
                
                ListViewItem prixList = new ListViewItem(data);
                lsvListe.Items.Add(prixList);

            }

            readListPrix.Close();

            for (int i = 0; i < lsvListe.Columns.Count; i++)
            {
                lsvListe.Columns[i].Width = -2;
            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lsvListe.Items.Clear();
            //this.Hide();
            //Affichage affichagePage = new Affichage();
            //affichagePage.ShowDialog();
        }

        private void btnListedons_Click(object sender, EventArgs e)
        {

            if (lsvListe.Items != null)
            {
                lsvListe.Items.Clear();
                lsvListe.Columns.Clear();
                lsvListe.Clear();
            }
            //adding columns
            lsvListe.View = View.Details;
            lsvListe.Columns.Add("ID");
            lsvListe.Columns.Add("Montant");
            lsvListe.Columns.Add("Date");
            lsvListe.Columns.Add("Points Attribués");

            
            try
            {
                using (StreamReader readDon = new StreamReader("dons.txt"))
                {
                    string ligne;

                    while ((ligne = readDon.ReadLine()) != null)
                    {
                        string[] tabLigne = ligne.Split('/');
                        string[] data = { tabLigne[0], tabLigne[1], tabLigne[2], tabLigne[3] };

                        ListViewItem listDons = new ListViewItem(data);
                        lsvListe.Items.Add(listDons);
                        if (ligne == string.Empty)
                            continue;
                    }
                    readDon.Close();

                }
            }
            catch (IOException ioex)
            {
                MessageBox.Show("Erreure avec le fichier", "Attention",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        




            for (int i = 0; i < lsvListe.Columns.Count; i++)
            {
                lsvListe.Columns[i].Width = -2;
            }

         
        }

        private void lsvListe_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
   
        }
    }
}
