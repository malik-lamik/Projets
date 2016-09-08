namespace additionneur
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.un = new System.Windows.Forms.Button();
            this.deux = new System.Windows.Forms.Button();
            this.trois = new System.Windows.Forms.Button();
            this.quatre = new System.Windows.Forms.Button();
            this.cinq = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sept = new System.Windows.Forms.Button();
            this.huit = new System.Windows.Forms.Button();
            this.neuf = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            this.Calculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(469, 149);
            this.textBox1.TabIndex = 0;
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 181);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(60, 53);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(105, 181);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(60, 53);
            this.un.TabIndex = 2;
            this.un.Text = "1";
            this.un.UseVisualStyleBackColor = true;
            this.un.Click += new System.EventHandler(this.un_Click);
            // 
            // deux
            // 
            this.deux.Location = new System.Drawing.Point(195, 181);
            this.deux.Name = "deux";
            this.deux.Size = new System.Drawing.Size(60, 53);
            this.deux.TabIndex = 3;
            this.deux.Text = "2";
            this.deux.UseVisualStyleBackColor = true;
            this.deux.Click += new System.EventHandler(this.deux_Click);
            // 
            // trois
            // 
            this.trois.Location = new System.Drawing.Point(293, 181);
            this.trois.Name = "trois";
            this.trois.Size = new System.Drawing.Size(60, 53);
            this.trois.TabIndex = 4;
            this.trois.Text = "3";
            this.trois.UseVisualStyleBackColor = true;
            this.trois.Click += new System.EventHandler(this.trois_Click);
            // 
            // quatre
            // 
            this.quatre.Location = new System.Drawing.Point(392, 181);
            this.quatre.Name = "quatre";
            this.quatre.Size = new System.Drawing.Size(60, 53);
            this.quatre.TabIndex = 5;
            this.quatre.Text = "4";
            this.quatre.UseVisualStyleBackColor = true;
            this.quatre.Click += new System.EventHandler(this.quatre_Click);
            // 
            // cinq
            // 
            this.cinq.Location = new System.Drawing.Point(12, 256);
            this.cinq.Name = "cinq";
            this.cinq.Size = new System.Drawing.Size(60, 53);
            this.cinq.TabIndex = 6;
            this.cinq.Text = "5";
            this.cinq.UseVisualStyleBackColor = true;
            this.cinq.Click += new System.EventHandler(this.cinq_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(105, 256);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 53);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // sept
            // 
            this.sept.Location = new System.Drawing.Point(195, 256);
            this.sept.Name = "sept";
            this.sept.Size = new System.Drawing.Size(60, 53);
            this.sept.TabIndex = 8;
            this.sept.Text = "7";
            this.sept.UseVisualStyleBackColor = true;
            this.sept.Click += new System.EventHandler(this.button8_Click);
            // 
            // huit
            // 
            this.huit.Location = new System.Drawing.Point(293, 256);
            this.huit.Name = "huit";
            this.huit.Size = new System.Drawing.Size(60, 53);
            this.huit.TabIndex = 9;
            this.huit.Text = "8";
            this.huit.UseVisualStyleBackColor = true;
            this.huit.Click += new System.EventHandler(this.huit_Click);
            // 
            // neuf
            // 
            this.neuf.Location = new System.Drawing.Point(392, 256);
            this.neuf.Name = "neuf";
            this.neuf.Size = new System.Drawing.Size(60, 53);
            this.neuf.TabIndex = 10;
            this.neuf.Text = "9";
            this.neuf.UseVisualStyleBackColor = true;
            this.neuf.Click += new System.EventHandler(this.neuf_Click);
            // 
            // vider
            // 
            this.vider.Location = new System.Drawing.Point(58, 338);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(75, 23);
            this.vider.TabIndex = 11;
            this.vider.Text = "Vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // Calculer
            // 
            this.Calculer.CausesValidation = false;
            this.Calculer.Location = new System.Drawing.Point(314, 338);
            this.Calculer.Name = "Calculer";
            this.Calculer.Size = new System.Drawing.Size(75, 23);
            this.Calculer.TabIndex = 12;
            this.Calculer.Text = "Calculer";
            this.Calculer.UseVisualStyleBackColor = true;
            this.Calculer.Click += new System.EventHandler(this.Calculer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 376);
            this.Controls.Add(this.Calculer);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.neuf);
            this.Controls.Add(this.huit);
            this.Controls.Add(this.sept);
            this.Controls.Add(this.six);
            this.Controls.Add(this.cinq);
            this.Controls.Add(this.quatre);
            this.Controls.Add(this.trois);
            this.Controls.Add(this.deux);
            this.Controls.Add(this.un);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Additionneur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button un;
        private System.Windows.Forms.Button deux;
        private System.Windows.Forms.Button trois;
        private System.Windows.Forms.Button quatre;
        private System.Windows.Forms.Button cinq;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button sept;
        private System.Windows.Forms.Button huit;
        private System.Windows.Forms.Button neuf;
        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.Button Calculer;
    }
}

