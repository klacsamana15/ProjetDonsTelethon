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
    public partial class Main : Form
    {
        public Main()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnDonnateur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donnateur donnateurPage = new Donnateur();
            donnateurPage.ShowDialog();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {

        }

        private void txtIntro_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var lineCount = File.ReadLines(@"ListComm1.txt").Count();
            txtCommMain.Text = lineCount.ToString();

            var donateurCount = File.ReadLines(@"donateurs.txt").Count();
            txtDonateursMain.Text = donateurCount.ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }

        private void txtDonateursMain_Click(object sender, EventArgs e)
        {

        }

        private void txtCommMain_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
