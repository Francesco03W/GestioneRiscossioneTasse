namespace sceriffo0
{
    partial class Tasse1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasse1));
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.bottoneAccedi = new System.Windows.Forms.Button();
            this.ScrittaLogIn = new System.Windows.Forms.Label();
            this.srittaPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.textBox1);
            this.panelLogIn.Controls.Add(this.srittaPassword);
            this.panelLogIn.Controls.Add(this.bottoneAccedi);
            this.panelLogIn.Controls.Add(this.ScrittaLogIn);
            this.panelLogIn.Location = new System.Drawing.Point(496, 12);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(330, 391);
            this.panelLogIn.TabIndex = 0;
            // 
            // bottoneAccedi
            // 
            this.bottoneAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bottoneAccedi.Location = new System.Drawing.Point(120, 156);
            this.bottoneAccedi.Name = "bottoneAccedi";
            this.bottoneAccedi.Size = new System.Drawing.Size(76, 27);
            this.bottoneAccedi.TabIndex = 1;
            this.bottoneAccedi.Text = "Accedi";
            this.bottoneAccedi.UseVisualStyleBackColor = true;
            this.bottoneAccedi.Click += new System.EventHandler(this.bottoneAccedi_Click);
            // 
            // ScrittaLogIn
            // 
            this.ScrittaLogIn.AutoSize = true;
            this.ScrittaLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ScrittaLogIn.Location = new System.Drawing.Point(114, 10);
            this.ScrittaLogIn.Name = "ScrittaLogIn";
            this.ScrittaLogIn.Size = new System.Drawing.Size(82, 31);
            this.ScrittaLogIn.TabIndex = 0;
            this.ScrittaLogIn.Text = "LogIn";
            // 
            // srittaPassword
            // 
            this.srittaPassword.AutoSize = true;
            this.srittaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.srittaPassword.Location = new System.Drawing.Point(81, 84);
            this.srittaPassword.Name = "srittaPassword";
            this.srittaPassword.Size = new System.Drawing.Size(159, 24);
            this.srittaPassword.TabIndex = 2;
            this.srittaPassword.Text = "Inserire Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Tasse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tasse1";
            this.Text = "Sceriffo ";
            this.Load += new System.EventHandler(this.Tasse1_Load);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Label ScrittaLogIn;
        private System.Windows.Forms.Button bottoneAccedi;
        private System.Windows.Forms.Label srittaPassword;
        private System.Windows.Forms.TextBox textBox1;
    }
}

