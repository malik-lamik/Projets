namespace Check_et_RadioButton
{
    partial class minuscule
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Choix = new System.Windows.Forms.GroupBox();
            this.couleurfond = new System.Windows.Forms.CheckBox();
            this.couleurcaractere = new System.Windows.Forms.CheckBox();
            this.cassecasse = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fond = new System.Windows.Forms.GroupBox();
            this.caractere = new System.Windows.Forms.GroupBox();
            this.casse = new System.Windows.Forms.GroupBox();
            this.rougef = new System.Windows.Forms.RadioButton();
            this.vertf = new System.Windows.Forms.RadioButton();
            this.bleuf = new System.Windows.Forms.RadioButton();
            this.noirc = new System.Windows.Forms.RadioButton();
            this.blancc = new System.Windows.Forms.RadioButton();
            this.rougec = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.majuscule = new System.Windows.Forms.RadioButton();
            this.Choix.SuspendLayout();
            this.fond.SuspendLayout();
            this.caractere.SuspendLayout();
            this.casse.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tapez votre texte";
            // 
            // Choix
            // 
            this.Choix.Controls.Add(this.cassecasse);
            this.Choix.Controls.Add(this.couleurcaractere);
            this.Choix.Controls.Add(this.couleurfond);
            this.Choix.Enabled = false;
            this.Choix.Location = new System.Drawing.Point(371, 27);
            this.Choix.Name = "Choix";
            this.Choix.Size = new System.Drawing.Size(200, 121);
            this.Choix.TabIndex = 2;
            this.Choix.TabStop = false;
            this.Choix.Text = "Choix";
            this.Choix.Enter += new System.EventHandler(this.Choix_Enter);
            // 
            // couleurfond
            // 
            this.couleurfond.AutoSize = true;
            this.couleurfond.Location = new System.Drawing.Point(7, 20);
            this.couleurfond.Name = "couleurfond";
            this.couleurfond.Size = new System.Drawing.Size(101, 17);
            this.couleurfond.TabIndex = 0;
            this.couleurfond.Text = "Couleur du fond";
            this.couleurfond.UseVisualStyleBackColor = true;
            this.couleurfond.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // couleurcaractere
            // 
            this.couleurcaractere.AutoSize = true;
            this.couleurcaractere.Location = new System.Drawing.Point(6, 55);
            this.couleurcaractere.Name = "couleurcaractere";
            this.couleurcaractere.Size = new System.Drawing.Size(135, 17);
            this.couleurcaractere.TabIndex = 1;
            this.couleurcaractere.Text = "Couleur des caractères";
            this.couleurcaractere.UseVisualStyleBackColor = true;
            this.couleurcaractere.CheckedChanged += new System.EventHandler(this.couleurcaractere_CheckedChanged);
            // 
            // cassecasse
            // 
            this.cassecasse.AutoSize = true;
            this.cassecasse.Location = new System.Drawing.Point(7, 90);
            this.cassecasse.Name = "cassecasse";
            this.cassecasse.Size = new System.Drawing.Size(55, 17);
            this.cassecasse.TabIndex = 2;
            this.cassecasse.Text = "Casse";
            this.cassecasse.UseVisualStyleBackColor = true;
            this.cassecasse.CheckedChanged += new System.EventHandler(this.cassecasse_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // fond
            // 
            this.fond.Controls.Add(this.bleuf);
            this.fond.Controls.Add(this.vertf);
            this.fond.Controls.Add(this.rougef);
            this.fond.Location = new System.Drawing.Point(27, 190);
            this.fond.Name = "fond";
            this.fond.Size = new System.Drawing.Size(105, 123);
            this.fond.TabIndex = 4;
            this.fond.TabStop = false;
            this.fond.Text = "Fond";
            this.fond.Visible = false;
            this.fond.Enter += new System.EventHandler(this.fond_Enter);
            // 
            // caractere
            // 
            this.caractere.Controls.Add(this.noirc);
            this.caractere.Controls.Add(this.blancc);
            this.caractere.Controls.Add(this.rougec);
            this.caractere.Location = new System.Drawing.Point(138, 190);
            this.caractere.Name = "caractere";
            this.caractere.Size = new System.Drawing.Size(108, 123);
            this.caractere.TabIndex = 5;
            this.caractere.TabStop = false;
            this.caractere.Text = "Caractères";
            this.caractere.Visible = false;
            // 
            // casse
            // 
            this.casse.Controls.Add(this.majuscule);
            this.casse.Controls.Add(this.radioButton1);
            this.casse.Location = new System.Drawing.Point(252, 240);
            this.casse.Name = "casse";
            this.casse.Size = new System.Drawing.Size(105, 73);
            this.casse.TabIndex = 5;
            this.casse.TabStop = false;
            this.casse.Text = "Casse";
            this.casse.Visible = false;
            // 
            // rougef
            // 
            this.rougef.AutoSize = true;
            this.rougef.Location = new System.Drawing.Point(6, 29);
            this.rougef.Name = "rougef";
            this.rougef.Size = new System.Drawing.Size(57, 17);
            this.rougef.TabIndex = 0;
            this.rougef.TabStop = true;
            this.rougef.Text = "Rouge";
            this.rougef.UseVisualStyleBackColor = true;
            this.rougef.CheckedChanged += new System.EventHandler(this.rougef_CheckedChanged);
            // 
            // vertf
            // 
            this.vertf.AutoSize = true;
            this.vertf.Location = new System.Drawing.Point(6, 67);
            this.vertf.Name = "vertf";
            this.vertf.Size = new System.Drawing.Size(44, 17);
            this.vertf.TabIndex = 1;
            this.vertf.TabStop = true;
            this.vertf.Text = "Vert";
            this.vertf.UseVisualStyleBackColor = true;
            this.vertf.CheckedChanged += new System.EventHandler(this.vertf_CheckedChanged);
            // 
            // bleuf
            // 
            this.bleuf.AutoSize = true;
            this.bleuf.Location = new System.Drawing.Point(6, 101);
            this.bleuf.Name = "bleuf";
            this.bleuf.Size = new System.Drawing.Size(46, 17);
            this.bleuf.TabIndex = 2;
            this.bleuf.TabStop = true;
            this.bleuf.Text = "Bleu";
            this.bleuf.UseVisualStyleBackColor = true;
            this.bleuf.CheckedChanged += new System.EventHandler(this.bleuf_CheckedChanged);
            // 
            // noirc
            // 
            this.noirc.AutoSize = true;
            this.noirc.Location = new System.Drawing.Point(6, 101);
            this.noirc.Name = "noirc";
            this.noirc.Size = new System.Drawing.Size(44, 17);
            this.noirc.TabIndex = 5;
            this.noirc.Text = "Noir";
            this.noirc.UseVisualStyleBackColor = true;
            this.noirc.CheckedChanged += new System.EventHandler(this.noirc_CheckedChanged);
            // 
            // blancc
            // 
            this.blancc.AutoSize = true;
            this.blancc.Location = new System.Drawing.Point(6, 67);
            this.blancc.Name = "blancc";
            this.blancc.Size = new System.Drawing.Size(52, 17);
            this.blancc.TabIndex = 4;
            this.blancc.Text = "Blanc";
            this.blancc.UseVisualStyleBackColor = true;
            this.blancc.CheckedChanged += new System.EventHandler(this.blancc_CheckedChanged);
            // 
            // rougec
            // 
            this.rougec.AutoSize = true;
            this.rougec.Location = new System.Drawing.Point(6, 29);
            this.rougec.Name = "rougec";
            this.rougec.Size = new System.Drawing.Size(57, 17);
            this.rougec.TabIndex = 3;
            this.rougec.Text = "Rouge";
            this.rougec.UseVisualStyleBackColor = true;
            this.rougec.CheckedChanged += new System.EventHandler(this.rougec_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Minuscules";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // majuscule
            // 
            this.majuscule.AutoSize = true;
            this.majuscule.Location = new System.Drawing.Point(6, 42);
            this.majuscule.Name = "majuscule";
            this.majuscule.Size = new System.Drawing.Size(78, 17);
            this.majuscule.TabIndex = 1;
            this.majuscule.TabStop = true;
            this.majuscule.Text = "Majuscules";
            this.majuscule.UseVisualStyleBackColor = true;
            this.majuscule.CheckedChanged += new System.EventHandler(this.majuscule_CheckedChanged);
            // 
            // minuscule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 325);
            this.Controls.Add(this.casse);
            this.Controls.Add(this.caractere);
            this.Controls.Add(this.fond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Choix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.Name = "minuscule";
            this.Text = "CheckBox et RadioButton";
            this.Choix.ResumeLayout(false);
            this.Choix.PerformLayout();
            this.fond.ResumeLayout(false);
            this.fond.PerformLayout();
            this.caractere.ResumeLayout(false);
            this.caractere.PerformLayout();
            this.casse.ResumeLayout(false);
            this.casse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Choix;
        private System.Windows.Forms.CheckBox cassecasse;
        private System.Windows.Forms.CheckBox couleurcaractere;
        private System.Windows.Forms.CheckBox couleurfond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox fond;
        private System.Windows.Forms.RadioButton bleuf;
        private System.Windows.Forms.RadioButton vertf;
        private System.Windows.Forms.RadioButton rougef;
        private System.Windows.Forms.GroupBox caractere;
        private System.Windows.Forms.RadioButton noirc;
        private System.Windows.Forms.RadioButton blancc;
        private System.Windows.Forms.RadioButton rougec;
        private System.Windows.Forms.GroupBox casse;
        private System.Windows.Forms.RadioButton majuscule;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

