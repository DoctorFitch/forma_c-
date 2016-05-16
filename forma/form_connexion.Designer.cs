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
            this.label_espaceConnexion = new System.Windows.Forms.Label();
            this.textBox_idConnexion = new System.Windows.Forms.TextBox();
            this.textBox_mdpConnexion = new System.Windows.Forms.TextBox();
            this.label_identifiantConnexion = new System.Windows.Forms.Label();
            this.label_motDePasseConnexion = new System.Windows.Forms.Label();
            this.button_connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_espaceConnexion
            // 
            this.label_espaceConnexion.AutoSize = true;
            this.label_espaceConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_espaceConnexion.Location = new System.Drawing.Point(182, 38);
            this.label_espaceConnexion.Name = "label_espaceConnexion";
            this.label_espaceConnexion.Size = new System.Drawing.Size(161, 20);
            this.label_espaceConnexion.TabIndex = 0;
            this.label_espaceConnexion.Text = "Espace de connexion";
            // 
            // textBox_idConnexion
            // 
            this.textBox_idConnexion.Location = new System.Drawing.Point(183, 120);
            this.textBox_idConnexion.Name = "textBox_idConnexion";
            this.textBox_idConnexion.Size = new System.Drawing.Size(157, 20);
            this.textBox_idConnexion.TabIndex = 1;
            // 
            // textBox_mdpConnexion
            // 
            this.textBox_mdpConnexion.Location = new System.Drawing.Point(183, 185);
            this.textBox_mdpConnexion.Name = "textBox_mdpConnexion";
            this.textBox_mdpConnexion.Size = new System.Drawing.Size(157, 20);
            this.textBox_mdpConnexion.TabIndex = 2;
            // 
            // label_identifiantConnexion
            // 
            this.label_identifiantConnexion.AutoSize = true;
            this.label_identifiantConnexion.Location = new System.Drawing.Point(183, 101);
            this.label_identifiantConnexion.Name = "label_identifiantConnexion";
            this.label_identifiantConnexion.Size = new System.Drawing.Size(59, 13);
            this.label_identifiantConnexion.TabIndex = 3;
            this.label_identifiantConnexion.Text = "Identifiant :";
            // 
            // label_motDePasseConnexion
            // 
            this.label_motDePasseConnexion.AutoSize = true;
            this.label_motDePasseConnexion.Location = new System.Drawing.Point(183, 166);
            this.label_motDePasseConnexion.Name = "label_motDePasseConnexion";
            this.label_motDePasseConnexion.Size = new System.Drawing.Size(77, 13);
            this.label_motDePasseConnexion.TabIndex = 4;
            this.label_motDePasseConnexion.Text = "Mot de passe :";
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(212, 235);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(99, 23);
            this.button_connexion.TabIndex = 5;
            this.button_connexion.Text = "Se connecter";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // form_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 337);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.label_motDePasseConnexion);
            this.Controls.Add(this.label_identifiantConnexion);
            this.Controls.Add(this.textBox_mdpConnexion);
            this.Controls.Add(this.textBox_idConnexion);
            this.Controls.Add(this.label_espaceConnexion);
            this.Name = "form_connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_espaceConnexion;
        private System.Windows.Forms.TextBox textBox_idConnexion;
        private System.Windows.Forms.TextBox textBox_mdpConnexion;
        private System.Windows.Forms.Label label_identifiantConnexion;
        private System.Windows.Forms.Label label_motDePasseConnexion;
        private System.Windows.Forms.Button button_connexion;
    }
}

