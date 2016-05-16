using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectCsharpToMysql;
using System.Security.Cryptography;

namespace forma
{
    public partial class form_connexion : Form
    {
        public form_connexion()
        {
            InitializeComponent();
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            form_menu menu = new form_menu();
            
            string idConnexion = textBox_idConnexion.Text;
            string mdpConnexion = getSHA1(textBox_mdpConnexion.Text); // conversion du mot de passe en SHA1

            DBConnect uneConnexion = new DBConnect();

            // compte si l'utilisateur existe avec le combo id/mdp
            int nombreUtilisateur = uneConnexion.Count("SELECT COUNT(*) FROM utilisateurs  WHERE utilisateurs_email = '" + idConnexion + "' AND utilisateurs_motDePasse = '" + mdpConnexion + "'");

            // si le retour est 1 la connexion est réussie
            if (nombreUtilisateur == 1)
            {
                menu.Show(); // on fait apparaitre le menu de selection 
                this.Hide();
            }
            else
                MessageBox.Show("Erreur de connexion");

            
        }

        // Fonction permettant de convertir un string en sha1 
        public string getSHA1(string texte)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(texte));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach(byte b in re)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
