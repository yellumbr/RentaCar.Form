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
       
        
        MusteriIslemForm musteriForm = new MusteriIslemForm();
        AracGuncelleSilForm aracSilForm = new AracGuncelleSilForm();
        KiralamaForm kiralamaForm = new KiralamaForm();
        public static List<Araclar> araclar { get; set; }
        public static  List<Musteriler> musteriler { get; set; }


        public IslemlerForm()
        {
            
            araclar = new List<Araclar>();
            musteriler = new List<Musteriler>();
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
            raporForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources._20920221;
            imgbtnMin.BackColor = Color.Goldenrod;
            imgbtnExit.BackColor = Color.Goldenrod;
        }

        private void aracSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aracGuncelleSilForm1.Show();
            aracEkleForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
            rezervasyonForm1.Hide();
            musteriIslemForm1.Hide();
            raporForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.abstract_d_geometric_colorful_background_vector;
            imgbtnMin.BackColor = Color.Khaki;
            imgbtnExit.BackColor = Color.Khaki;


            try
            {
                using (var aracSoapClient = new AracWebServis.AracWebServisSoapClient())
                {
                    foreach (var cevaplayanArac in aracSoapClient.AracHepsiniSec().OrderBy(x => x.AracId)
                        .ToList())
                    {
                        Araclar arac = new Araclar()
                        {
                            AracId = cevaplayanArac.AracId,
                            Plaka = cevaplayanArac.Plaka,
                            AracAdi = cevaplayanArac.AracAdi,
                            AracModeli = cevaplayanArac.AracModeli,
                            GerekenEhliyetYasi = cevaplayanArac.GerekenEhliyetYasi,
                            MinimumYasSiniri = cevaplayanArac.MinimumYasSiniri,
                            GunlukKmSiniri = cevaplayanArac.GunlukKmSiniri,
                            AracKm = cevaplayanArac.AracKm,
                            HavaYastigi = cevaplayanArac.HavaYastigi,
                            BagajHacmi = cevaplayanArac.BagajHacmi,
                            KoltukSayisi = cevaplayanArac.KoltukSayisi,
                            GunlukKiraBedeli = cevaplayanArac.GunlukKiraBedeli,
                            YakitTipi = cevaplayanArac.YakitTipi,
                            VitesTipi = cevaplayanArac.VitesTipi,
                        };
                        araclar.Add(arac);
                    }
                    foreach (var item in araclar)
                    {

                        aracSilForm.comboCek().Items.Add(item.Plaka);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
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
            raporForm1.Hide();
            menuStrip1.BackgroundImage= RentACarForm.Properties.Resources.mesh_1430108_1280;
            imgbtnMin.BackColor = Color.MediumVioletRed;
            imgbtnExit.BackColor = Color.MediumVioletRed;


        }

        private void KiralamaIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kiralamaForm1.Show();
            girisForm1.Hide();
            aracGuncelleSilForm1.Hide();
            aracEkleForm1.Hide();
            rezervasyonForm1.Hide();
            musteriIslemForm1.Hide();
            raporForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.geometric;
            imgbtnMin.BackColor = Color.DarkOrange;
            imgbtnExit.BackColor = Color.DarkOrange;

            try
            {
                using (var aracSoapClient = new AracWebServis.AracWebServisSoapClient())
                {
                    foreach (var cevaplayanArac in aracSoapClient.AracHepsiniSec().OrderBy(x => x.AracId)
                        .ToList())
                    {
                        Araclar arac = new Araclar()
                        {
                            AracId = cevaplayanArac.AracId,
                            Plaka = cevaplayanArac.Plaka,
                            AracAdi = cevaplayanArac.AracAdi,
                            AracModeli = cevaplayanArac.AracModeli,
                            GerekenEhliyetYasi = cevaplayanArac.GerekenEhliyetYasi,
                            MinimumYasSiniri = cevaplayanArac.MinimumYasSiniri,
                            GunlukKmSiniri = cevaplayanArac.GunlukKmSiniri,
                            AracKm = cevaplayanArac.AracKm,
                            HavaYastigi = cevaplayanArac.HavaYastigi,
                            BagajHacmi = cevaplayanArac.BagajHacmi,
                            KoltukSayisi = cevaplayanArac.KoltukSayisi,
                            GunlukKiraBedeli = cevaplayanArac.GunlukKiraBedeli,
                            YakitTipi = cevaplayanArac.YakitTipi,
                            VitesTipi = cevaplayanArac.VitesTipi,
                        };
                        araclar.Add(arac);
                    }
                    foreach (var item in araclar)
                    {

                        kiralamaForm.comboCek().Items.Add(item.Plaka);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }

            try
            {
                using (var musteriSoapClient = new MusterilerWebServis.MusterilerWebServisSoapClient())
                {
                    List<Musteriler> musteriler = new List<Musteriler>();//Musterilerin LİSTESİ ÇEKİLİR
                    foreach (var cevaplayanMusteri in musteriSoapClient.MusteriHepsiniSec().OrderBy(x => x.MusteriId)
                        .ToList())
                    {
                        Musteriler musteri = new Musteriler()
                        {
                            MusteriId = cevaplayanMusteri.MusteriId,
                            Sifre = cevaplayanMusteri.Sifre,
                            KullaniciAdi = cevaplayanMusteri.KullaniciAdi,
                            EhliyetYil = cevaplayanMusteri.EhliyetYil,
                            EhliyetTipi = cevaplayanMusteri.EhliyetTipi,
                            TcKimlik = cevaplayanMusteri.TcKimlik,
                            Ad = cevaplayanMusteri.Ad,
                            Soyad = cevaplayanMusteri.Soyad,
                            Adres = cevaplayanMusteri.Adres,
                            Telefon = cevaplayanMusteri.Telefon,
                            Email = cevaplayanMusteri.Email,
                            DogumTarihi = cevaplayanMusteri.DogumTarihi,

                        };
                        musteriler.Add(musteri);
                    }
                    foreach (var item in musteriler)
                    {

                        kiralamaForm.comboCek1().Items.Add(item.KullaniciAdi);

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void RezervelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezervasyonForm1.Show();
            aracEkleForm1.Hide();
            aracGuncelleSilForm1.Hide();
            girisForm1.Hide();
            kiralamaForm1.Hide();
            musteriIslemForm1.Hide();
            raporForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.triangles_1430105_1280;
            imgbtnMin.BackColor = Color.Navy;
            imgbtnExit.BackColor = Color.Navy;
        }

        private void RaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raporForm1.Show();
            rezervasyonForm1.Hide();
            aracEkleForm1.Hide();
            aracGuncelleSilForm1.Hide();
            kiralamaForm1.Hide();
            girisForm1.Hide();
            musteriIslemForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.steel_3419985_1280;
            imgbtnMin.BackColor = Color.Chocolate;
            imgbtnExit.BackColor = Color.Chocolate;
        }

        private void MusteriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriIslemForm1.Show();
            rezervasyonForm1.Hide();
            aracEkleForm1.Hide();
            aracGuncelleSilForm1.Hide();
            kiralamaForm1.Hide();
            girisForm1.Hide();
            raporForm1.Hide();
            menuStrip1.BackgroundImage = RentACarForm.Properties.Resources.wall_1851061_1280;
            imgbtnMin.BackColor = Color.Salmon;
            imgbtnExit.BackColor = Color.Salmon;


            try
            {
                using (var musteriSoapClient = new MusterilerWebServis.MusterilerWebServisSoapClient())
                {
                    List<Musteriler> musteriler = new List<Musteriler>();//Musterilerin LİSTESİ ÇEKİLİR
                    foreach (var cevaplayanMusteri in musteriSoapClient.MusteriHepsiniSec().OrderBy(x => x.MusteriId)
                        .ToList())
                    {
                        Musteriler musteri = new Musteriler()
                        {
                            MusteriId = cevaplayanMusteri.MusteriId,
                            Sifre = cevaplayanMusteri.Sifre,
                            KullaniciAdi = cevaplayanMusteri.KullaniciAdi,
                            EhliyetYil = cevaplayanMusteri.EhliyetYil,
                            EhliyetTipi = cevaplayanMusteri.EhliyetTipi,
                            TcKimlik = cevaplayanMusteri.TcKimlik,
                            Ad = cevaplayanMusteri.Ad,
                            Soyad = cevaplayanMusteri.Soyad,
                            Adres = cevaplayanMusteri.Adres,
                            Telefon = cevaplayanMusteri.Telefon,
                            Email = cevaplayanMusteri.Email,
                            DogumTarihi = cevaplayanMusteri.DogumTarihi,

                        };
                        musteriler.Add(musteri);
                    }
                    foreach (var item in musteriler)
                    {
                        
                        musteriForm.comboCek().Items.Add(item.Ad);
                        
                    }
                   
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void MusteriIslemForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
