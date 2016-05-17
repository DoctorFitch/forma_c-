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

namespace forma
{
    public partial class form_formationsAVenir : Form
    {
        public form_formationsAVenir()
        {
            InitializeComponent();
        }

        private void form_formationsAVenir_Load(object sender, EventArgs e)
        {
            // Permet de changer l'affichage des datePicker en dd/MM/yyyy
            dateTimePickerDebut.Format = DateTimePickerFormat.Custom;
            dateTimePickerDebut.CustomFormat = "dd/MM/yyyy";

            dateTimePickerFin.Value = DateTime.Now.AddDays(7);
            dateTimePickerFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFin.CustomFormat = "dd/MM/yyyy";

            string dateDebutUS = dateTimePickerDebut.Value.Date.ToString("yyyy/MM/dd");
            string dateFinUS = dateTimePickerFin.Value.Date.ToString("yyyy/MM/dd");

            // Ajout des dates de la semaine au label
            label3.Text += " " + dateTimePickerDebut.Value.Date.ToString("dd/MM/yyyy") + " au " + dateTimePickerFin.Value.Date.ToString("dd/MM/yyyy"); ;

            // Verif
            MessageBox.Show(dateDebutUS + " " + dateFinUS);

            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "'";

            DBConnect dbConnect = new DBConnect();

            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }
    }
}
