namespace forma
{
    partial class form_connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_connexion));
            this.textBox_idConnexion = new System.Windows.Forms.TextBox();
            this.textBox_mdpConnexion = new System.Windows.Forms.TextBox();
            this.button_connexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_garbage = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_idConnexion
            // 
            this.textBox_idConnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_idConnexion.ForeColor = System.Drawing.Color.Gray;
            this.textBox_idConnexion.Location = new System.Drawing.Point(92, 196);
            this.textBox_idConnexion.Name = "textBox_idConnexion";
            this.textBox_idConnexion.Size = new System.Drawing.Size(157, 20);
            this.textBox_idConnexion.TabIndex = 1;
            this.textBox_idConnexion.Text = "Adresse e-mail";
            // 
            // textBox_mdpConnexion
            // 
            this.textBox_mdpConnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mdpConnexion.ForeColor = System.Drawing.Color.Gray;
            this.textBox_mdpConnexion.Location = new System.Drawing.Point(92, 222);
            this.textBox_mdpConnexion.Name = "textBox_mdpConnexion";
            this.textBox_mdpConnexion.PasswordChar = '*';
            this.textBox_mdpConnexion.Size = new System.Drawing.Size(157, 20);
            this.textBox_mdpConnexion.TabIndex = 2;
            this.textBox_mdpConnexion.Text = "Mot de passe";
            // 
            // button_connexion
            // 
            this.button_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connexion.Location = new System.Drawing.Point(92, 275);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(157, 23);
            this.button_connexion.TabIndex = 5;
            this.button_connexion.Text = "Se connecter";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::forma.Properties.Resources.NiagaraFalls;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-652, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_garbage
            // 
            this.textBox_garbage.Location = new System.Drawing.Point(735, 381);
            this.textBox_garbage.Name = "textBox_garbage";
            this.textBox_garbage.Size = new System.Drawing.Size(100, 20);
            this.textBox_garbage.TabIndex = 7;
            this.textBox_garbage.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(708, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(316, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(21, 22);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // form_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 444);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_garbage);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.textBox_mdpConnexion);
            this.Controls.Add(this.textBox_idConnexion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.form_connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_idConnexion;
        private System.Windows.Forms.TextBox textBox_mdpConnexion;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_garbage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_close;
    }
}

