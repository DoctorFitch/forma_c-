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
//Add MySql Library
using MySql.Data.MySqlClient;

namespace forma
{
    public partial class form_toutesFormations : Form
    {

        public MySqlConnection connection;
        public string server = "mysql.francois-garcia.ws";
        public string database = "formadb";
        public string uid = "fitchadmin";
        public string password = "menphis31";

        /*
        server = "mysql.francois-garcia.ws";
        database = "formadb";
        uid = "fitchadmin";
        password = "menphis31";
        */


        public form_toutesFormations()
        {
            InitializeComponent();

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            
        }

        private void button_retourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_toutesFormations_Shown(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            dbConnect.listViewFormation("SELECT * FROM formations", listViewFormations);
        }
    }
}
