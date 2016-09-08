namespace La_listes_et_leurs_propriétés
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
            this.AjoutListe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.ListBox();
            this.ListeListe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.index = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ItemsCountR = new System.Windows.Forms.TextBox();
            this.SelectedIndexR = new System.Windows.Forms.TextBox();
            this.TextR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AjoutListe
            // 
            this.AjoutListe.Location = new System.Drawing.Point(12, 60);
            this.AjoutListe.Name = "AjoutListe";
            this.AjoutListe.Size = new System.Drawing.Size(140, 23);
            this.AjoutListe.TabIndex = 0;
            this.AjoutListe.Text = "Ajout Liste";
            this.AjoutListe.UseVisualStyleBackColor = true;
            this.AjoutListe.Click += new System.EventHandler(this.AjoutListe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nouvel Elément";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Liste
            // 
            this.Liste.FormattingEnabled = true;
            this.Liste.Location = new System.Drawing.Point(12, 131);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(140, 95);
            this.Liste.TabIndex = 3;
            this.Liste.SelectedIndexChanged += new System.EventHandler(this.Liste_SelectedIndexChanged);
            // 
            // ListeListe
            // 
            this.ListeListe.AutoSize = true;
            this.ListeListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeListe.Location = new System.Drawing.Point(12, 115);
            this.ListeListe.Name = "ListeListe";
            this.ListeListe.Size = new System.Drawing.Size(61, 13);
            this.ListeListe.TabIndex = 4;
            this.ListeListe.Text = "ListeListe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Index Elément";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextR);
            this.groupBox1.Controls.Add(this.SelectedIndexR);
            this.groupBox1.Controls.Add(this.ItemsCountR);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(179, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proprétés";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(223, 25);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(41, 20);
            this.index.TabIndex = 7;
            this.index.TextChanged += new System.EventHandler(this.index_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sélectionner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Vider la Liste";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemsCountR
            // 
            this.ItemsCountR.Location = new System.Drawing.Point(89, 22);
            this.ItemsCountR.Name = "ItemsCountR";
            this.ItemsCountR.ReadOnly = true;
            this.ItemsCountR.Size = new System.Drawing.Size(39, 20);
            this.ItemsCountR.TabIndex = 0;
            // 
            // SelectedIndexR
            // 
            this.SelectedIndexR.Location = new System.Drawing.Point(89, 48);
            this.SelectedIndexR.Name = "SelectedIndexR";
            this.SelectedIndexR.ReadOnly = true;
            this.SelectedIndexR.Size = new System.Drawing.Size(39, 20);
            this.SelectedIndexR.TabIndex = 1;
            this.SelectedIndexR.TextChanged += new System.EventHandler(this.SelectedIndexR_TextChanged);
            // 
            // TextR
            // 
            this.TextR.Location = new System.Drawing.Point(89, 74);
            this.TextR.Name = "TextR";
            this.TextR.ReadOnly = true;
            this.TextR.Size = new System.Drawing.Size(102, 20);
            this.TextR.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Items.Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SelectedIndex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.index);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListeListe);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AjoutListe);
            this.Name = "Form1";
            this.Text = "Les listes et leur propriétés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AjoutListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Liste;
        private System.Windows.Forms.Label ListeListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextR;
        private System.Windows.Forms.TextBox SelectedIndexR;
        private System.Windows.Forms.TextBox ItemsCountR;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

