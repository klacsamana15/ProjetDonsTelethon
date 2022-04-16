using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telethon
{
    public partial class Telethon : Form
    {
        public Telethon()
        {
            InitializeComponent();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrez_Click(object sender, EventArgs e)
            {
                string utilisateur = txtNom.Text.Trim().ToLower();
            string motPasse = txtPass.Text.Trim();
                if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(motPasse))
                {
                    if (utilisateur == "téléthon2021" && motPasse == "Don@2021") 

                    {
                    MessageBox.Show("Bienvenue utilisateur. Les informations saisies sont valides.", "Bienvenue", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //Application.Exit();
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                }
                    else
                    {
                        MessageBox.Show("Les informations saisies ne sont pas valides.",
                        "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        txtNom.Text = String.Empty;
                        txtPass.Text = String.Empty;
                        txtNom.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtNom.Focus();
                }
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Telethon_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoPage = new Info();
            infoPage.ShowDialog();
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                txtPass.PasswordChar = '*'; 

            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtPass.PasswordChar = '\0'; //unmask characters

            }
        }
    }
}
