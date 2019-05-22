using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commons.Concretes;
using Models.Concretes;

namespace RentACarForm
{
    public partial class IslemlerForm : Form
    {
        public static ListViewItem listviewItem { get; set; }
        public static List<Arac> araclar { get; set; }
        public static List<Musteri> musteriler { get; set; }
        public static List<Sirket> sirketler { get; set; }
        public static List<Yonetici> yoneticiler { get; set; }
        public static List<Odeme> odemeler { get; set; }
        public IslemlerForm()
        {
            yoneticiler = new List<Yonetici>();
            odemeler = new List<Odeme>();
            sirketler = new List<Sirket>();
            araclar = new List<Arac>();
            musteriler = new List<Musteri>();
            InitializeComponent();
        }

        
        
        private void yeniAracEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aracEkleForm1.Show();
            aracGuncelleSilForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
            rezervasyonForm1.Hide();
            musteriIslemForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources._20920221;
            imgbtnMin.BackColor = Color.Goldenrod;
            imgbtnExit.BackColor = Color.Goldenrod;
        }

        private void aracSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            araclar.Clear();
            aracGuncelleSilForm1.Show();
            aracEkleForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
            rezervasyonForm1.Hide();
            musteriIslemForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.abstract_d_geometric_colorful_background_vector;
            imgbtnMin.BackColor = Color.Khaki;
            imgbtnExit.BackColor = Color.Khaki;

            
            aracGuncelleSilForm1.comboCek().Items.Clear();
            foreach (var item in araclar)
            {
                
                aracGuncelleSilForm1.comboCek().Items.Add(item.Plaka);
            }
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
            musteriIslemForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.mesh_1430108_1280;
            imgbtnMin.BackColor = Color.MediumVioletRed;
            imgbtnExit.BackColor = Color.MediumVioletRed;

            
            
            kiralamaForm1.comboCek().Items.Clear();
            foreach (var item in araclar)
            {
                if(!item.Kirada)
                    kiralamaForm1.comboCek().Items.Add(item.Plaka);
            }

            
            kiralamaForm1.comboCek1().Items.Clear();
           


        }

        private void KiralamaIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kiralamaForm1.Show();
            girisForm1.Hide();
            aracGuncelleSilForm1.Hide();
            aracEkleForm1.Hide();
            rezervasyonForm1.Hide();
            musteriIslemForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.geometric;
            imgbtnMin.BackColor = Color.DarkOrange;
            imgbtnExit.BackColor = Color.DarkOrange;

            
        }

        private void RezervelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            rezervasyonForm1.Show();
            aracEkleForm1.Hide();
            aracGuncelleSilForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
            musteriIslemForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.triangles_1430105_1280;
            imgbtnMin.BackColor = Color.Navy;
            imgbtnExit.BackColor = Color.Navy;

            //IslemlerForm.AracListeDoldur();

            //using (var aracServis = new AracWebServis.AracWebServisSoapClient())
            //{
            //    using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
            //    {
            //        foreach (var arac in aracServis.AracHepsiniSec())
            //        {
            //            foreach (var musteri in musteriServis.MusteriHepsiniSec())
            //            {
            //                if(arac.SirketId == Form1.yonetici.SirketId && arac.Rezerv == true)
            //                {
            //                    listviewItem = new ListViewItem(musteri.MusteriId.ToString());
            //                    listviewItem.SubItems.Add(musteri.KullaniciAdi);
            //                    listviewItem.SubItems.Add(musteri.Ad);
            //                    listviewItem.SubItems.Add(musteri.Soyad);
            //                    listviewItem.SubItems.Add(arac.Plaka);
            //                    listviewItem.SubItems.Add(arac.KiralanmaTarihi.Date.ToString());
            //                    listviewItem.SubItems.Add(arac.KiradanDonusTarihi.Date.ToString());
            //                }
            //            }
            //        }

            //    }
                
            //}

            //rezervasyonForm1.listCek().Items.Add(IslemlerForm.listviewItem);
        }



        private void MusteriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriIslemForm1.Show();
            rezervasyonForm1.Hide();
            aracEkleForm1.Hide();
            aracGuncelleSilForm1.Hide();
            kiralamaForm1.Hide();
            girisForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.wall_1851061_1280;
            imgbtnMin.BackColor = Color.Salmon;
            imgbtnExit.BackColor = Color.Salmon;


           
        }

        private void MusteriIslemForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
