using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forma
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void button_afficherFormationAVenir_Click(object sender, EventArgs e)
        {
            form_formationsAVenir formation_aVenir = new form_formationsAVenir();
            formation_aVenir.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_toutesFormations formation_toutes = new form_toutesFormations();
            formation_toutes.ShowDialog();
        }

        private void form_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // ferme l'application à la fermeture du menu
        }
    }
}
