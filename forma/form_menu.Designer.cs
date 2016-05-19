namespace forma
{
    partial class form_menu
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
            this.button_afficherFormationAVenir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_afficherFormationAVenir
            // 
            this.button_afficherFormationAVenir.Location = new System.Drawing.Point(60, 90);
            this.button_afficherFormationAVenir.Name = "button_afficherFormationAVenir";
            this.button_afficherFormationAVenir.Size = new System.Drawing.Size(164, 23);
            this.button_afficherFormationAVenir.TabIndex = 0;
            this.button_afficherFormationAVenir.Text = "Formations à venir";
            this.button_afficherFormationAVenir.UseVisualStyleBackColor = true;
            this.button_afficherFormationAVenir.Click += new System.EventHandler(this.button_afficherFormationAVenir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Afficher toutes les formations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_afficherFormationAVenir);
            this.Name = "form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_afficherFormationAVenir;
        private System.Windows.Forms.Button button2;
    }
}