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
            this.pannelRegistrazione = new System.Windows.Forms.Panel();
            this.bottoneInvioRegistrazione = new System.Windows.Forms.Button();
            this.contenitorePasswordInserita = new System.Windows.Forms.TextBox();
            this.scrittaIstruzioniPassword = new System.Windows.Forms.Label();
            this.scrittaRegistrazione = new System.Windows.Forms.Label();
            this.PannelloAltoDX = new System.Windows.Forms.Panel();
            this.PannelloBassoSX = new System.Windows.Forms.Panel();
            this.PannelloBassoDX = new System.Windows.Forms.Panel();
            this.panelLogIn.SuspendLayout();
            this.pannelRegistrazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogIn.Controls.Add(this.textBox1);
            this.panelLogIn.Controls.Add(this.srittaPassword);
            this.panelLogIn.Controls.Add(this.bottoneAccedi);
            this.panelLogIn.Controls.Add(this.ScrittaLogIn);
            this.panelLogIn.Location = new System.Drawing.Point(541, 219);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(318, 208);
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
            this.srittaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.srittaPassword.Location = new System.Drawing.Point(80, 75);
            this.srittaPassword.Name = "srittaPassword";
            this.srittaPassword.Size = new System.Drawing.Size(159, 24);
            this.srittaPassword.TabIndex = 2;
            this.srittaPassword.Text = "Inserire Password";
            this.srittaPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottoneAccedi
            // 
            this.bottoneAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bottoneAccedi.Location = new System.Drawing.Point(124, 149);
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
            this.ScrittaLogIn.Location = new System.Drawing.Point(118, 31);
            this.ScrittaLogIn.Name = "ScrittaLogIn";
            this.ScrittaLogIn.Size = new System.Drawing.Size(82, 31);
            this.ScrittaLogIn.TabIndex = 0;
            this.ScrittaLogIn.Text = "LogIn";
            // 
            // PannelloAltoSX
            // 
            this.PannelloAltoSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PannelloAltoSX.Location = new System.Drawing.Point(10, 11);
            this.PannelloAltoSX.Name = "PannelloAltoSX";
            this.PannelloAltoSX.Size = new System.Drawing.Size(502, 338);
            this.PannelloAltoSX.TabIndex = 1;
            // 
            // pannelRegistrazione
            // 
            this.pannelRegistrazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pannelRegistrazione.Controls.Add(this.bottoneInvioRegistrazione);
            this.pannelRegistrazione.Controls.Add(this.contenitorePasswordInserita);
            this.pannelRegistrazione.Controls.Add(this.scrittaIstruzioniPassword);
            this.pannelRegistrazione.Controls.Add(this.scrittaRegistrazione);
            this.pannelRegistrazione.Location = new System.Drawing.Point(541, 26);
            this.pannelRegistrazione.Margin = new System.Windows.Forms.Padding(2);
            this.pannelRegistrazione.Name = "pannelRegistrazione";
            this.pannelRegistrazione.Size = new System.Drawing.Size(337, 188);
            this.pannelRegistrazione.TabIndex = 4;
            // 
            // bottoneInvioRegistrazione
            // 
            this.bottoneInvioRegistrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bottoneInvioRegistrazione.Location = new System.Drawing.Point(116, 151);
            this.bottoneInvioRegistrazione.Margin = new System.Windows.Forms.Padding(2);
            this.bottoneInvioRegistrazione.Name = "bottoneInvioRegistrazione";
            this.bottoneInvioRegistrazione.Size = new System.Drawing.Size(94, 32);
            this.bottoneInvioRegistrazione.TabIndex = 3;
            this.bottoneInvioRegistrazione.Text = "Registrati";
            this.bottoneInvioRegistrazione.UseVisualStyleBackColor = true;
            this.bottoneInvioRegistrazione.Click += new System.EventHandler(this.BottoneInvioRegistrazione_Click);
            // 
            // contenitorePasswordInserita
            // 
            this.contenitorePasswordInserita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contenitorePasswordInserita.Location = new System.Drawing.Point(25, 109);
            this.contenitorePasswordInserita.Margin = new System.Windows.Forms.Padding(2);
            this.contenitorePasswordInserita.Name = "contenitorePasswordInserita";
            this.contenitorePasswordInserita.Size = new System.Drawing.Size(284, 26);
            this.contenitorePasswordInserita.TabIndex = 2;
            // 
            // scrittaIstruzioniPassword
            // 
            this.scrittaIstruzioniPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.scrittaIstruzioniPassword.Location = new System.Drawing.Point(15, 53);
            this.scrittaIstruzioniPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scrittaIstruzioniPassword.Name = "scrittaIstruzioniPassword";
            this.scrittaIstruzioniPassword.Size = new System.Drawing.Size(294, 45);
            this.scrittaIstruzioniPassword.TabIndex = 1;
            this.scrittaIstruzioniPassword.Text = "Inserire una password tra gli 8 e i 16 caratteri";
            this.scrittaIstruzioniPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // scrittaRegistrazione
            // 
            this.scrittaRegistrazione.AutoSize = true;
            this.scrittaRegistrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scrittaRegistrazione.Location = new System.Drawing.Point(85, 17);
            this.scrittaRegistrazione.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scrittaRegistrazione.Name = "scrittaRegistrazione";
            this.scrittaRegistrazione.Size = new System.Drawing.Size(151, 26);
            this.scrittaRegistrazione.TabIndex = 0;
            this.scrittaRegistrazione.Text = "Registrazione ";
            // 
            // PannelloAltoDX
            // 
            this.PannelloAltoDX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PannelloAltoDX.Location = new System.Drawing.Point(906, 12);
            this.PannelloAltoDX.Name = "PannelloAltoDX";
            this.PannelloAltoDX.Size = new System.Drawing.Size(349, 330);
            this.PannelloAltoDX.TabIndex = 2;
            // 
            // PannelloBassoSX
            // 
            this.PannelloBassoSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PannelloBassoSX.Location = new System.Drawing.Point(10, 348);
            this.PannelloBassoSX.Name = "PannelloBassoSX";
            this.PannelloBassoSX.Size = new System.Drawing.Size(622, 323);
            this.PannelloBassoSX.TabIndex = 3;
            // 
            // PannelloBassoDX
            // 
            this.PannelloBassoDX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PannelloBassoDX.Location = new System.Drawing.Point(637, 348);
            this.PannelloBassoDX.Name = "PannelloBassoDX";
            this.PannelloBassoDX.Size = new System.Drawing.Size(618, 323);
            this.PannelloBassoDX.TabIndex = 4;
            // 
            // Tasse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pannelRegistrazione);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.PannelloAltoSX);
            this.Controls.Add(this.PannelloAltoDX);
            this.Controls.Add(this.PannelloBassoSX);
            this.Controls.Add(this.PannelloBassoDX);
            this.Name = "Tasse1";
            this.Text = "Gestione Riscossione Tasse";
            this.Load += new System.EventHandler(this.Tasse1_Load);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.pannelRegistrazione.ResumeLayout(false);
            this.pannelRegistrazione.PerformLayout();
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
        private System.Windows.Forms.Panel pannelRegistrazione;
        private System.Windows.Forms.Button bottoneInvioRegistrazione;
        private System.Windows.Forms.TextBox contenitorePasswordInserita;
        private System.Windows.Forms.Label scrittaIstruzioniPassword;
        private System.Windows.Forms.Label scrittaRegistrazione;
    }
}

