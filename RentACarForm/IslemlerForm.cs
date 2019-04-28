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
using BankAppForm.Soap.BankAppCustomerService;
using BankAppForm.Soap.BankAppTransactionService;
using Customers = Bank.Models.Concretes.Customers;
using Transactions = Bank.Models.Concretes.Transactions;

namespace RentACarForm
{
    public partial class IslemlerForm : Form
    {
        MusteriIslemForm musteriForm = new MusteriIslemForm();
        AracGuncelleSilForm aracSilForm = new AracGuncelleSilForm();
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
                using (var aracSoapClient = new AracWebServiceSoapClient())
                {
                    List<Arac> araclar = new List<Arac>();//Araçların LİSTESİ ÇEKİLİR
                    foreach (var cevaplayanArac in aracSoapClient.TumAraclariSec().OrderBy(x => x.AracId)
                        .ToList())
                    {
                        Arac arac = new Arac()
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
                using (var aracSoapClient = new AracWebServiceSoapClient())
                {
                    List<Musteriler> musteriler = new List<Musteriler>();//Musterilerin LİSTESİ ÇEKİLİR
                    foreach (var cevaplayanMusteri in aracSoapClient.TumMusterileriSec().OrderBy(x => x.MusteriId)
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
    }
}
