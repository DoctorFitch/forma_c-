namespace forma
{
    partial class form_formationsAVenir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewStagesFormations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label_au = new System.Windows.Forms.Label();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_rechercheDate = new System.Windows.Forms.Button();
            this.button_rechercheIntitule = new System.Windows.Forms.Button();
            this.label_intitule = new System.Windows.Forms.Label();
            this.textBox_intitule = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.button_placesRestantes = new System.Windows.Forms.Button();
            this.button_rechercheAvancee = new System.Windows.Forms.Button();
            this.button_reinitialiser = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewStagesFormations
            // 
            this.listViewStagesFormations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewStagesFormations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStagesFormations.Location = new System.Drawing.Point(12, 74);
            this.listViewStagesFormations.Name = "listViewStagesFormations";
            this.listViewStagesFormations.Size = new System.Drawing.Size(647, 274);
            this.listViewStagesFormations.TabIndex = 4;
            this.listViewStagesFormations.UseCompatibleStateImageBehavior = false;
            this.listViewStagesFormations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Intitulé";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Association";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salle";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prix";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Places restantes";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.Width = 80;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(189, 447);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerFin.TabIndex = 8;
            // 
            // label_au
            // 
            this.label_au.AutoSize = true;
            this.label_au.Location = new System.Drawing.Point(164, 450);
            this.label_au.Name = "label_au";
            this.label_au.Size = new System.Drawing.Size(19, 13);
            this.label_au.TabIndex = 7;
            this.label_au.Text = "au";
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(74, 447);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerDebut.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Recherche avancée :";
            // 
            // button_rechercheDate
            // 
            this.button_rechercheDate.Location = new System.Drawing.Point(300, 444);
            this.button_rechercheDate.Name = "button_rechercheDate";
            this.button_rechercheDate.Size = new System.Drawing.Size(126, 23);
            this.button_rechercheDate.TabIndex = 11;
            this.button_rechercheDate.Text = "Rechercher par date";
            this.button_rechercheDate.UseVisualStyleBackColor = true;
            this.button_rechercheDate.Click += new System.EventHandler(this.button_rechercheDate_Click);
            // 
            // button_rechercheIntitule
            // 
            this.button_rechercheIntitule.Location = new System.Drawing.Point(300, 479);
            this.button_rechercheIntitule.Name = "button_rechercheIntitule";
            this.button_rechercheIntitule.Size = new System.Drawing.Size(126, 23);
            this.button_rechercheIntitule.TabIndex = 12;
            this.button_rechercheIntitule.Text = "Rechercher par intitulé";
            this.button_rechercheIntitule.UseVisualStyleBackColor = true;
            this.button_rechercheIntitule.Click += new System.EventHandler(this.button_rechercheIntitule_Click);
            // 
            // label_intitule
            // 
            this.label_intitule.AutoSize = true;
            this.label_intitule.Location = new System.Drawing.Point(12, 484);
            this.label_intitule.Name = "label_intitule";
            this.label_intitule.Size = new System.Drawing.Size(44, 13);
            this.label_intitule.TabIndex = 13;
            this.label_intitule.Text = "Intitulé :";
            // 
            // textBox_intitule
            // 
            this.textBox_intitule.Location = new System.Drawing.Point(74, 481);
            this.textBox_intitule.Name = "textBox_intitule";
            this.textBox_intitule.Size = new System.Drawing.Size(199, 20);
            this.textBox_intitule.TabIndex = 14;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(12, 449);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(39, 13);
            this.label_date.TabIndex = 15;
            this.label_date.Text = "Date : ";
            // 
            // button_placesRestantes
            // 
            this.button_placesRestantes.Location = new System.Drawing.Point(398, 363);
            this.button_placesRestantes.Name = "button_placesRestantes";
            this.button_placesRestantes.Size = new System.Drawing.Size(261, 23);
            this.button_placesRestantes.TabIndex = 16;
            this.button_placesRestantes.Text = "Afficher les formations avec places restantes";
            this.button_placesRestantes.UseVisualStyleBackColor = true;
            this.button_placesRestantes.Click += new System.EventHandler(this.button_placesRestantes_Click);
            // 
            // button_rechercheAvancee
            // 
            this.button_rechercheAvancee.Location = new System.Drawing.Point(93, 363);
            this.button_rechercheAvancee.Name = "button_rechercheAvancee";
            this.button_rechercheAvancee.Size = new System.Drawing.Size(127, 23);
            this.button_rechercheAvancee.TabIndex = 17;
            this.button_rechercheAvancee.Text = "Recherche avancée";
            this.button_rechercheAvancee.UseVisualStyleBackColor = true;
            this.button_rechercheAvancee.Click += new System.EventHandler(this.button_rechercheAvancee_Click);
            // 
            // button_reinitialiser
            // 
            this.button_reinitialiser.Location = new System.Drawing.Point(12, 363);
            this.button_reinitialiser.Name = "button_reinitialiser";
            this.button_reinitialiser.Size = new System.Drawing.Size(75, 23);
            this.button_reinitialiser.TabIndex = 18;
            this.button_reinitialiser.Text = "Réinitialiser";
            this.button_reinitialiser.UseVisualStyleBackColor = true;
            this.button_reinitialiser.Click += new System.EventHandler(this.button_reinitialiser_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(300, 514);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(126, 23);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Annuler";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // form_formationsAVenir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 396);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_reinitialiser);
            this.Controls.Add(this.button_rechercheAvancee);
            this.Controls.Add(this.button_placesRestantes);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.textBox_intitule);
            this.Controls.Add(this.label_intitule);
            this.Controls.Add(this.button_rechercheIntitule);
            this.Controls.Add(this.button_rechercheDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.label_au);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.listViewStagesFormations);
            this.Name = "form_formationsAVenir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formations à venir";
            this.Load += new System.EventHandler(this.form_formationsAVenir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewStagesFormations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.Label label_au;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_rechercheDate;
        private System.Windows.Forms.Button button_rechercheIntitule;
        private System.Windows.Forms.Label label_intitule;
        private System.Windows.Forms.TextBox textBox_intitule;
        private System.Windows.Forms.Button button_placesRestantes;
        private System.Windows.Forms.Button button_rechercheAvancee;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button_reinitialiser;
        private System.Windows.Forms.Button button_cancel;
    }
}