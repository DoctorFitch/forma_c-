﻿namespace forma
{
    partial class form_toutesFormations
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
            this.components = new System.ComponentModel.Container();
            this.formadbDataSet = new forma.formadbDataSet();
            this.formationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formationsTableAdapter = new forma.formadbDataSetTableAdapters.formationsTableAdapter();
            this.tableAdapterManager = new forma.formadbDataSetTableAdapters.TableAdapterManager();
            this.stages_formationsTableAdapter1 = new forma.formadbDataSetTableAdapters.stages_formationsTableAdapter();
            this.listViewFormations = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_load = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_retourMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formadbDataSet
            // 
            this.formadbDataSet.DataSetName = "formadbDataSet";
            this.formadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formationsBindingSource
            // 
            this.formationsBindingSource.DataMember = "formations";
            this.formationsBindingSource.DataSource = this.formadbDataSet;
            // 
            // formationsTableAdapter
            // 
            this.formationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.associationsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.domainesTableAdapter = null;
            this.tableAdapterManager.formationsTableAdapter = this.formationsTableAdapter;
            this.tableAdapterManager.inscriptionsTableAdapter = null;
            this.tableAdapterManager.intervenantsTableAdapter = null;
            this.tableAdapterManager.sallesTableAdapter = null;
            this.tableAdapterManager.stages_formationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = forma.formadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurs_typeTableAdapter = null;
            this.tableAdapterManager.utilisateursTableAdapter = null;
            // 
            // stages_formationsTableAdapter1
            // 
            this.stages_formationsTableAdapter1.ClearBeforeFill = true;
            // 
            // listViewFormations
            // 
            this.listViewFormations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFormations.Location = new System.Drawing.Point(12, 35);
            this.listViewFormations.Name = "listViewFormations";
            this.listViewFormations.Size = new System.Drawing.Size(477, 242);
            this.listViewFormations.TabIndex = 0;
            this.listViewFormations.UseCompatibleStateImageBehavior = false;
            this.listViewFormations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Intitulé";
            this.columnHeader2.Width = 176;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(412, 293);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Recharger";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date début";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date fin";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date limite d\'inscription";
            this.columnHeader5.Width = 128;
            // 
            // button_retourMenu
            // 
            this.button_retourMenu.Location = new System.Drawing.Point(12, 293);
            this.button_retourMenu.Name = "button_retourMenu";
            this.button_retourMenu.Size = new System.Drawing.Size(124, 23);
            this.button_retourMenu.TabIndex = 2;
            this.button_retourMenu.Text = "Retourner au menu";
            this.button_retourMenu.UseVisualStyleBackColor = true;
            this.button_retourMenu.Click += new System.EventHandler(this.button_retourMenu_Click);
            // 
            // form_toutesFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 328);
            this.Controls.Add(this.button_retourMenu);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.listViewFormations);
            this.Name = "form_toutesFormations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toutes les formations";
            this.Shown += new System.EventHandler(this.form_toutesFormations_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.formadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private formadbDataSet formadbDataSet;
        private System.Windows.Forms.BindingSource formationsBindingSource;
        private formadbDataSetTableAdapters.formationsTableAdapter formationsTableAdapter;
        private formadbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private formadbDataSetTableAdapters.stages_formationsTableAdapter stages_formationsTableAdapter1;
        private System.Windows.Forms.ListView listViewFormations;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_retourMenu;
    }
}