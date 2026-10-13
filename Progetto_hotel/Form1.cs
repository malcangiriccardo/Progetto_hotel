using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int camera, stagione, giorni;
        float sconto;

        private void btn_prenota_Click(object sender, EventArgs e)
        {
            float prezzo;

            giorni = Convert.ToInt32(txt_giorni.Text);

            if (giorni <= 2 && giorni > 0)
            {
                sconto = 0;

            }
            else if (giorni >= 3 && giorni <= 7)
            {
                sconto = 0.25f;
            }
            else if (giorni > 7)
            {
                sconto = 0.35f;
            }

            prezzo = ((15 + camera + stagione) * giorni) * (1 - sconto);

            lbl_prezzo.Text = "Il prezzo della camera è: " + prezzo.ToString() + "€";
        }

        private void cmb_stagione_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_stagione.SelectedIndex)
            {
                case 0:
                    stagione = 0;
                    break;
                case 1:
                    stagione = 5;
                    break;
                case 2:
                    stagione = 10;
                    break;
            }
        }

        private void cmb_stanza_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_stanza.SelectedIndex)
            {
                case 0:
                    camera = 0;
                    break;
                case 1:
                    camera = 15;
                    break;
                case 2:
                    camera = 30;
                    break;
            }
        }
    }
}
