using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarForm
{
    public partial class IslemlerForm : Form
    {
        public IslemlerForm()
        {
            InitializeComponent();
        }

        private void yeniAracEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aracEkleForm1.Show();
            aracGuncelleSilForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
            rezervasyonForm1.Hide();
        }

        private void aracSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aracGuncelleSilForm1.Show();
            aracEkleForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
            rezervasyonForm1.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgbtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void girisForm1_Load(object sender, EventArgs e)
        {

        }

        private void IslemlerForm_Load(object sender, EventArgs e)
        {
            girisForm1.Show();
            aracEkleForm1.Hide();
            aracGuncelleSilForm1.Hide();
            kiralamaForm1.Hide();
            rezervasyonForm1.Hide();
        }

        private void KiralamaIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kiralamaForm1.Show();
            girisForm1.Hide();
            aracGuncelleSilForm1.Hide();
            aracEkleForm1.Hide();
            rezervasyonForm1.Hide();
        }

        private void RezervelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezervasyonForm1.Show();
            aracEkleForm1.Hide();
            aracGuncelleSilForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
        }
    }
}
