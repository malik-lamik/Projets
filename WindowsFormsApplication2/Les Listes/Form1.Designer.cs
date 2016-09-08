namespace Les_Listes
{
    partial class Form1
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
            this.pays = new System.Windows.Forms.ComboBox();
            this.liste = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.aller = new System.Windows.Forms.Button();
            this.tousaller = new System.Windows.Forms.Button();
            this.retourtous = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pays
            // 
            this.pays.FormattingEnabled = true;
            this.pays.Items.AddRange(new object[] {
            "France",
            "Belgique",
            "Allemagne",
            "Japon",
            "Portugal",
            "Grèce",
            "Bulgarie",
            "Espagne"});
            this.pays.Location = new System.Drawing.Point(24, 45);
            this.pays.Name = "pays";
            this.pays.Size = new System.Drawing.Size(121, 21);
            this.pays.TabIndex = 0;
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(239, 45);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(120, 173);
            this.liste.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Descendre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Monter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aller
            // 
            this.aller.Location = new System.Drawing.Point(163, 45);
            this.aller.Name = "aller";
            this.aller.Size = new System.Drawing.Size(70, 35);
            this.aller.TabIndex = 4;
            this.aller.Text = ">";
            this.aller.UseVisualStyleBackColor = true;
            this.aller.Click += new System.EventHandler(this.aller_Click);
            // 
            // tousaller
            // 
            this.tousaller.Location = new System.Drawing.Point(163, 97);
            this.tousaller.Name = "tousaller";
            this.tousaller.Size = new System.Drawing.Size(70, 40);
            this.tousaller.TabIndex = 5;
            this.tousaller.Text = ">>";
            this.tousaller.UseVisualStyleBackColor = true;
            this.tousaller.Click += new System.EventHandler(this.tousaller_Click);
            // 
            // retourtous
            // 
            this.retourtous.Location = new System.Drawing.Point(163, 215);
            this.retourtous.Name = "retourtous";
            this.retourtous.Size = new System.Drawing.Size(70, 40);
            this.retourtous.TabIndex = 7;
            this.retourtous.Text = "<<";
            this.retourtous.UseVisualStyleBackColor = true;
            this.retourtous.Click += new System.EventHandler(this.retourtous_Click);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(163, 163);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(70, 35);
            this.retour.TabIndex = 6;
            this.retour.Text = "<";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 298);
            this.Controls.Add(this.retourtous);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.tousaller);
            this.Controls.Add(this.aller);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.pays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox pays;
        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button aller;
        private System.Windows.Forms.Button tousaller;
        private System.Windows.Forms.Button retourtous;
        private System.Windows.Forms.Button retour;
    }
}

