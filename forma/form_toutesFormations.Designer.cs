namespace forma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_toutesFormations));
            this.formadbDataSet = new forma.formadbDataSet();
            this.formationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formationsTableAdapter = new forma.formadbDataSetTableAdapters.formationsTableAdapter();
            this.tableAdapterManager = new forma.formadbDataSetTableAdapters.TableAdapterManager();
            this.stages_formationsTableAdapter1 = new forma.formadbDataSetTableAdapters.stages_formationsTableAdapter();
            this.listViewFormations = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_load = new System.Windows.Forms.Button();
            this.button_retourMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.formadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.listViewFormations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Niveau";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prénom intervenant";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail";
            this.columnHeader5.Width = 135;
            // 
            // button_load
            // 
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.Location = new System.Drawing.Point(414, 293);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Recharger";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_retourMenu
            // 
            this.button_retourMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_retourMenu.Location = new System.Drawing.Point(12, 293);
            this.button_retourMenu.Name = "button_retourMenu";
            this.button_retourMenu.Size = new System.Drawing.Size(124, 23);
            this.button_retourMenu.TabIndex = 2;
            this.button_retourMenu.Text = "Retourner au menu";
            this.button_retourMenu.UseVisualStyleBackColor = true;
            this.button_retourMenu.Click += new System.EventHandler(this.button_retourMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::forma.Properties.Resources.NiagaraFalls;
            this.pictureBox1.Location = new System.Drawing.Point(-1340, -289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1850, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // form_toutesFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 328);
            this.Controls.Add(this.button_retourMenu);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.listViewFormations);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 367);
            this.Name = "form_toutesFormations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toutes les formations";
            this.Shown += new System.EventHandler(this.form_toutesFormations_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.formadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}