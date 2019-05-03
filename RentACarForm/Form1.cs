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
            try
            {
                using (var yoneticiServis = new YoneticiWebServis.YoneticiWebServisSoapClient())
                {

                    foreach (var item in yoneticiServis.YoneticiHepsiniSec())
                    {
                        if (item.TcKimlik == txtGirisKimlikNo.Text && item.Sifre == txtGirisSifre.Text)
                        {
                            Yonetici yoneticiGecici = new Yonetici()
                            {
                                Ad = item.Ad,
                                Soyad = item.Soyad,
                                TcKimlik = item.TcKimlik,
                                Telefon = item.Telefon,
                                Email = item.Email,
                                DogumTarihi = item.DogumTarihi.Date,
                                Adres = item.Adres,
                                Sifre = item.Sifre,
                                SirketId = item.SirketId,
                                YoneticiId = item.YoneticiId
                            };
                            yonetici = yoneticiGecici;
                            MessageBox.Show("Giriş yapıldı");
                            this.Hide();
                            frm.Show();

                        }
                        else
                            MessageBox.Show("Hatalı kullanıcı adı/şifre"+ txtGirisKimlikNo.Text+" "+ txtGirisSifre.Text);

                    }
                }
            }

            catch
            {

            }
        }
    }
}
