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
            DBConnect dbConnect = new DBConnect();

            // Permet de changer l'affichage des datePicker en dd/MM/yyyy
            dateTimePickerDebut.Format = DateTimePickerFormat.Custom;
            dateTimePickerDebut.CustomFormat = "dd/MM/yyyy";

            dateTimePickerFin.Value = DateTime.Now.AddDays(7);
            dateTimePickerFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFin.CustomFormat = "dd/MM/yyyy";

            // on converti dans le bon format
            string dateDebutUS = dateTimePickerDebut.Value.Date.ToString("yyyy/MM/dd");
            string dateFinUS = dateTimePickerFin.Value.Date.ToString("yyyy/MM/dd");

            // Ajout des dates de la semaine au label
            label3.Text = "Affichage des formations du " + dateTimePickerDebut.Value.Date.ToString("dd/MM/yyyy") + " au " + dateTimePickerFin.Value.Date.ToString("dd/MM/yyyy");

            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "'";
            
            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }

        private void button_placesRestantes_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            // on converti dans le bon format
            string dateDebutUS = dateTimePickerDebut.Value.Date.ToString("yyyy/MM/dd");
            string dateFinUS = dateTimePickerFin.Value.Date.ToString("yyyy/MM/dd");

            // requete de select
            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "' AND stages_formations_placeRestantes > 0";
            label3.Text = "Places disponibles du " + dateTimePickerDebut.Value.Date.ToString("dd/MM/yyyy") + " au " + dateTimePickerFin.Value.Date.ToString("dd/MM/yyyy");

            dbConnect.listViewStagesFormations(query, listViewStagesFormations);

            if(listViewStagesFormations.Items.Count == 0)
            {
                MessageBox.Show("Il n'existe aucune formation avec des places disponibles pour cette période.", "Place disponibles", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_rechercheAvancee_Click(object sender, EventArgs e)
        {
            this.Height = 587;
        }

        private void button_rechercheDate_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            this.Height = 435;

            // on converti dans le bon format
            string dateDebutUS = dateTimePickerDebut.Value.Date.ToString("yyyy/MM/dd");
            string dateFinUS = dateTimePickerFin.Value.Date.ToString("yyyy/MM/dd");

            // changement du label
            label3.Text = "Affichage des formations du " + dateTimePickerDebut.Value.Date.ToString("dd/MM/yyyy") + " au " + dateTimePickerFin.Value.Date.ToString("dd/MM/yyyy");

            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "'";

            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }

        private void button_rechercheIntitule_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            this.Height = 435;

            // changement du label
            label3.Text = "Affichage des formations ayant pour intitulé " + textBox_intitule.Text;

            string intitule = textBox_intitule.Text;
            string query = "SELECT * FROM view_stages_formations WHERE formations_intitule = '" + intitule + "'";
            
            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }

        private void button_reinitialiser_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            // on reinitialise les dates aux jour d'aujourd'hui + 7j
            dateTimePickerDebut.Value = DateTime.Now;
            dateTimePickerFin.Value = DateTime.Now.AddDays(7);

            // on converti dans le bon format
            string dateDebutUS = dateTimePickerDebut.Value.Date.ToString("yyyy/MM/dd");
            string dateFinUS = dateTimePickerFin.Value.Date.ToString("yyyy/MM/dd");

            // Ajout des dates de la semaine au label
            label3.Text = "Affichage des formations du " + dateTimePickerDebut.Value.Date.ToString("dd/MM/yyyy") + " au " + dateTimePickerFin.Value.Date.ToString("dd/MM/yyyy");

            // requete de selection
            string query = "SELECT * FROM view_stages_formations WHERE stages_formations_date >= '" + dateDebutUS + "' AND stages_formations_date <= '" + dateFinUS + "'";
            
            dbConnect.listViewStagesFormations(query, listViewStagesFormations);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Height = 435;
        }
    }
}
