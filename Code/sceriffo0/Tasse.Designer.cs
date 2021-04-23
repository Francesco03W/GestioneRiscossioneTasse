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
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.srittaPassword = new System.Windows.Forms.Label();
            this.bottoneAccedi = new System.Windows.Forms.Button();
            this.ScrittaLogIn = new System.Windows.Forms.Label();
            this.PannelloAltoSX = new System.Windows.Forms.Panel();
            this.PannelloAltoDX = new System.Windows.Forms.Panel();
            this.PannelloBassoSX = new System.Windows.Forms.Panel();
            this.PannelloBassoDX = new System.Windows.Forms.Panel();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogIn.Controls.Add(this.textBox1);
            this.panelLogIn.Controls.Add(this.srittaPassword);
            this.panelLogIn.Controls.Add(this.bottoneAccedi);
            this.panelLogIn.Controls.Add(this.ScrittaLogIn);
            this.panelLogIn.Location = new System.Drawing.Point(1200, 661);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(332, 206);
            this.panelLogIn.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 3;
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
            this.ScrittaLogIn.Location = new System.Drawing.Point(114, 31);
            this.ScrittaLogIn.Name = "ScrittaLogIn";
            this.ScrittaLogIn.Size = new System.Drawing.Size(82, 31);
            this.ScrittaLogIn.TabIndex = 0;
            this.ScrittaLogIn.Text = "LogIn";
            // 
            // PannelloAltoSX
            // 
            this.PannelloAltoSX.Location = new System.Drawing.Point(12, 12);
            this.PannelloAltoSX.Name = "PannelloAltoSX";
            this.PannelloAltoSX.Size = new System.Drawing.Size(586, 303);
            this.PannelloAltoSX.TabIndex = 1;
            // 
            // PannelloAltoDX
            // 
            this.PannelloAltoDX.Location = new System.Drawing.Point(617, 12);
            this.PannelloAltoDX.Name = "PannelloAltoDX";
            this.PannelloAltoDX.Size = new System.Drawing.Size(635, 303);
            this.PannelloAltoDX.TabIndex = 2;
            // 
            // PannelloBassoSX
            // 
            this.PannelloBassoSX.Location = new System.Drawing.Point(14, 334);
            this.PannelloBassoSX.Name = "PannelloBassoSX";
            this.PannelloBassoSX.Size = new System.Drawing.Size(584, 321);
            this.PannelloBassoSX.TabIndex = 3;
            // 
            // PannelloBassoDX
            // 
            this.PannelloBassoDX.Location = new System.Drawing.Point(617, 334);
            this.PannelloBassoDX.Name = "PannelloBassoDX";
            this.PannelloBassoDX.Size = new System.Drawing.Size(635, 321);
            this.PannelloBassoDX.TabIndex = 4;
            // 
            // Tasse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.PannelloBassoDX);
            this.Controls.Add(this.PannelloBassoSX);
            this.Controls.Add(this.PannelloAltoDX);
            this.Controls.Add(this.PannelloAltoSX);
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
        private System.Windows.Forms.Panel PannelloAltoSX;
        private System.Windows.Forms.Panel PannelloAltoDX;
        private System.Windows.Forms.Panel PannelloBassoSX;
        private System.Windows.Forms.Panel PannelloBassoDX;
    }
}

