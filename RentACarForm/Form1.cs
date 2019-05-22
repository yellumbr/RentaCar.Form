using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Concretes;

namespace RentACarForm
{
    public partial class Form1 : Form
    {
        public static Yonetici yonetici;
        IslemlerForm frm = new IslemlerForm();
        public Form1()
        {
            
           
            yonetici = new Yonetici();
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
        }
    }
}
