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
            label3.Text = "Affichage des formations du " + dateTimePickerDebut.Value.Date.ToString("dd/MM/yyyy") + " au " + dateTimePickerFin.Value.Date.ToString("dd/MM/yyyy");

            // Verif
            MessageBox.Show(dateDebutUS + " " + dateFinUS);

            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "'";

            DBConnect dbConnect = new DBConnect();

            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }

        private void button_placesRestantes_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            string dateDebutUS = dateTimePickerDebut.Value.Date.ToString("yyyy/MM/dd");
            string dateFinUS = dateTimePickerFin.Value.Date.ToString("yyyy/MM/dd");
            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "' AND stages_formations_placeRestantes > 0";
            label3.Text = "Places disponibles du " + dateTimePickerDebut.Value.Date.ToString("dd/MM/yyyy") + " au " + dateTimePickerFin.Value.Date.ToString("dd/MM/yyyy");
            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }

        private void button_rechercheAvancee_Click(object sender, EventArgs e)
        {
            this.Height = 561;
        }

        private void button_rechercheDate_Click(object sender, EventArgs e)
        {
            this.Height = 435;

            string dateDebutUS = dateTimePickerDebut.Value.Date.ToString("yyyy/MM/dd");
            string dateFinUS = dateTimePickerFin.Value.Date.ToString("yyyy/MM/dd");

            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "'";

            DBConnect dbConnect = new DBConnect();

            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }

        private void button_rechercheIntitule_Click(object sender, EventArgs e)
        {
            this.Height = 435;

            string intitule = textBox_intitule.Text;
            string query = "SELECT * FROM view_stages_formations WHERE formations_intitule = '" + intitule + "'";

            DBConnect dbConnect = new DBConnect();

            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }
    }
}
