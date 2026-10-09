namespace Progetto_hotel
{
    partial class Form1
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
            this.chk_parcheggio = new System.Windows.Forms.CheckBox();
            this.cmb_stagione = new System.Windows.Forms.ComboBox();
            this.cmb_stanza = new System.Windows.Forms.ComboBox();
            this.btn_prenota = new System.Windows.Forms.Button();
            this.lbl_prezzob = new System.Windows.Forms.Label();
            this.lbl_sconto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_parcheggio
            // 
            this.chk_parcheggio.AutoSize = true;
            this.chk_parcheggio.Location = new System.Drawing.Point(223, 178);
            this.chk_parcheggio.Name = "chk_parcheggio";
            this.chk_parcheggio.Size = new System.Drawing.Size(179, 17);
            this.chk_parcheggio.TabIndex = 0;
            this.chk_parcheggio.Text = "Parcheggio privato (5€ al giorno)";
            this.chk_parcheggio.UseVisualStyleBackColor = true;
            // 
            // cmb_stagione
            // 
            this.cmb_stagione.FormattingEnabled = true;
            this.cmb_stagione.Items.AddRange(new object[] {
            "Bassa stagione+0€",
            "Media stagione+5€",
            "Alta stagione+10€"});
            this.cmb_stagione.Location = new System.Drawing.Point(314, 116);
            this.cmb_stagione.Name = "cmb_stagione";
            this.cmb_stagione.Size = new System.Drawing.Size(121, 21);
            this.cmb_stagione.TabIndex = 1;
            this.cmb_stagione.Text = "Stagione";
            // 
            // cmb_stanza
            // 
            this.cmb_stanza.FormattingEnabled = true;
            this.cmb_stanza.Items.AddRange(new object[] {
            "Base +0€",
            "Media+15€",
            "Alta+30€"});
            this.cmb_stanza.Location = new System.Drawing.Point(131, 116);
            this.cmb_stanza.Name = "cmb_stanza";
            this.cmb_stanza.Size = new System.Drawing.Size(121, 21);
            this.cmb_stanza.TabIndex = 2;
            this.cmb_stanza.Text = "Tipo stanza";
            // 
            // btn_prenota
            // 
            this.btn_prenota.Location = new System.Drawing.Point(252, 337);
            this.btn_prenota.Name = "btn_prenota";
            this.btn_prenota.Size = new System.Drawing.Size(75, 23);
            this.btn_prenota.TabIndex = 3;
            this.btn_prenota.Text = "Prenota";
            this.btn_prenota.UseVisualStyleBackColor = true;
            this.btn_prenota.Click += new System.EventHandler(this.btn_prenota_Click);
            // 
            // lbl_prezzob
            // 
            this.lbl_prezzob.AutoSize = true;
            this.lbl_prezzob.Location = new System.Drawing.Point(249, 39);
            this.lbl_prezzob.Name = "lbl_prezzob";
            this.lbl_prezzob.Size = new System.Drawing.Size(86, 13);
            this.lbl_prezzob.TabIndex = 4;
            this.lbl_prezzob.Text = "Prezzo base 15€";
            // 
            // lbl_sconto
            // 
            this.lbl_sconto.AutoSize = true;
            this.lbl_sconto.Location = new System.Drawing.Point(215, 213);
            this.lbl_sconto.Name = "lbl_sconto";
            this.lbl_sconto.Size = new System.Drawing.Size(187, 52);
            this.lbl_sconto.TabIndex = 5;
            this.lbl_sconto.Text = "Sconto: (Non si applica al parcheggio)\r\n2 giorni o meno 0%\r\n3-7 giorni 25%\r\n8+ gi" +
    "orni 35%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.lbl_sconto);
            this.Controls.Add(this.lbl_prezzob);
            this.Controls.Add(this.btn_prenota);
            this.Controls.Add(this.cmb_stanza);
            this.Controls.Add(this.cmb_stagione);
            this.Controls.Add(this.chk_parcheggio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_parcheggio;
        private System.Windows.Forms.ComboBox cmb_stagione;
        private System.Windows.Forms.ComboBox cmb_stanza;
        private System.Windows.Forms.Button btn_prenota;
        private System.Windows.Forms.Label lbl_prezzob;
        private System.Windows.Forms.Label lbl_sconto;
    }
}

