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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chk_parcheggio = new System.Windows.Forms.CheckBox();
            this.cmb_stagione = new System.Windows.Forms.ComboBox();
            this.cmb_stanza = new System.Windows.Forms.ComboBox();
            this.btn_prenota = new System.Windows.Forms.Button();
            this.lbl_prezzob = new System.Windows.Forms.Label();
            this.lbl_sconto = new System.Windows.Forms.Label();
            this.lbl_prezzo = new System.Windows.Forms.Label();
            this.lbl_giorni = new System.Windows.Forms.Label();
            this.lbl_stagione = new System.Windows.Forms.Label();
            this.lbl_stanza = new System.Windows.Forms.Label();
            this.nud_giorni = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.grb_info = new System.Windows.Forms.GroupBox();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giorni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_parcheggio
            // 
            this.chk_parcheggio.AutoSize = true;
            this.chk_parcheggio.Location = new System.Drawing.Point(469, 351);
            this.chk_parcheggio.Name = "chk_parcheggio";
            this.chk_parcheggio.Size = new System.Drawing.Size(179, 17);
            this.chk_parcheggio.TabIndex = 0;
            this.chk_parcheggio.Text = "Parcheggio privato (5€ al giorno)";
            this.chk_parcheggio.UseVisualStyleBackColor = true;
            this.chk_parcheggio.CheckedChanged += new System.EventHandler(this.chk_parcheggio_CheckedChanged);
            // 
            // cmb_stagione
            // 
            this.cmb_stagione.FormattingEnabled = true;
            this.cmb_stagione.Items.AddRange(new object[] {
            "Bassa stagione+0€",
            "Media stagione+5€",
            "Alta stagione+10€"});
            this.cmb_stagione.Location = new System.Drawing.Point(498, 147);
            this.cmb_stagione.Name = "cmb_stagione";
            this.cmb_stagione.Size = new System.Drawing.Size(121, 21);
            this.cmb_stagione.TabIndex = 1;
            this.cmb_stagione.Text = "Bassa stagione+0€";
            this.cmb_stagione.SelectedIndexChanged += new System.EventHandler(this.cmb_stagione_SelectedIndexChanged);
            // 
            // cmb_stanza
            // 
            this.cmb_stanza.FormattingEnabled = true;
            this.cmb_stanza.Items.AddRange(new object[] {
            "Base +0€",
            "Media+15€",
            "Alta+30€"});
            this.cmb_stanza.Location = new System.Drawing.Point(498, 196);
            this.cmb_stanza.Name = "cmb_stanza";
            this.cmb_stanza.Size = new System.Drawing.Size(121, 21);
            this.cmb_stanza.TabIndex = 2;
            this.cmb_stanza.Text = "Base +0€";
            this.cmb_stanza.SelectedIndexChanged += new System.EventHandler(this.cmb_stanza_SelectedIndexChanged);
            // 
            // btn_prenota
            // 
            this.btn_prenota.Location = new System.Drawing.Point(521, 374);
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
            this.lbl_prezzob.Location = new System.Drawing.Point(515, 92);
            this.lbl_prezzob.Name = "lbl_prezzob";
            this.lbl_prezzob.Size = new System.Drawing.Size(86, 13);
            this.lbl_prezzob.TabIndex = 4;
            this.lbl_prezzob.Text = "Prezzo base 15€";
            // 
            // lbl_sconto
            // 
            this.lbl_sconto.AutoSize = true;
            this.lbl_sconto.Location = new System.Drawing.Point(465, 272);
            this.lbl_sconto.Name = "lbl_sconto";
            this.lbl_sconto.Size = new System.Drawing.Size(187, 52);
            this.lbl_sconto.TabIndex = 5;
            this.lbl_sconto.Text = "Sconto: (Non si applica al parcheggio)\r\n2 giorni o meno 0%\r\n3-7 giorni 25%\r\n8+ gi" +
    "orni 35%";
            // 
            // lbl_prezzo
            // 
            this.lbl_prezzo.AutoSize = true;
            this.lbl_prezzo.Location = new System.Drawing.Point(495, 400);
            this.lbl_prezzo.Name = "lbl_prezzo";
            this.lbl_prezzo.Size = new System.Drawing.Size(42, 13);
            this.lbl_prezzo.TabIndex = 6;
            this.lbl_prezzo.Text = "Prezzo:";
            // 
            // lbl_giorni
            // 
            this.lbl_giorni.AutoSize = true;
            this.lbl_giorni.Location = new System.Drawing.Point(477, 233);
            this.lbl_giorni.Name = "lbl_giorni";
            this.lbl_giorni.Size = new System.Drawing.Size(163, 13);
            this.lbl_giorni.TabIndex = 7;
            this.lbl_giorni.Text = "Per quanti giorni vuoi pernottare?";
            // 
            // lbl_stagione
            // 
            this.lbl_stagione.AutoSize = true;
            this.lbl_stagione.Location = new System.Drawing.Point(534, 131);
            this.lbl_stagione.Name = "lbl_stagione";
            this.lbl_stagione.Size = new System.Drawing.Size(49, 13);
            this.lbl_stagione.TabIndex = 9;
            this.lbl_stagione.Text = "Stagione";
            // 
            // lbl_stanza
            // 
            this.lbl_stanza.AutoSize = true;
            this.lbl_stanza.Location = new System.Drawing.Point(527, 180);
            this.lbl_stanza.Name = "lbl_stanza";
            this.lbl_stanza.Size = new System.Drawing.Size(62, 13);
            this.lbl_stanza.TabIndex = 10;
            this.lbl_stanza.Text = "Tipo stanza";
            // 
            // nud_giorni
            // 
            this.nud_giorni.Location = new System.Drawing.Point(498, 249);
            this.nud_giorni.Name = "nud_giorni";
            this.nud_giorni.Size = new System.Drawing.Size(120, 20);
            this.nud_giorni.TabIndex = 11;
            this.nud_giorni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(51, 47);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(371, 58);
            this.lbl_nome.TabIndex = 13;
            this.lbl_nome.Text = "Hotel GianFranco";
            // 
            // btn_info
            // 
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.Location = new System.Drawing.Point(600, 12);
            this.btn_info.Name = "btn_info";
            this.btn_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_info.Size = new System.Drawing.Size(41, 39);
            this.btn_info.TabIndex = 14;
            this.btn_info.Text = "?";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // grb_info
            // 
            this.grb_info.BackColor = System.Drawing.Color.White;
            this.grb_info.Controls.Add(this.lbl_info);
            this.grb_info.Location = new System.Drawing.Point(31, 153);
            this.grb_info.Name = "grb_info";
            this.grb_info.Size = new System.Drawing.Size(379, 260);
            this.grb_info.TabIndex = 15;
            this.grb_info.TabStop = false;
            this.grb_info.Visible = false;
            // 
            // lbl_info
            // 
            this.lbl_info.Location = new System.Drawing.Point(-3, 13);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(382, 244);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = resources.GetString("lbl_info.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(653, 439);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.nud_giorni);
            this.Controls.Add(this.lbl_stanza);
            this.Controls.Add(this.lbl_stagione);
            this.Controls.Add(this.lbl_giorni);
            this.Controls.Add(this.lbl_prezzo);
            this.Controls.Add(this.lbl_sconto);
            this.Controls.Add(this.lbl_prezzob);
            this.Controls.Add(this.btn_prenota);
            this.Controls.Add(this.cmb_stanza);
            this.Controls.Add(this.cmb_stagione);
            this.Controls.Add(this.chk_parcheggio);
            this.Controls.Add(this.grb_info);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_giorni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grb_info.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_prezzo;
        private System.Windows.Forms.Label lbl_giorni;
        private System.Windows.Forms.Label lbl_stagione;
        private System.Windows.Forms.Label lbl_stanza;
        private System.Windows.Forms.NumericUpDown nud_giorni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.GroupBox grb_info;
        private System.Windows.Forms.Label lbl_info;
    }
}

