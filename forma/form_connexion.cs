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
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;
            AcceptButton = button_connexion;
        }

        /// <summary>
        /// Permet de verifier si l'utilisateur existe dans la base de données et le connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Impossible de se connecter au serveur.\nVérifier vos identifiants/mot de passe.\nSi le problème persiste, contacter l'administrateur réseau.", "Erreur connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        /// <summary>
        /// Fonction permettant la conversion d'un string en sha1
        /// </summary>
        /// <param name="texte"></param>
        /// <returns></returns>
        public string getSHA1(string texte)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(texte));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in re)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        private void form_connexion_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_garbage;
            textBox_idConnexion.GotFocus += new EventHandler(this.TextGotFocusMail);
            textBox_idConnexion.LostFocus += new EventHandler(this.TextLostFocusMail);

            textBox_mdpConnexion.GotFocus += new EventHandler(this.TextGotFocusPass);
            textBox_mdpConnexion.LostFocus += new EventHandler(this.TextLostFocusPass);
        }

        /// <summary>
        /// Fonction permettant de generer un effet de placeholder sur une textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TextGotFocusMail(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Adresse e-mail")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Fonction permettant de generer un effet de placeholder sur une textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TextGotFocusPass(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Mot de passe")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Fonction permettant de generer un effet de placeholder sur une textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TextLostFocusMail(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Adresse e-mail";
                tb.ForeColor = Color.SlateGray;
            }
        }

        /// <summary>
        /// Fonction permettant de generer un effet de placeholder sur une textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TextLostFocusPass(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Mot de passe";
                tb.ForeColor = Color.SlateGray;
            }
        }

        /// <summary>
        /// Fonction permettant de generer un effet de placeholder sur une textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
