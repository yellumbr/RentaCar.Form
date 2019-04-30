using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Concretes;

namespace RentACarForm
{
    public partial class MusteriIslemForm : UserControl
    {
        List<Musteriler> musteriler = new List<Musteriler>();//Musterilerin LİSTESİ ÇEKİLİR

        public MusteriIslemForm()
        {
            InitializeComponent();
        }
        public TextBox[] TxtCek()
        {
            TextBox[] textler = new TextBox[8];
            textler[0] = txtMusteriAd;
            textler[1] = txtMusteriSoyad;
            textler[2] = txtMusteriTc;
            textler[3] = txtMusteriAdres;
            textler[4] = txtMusteriTel;
            textler[5] = txtEmail;
            textler[6] = txtKullaniciAdi;
            textler[7] = txtSifre;

            return textler;
        }

        public ComboBox comboCek()
        {
            return cmbKayitliMusteriSil;
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (var musteri = new MusterilerWebServis.MusterilerWebServisSoapClient())
                {
                    success = musteri.MusteriEkle(new MusterilerWebServis.Musteriler()
                    {
                        
                        Ad = txtMusteriAd.Text,
                        Soyad = txtMusteriSoyad.Text,
                        TcKimlik = txtMusteriTc.Text,
                        Adres = txtMusteriAdres.Text,
                        Telefon = txtMusteriTel.Text,
                        Email = txtEmail.Text,
                        DogumTarihi = dtpMusteriDogumTarihi.Value,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Sifre = txtSifre.Text,
                        EhliyetYil = dtMusteriEhliyetTarihi.Value,
                        EhliyetTipi = txtMusteriEhliyetTipi.Text
                    });
                }
                var message = success ? "done" : "failed";
                //MÜŞTERİNİN EKLENİP EKLENMEDİĞİ KONTORL EDİLİR
                MessageBox.Show("Operation " + message);
            }
            catch (Exception ex)//BAŞARISIZ OLURSA MESAJ DÖNER
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }


            try
            {
                using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
                {
                    foreach (var cevaplayanMusteri in musteriServis.MusteriHepsiniSec().OrderBy(x => x.MusteriId)
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

                        cmbKayitliMusteriSil.Items.Add(item.KullaniciAdi);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }


        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {

            try
            {
                using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
                {
                    foreach (var item in musteriler)
                    {
                        if(item.KullaniciAdi == cmbKayitliMusteriSil.Text)
                        {
                            musteriServis.MusteriIdSil(item.MusteriId);
                            musteriler.Remove(item);
                        }
                    }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }

        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            using (var musteriServis = new MusterilerWebServis.MusterilerWebServisSoapClient())
            {
                foreach (var item in musteriler)
                {
                    if(cmbKayitliMusteriSil.Text==item.KullaniciAdi)
                    {
                        var musteri = new MusterilerWebServis.Musteriler()
                        {
                            MusteriId = item.MusteriId,
                            Sifre = txtSifre.Text,
                            KullaniciAdi = txtKullaniciAdi.Text,
                            EhliyetYil = dtMusteriEhliyetTarihi.Value,
                            EhliyetTipi = txtMusteriEhliyetTipi.Text,
                            TcKimlik = txtMusteriTc.Text,
                            Ad = txtMusteriAd.Text,
                            Soyad = txtMusteriSoyad.Text,
                            Adres = txtMusteriAdres.Text,
                            Telefon = txtMusteriTel.Text,
                            Email =txtEmail.Text,
                            DogumTarihi = dtpMusteriDogumTarihi.Value

                        };
                        
                        musteriServis.MusteriGuncelle(musteri); 
                    }
                }
               
            }

           
        }

        private void CmbKayitliMusteriSil_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in musteriler)
            {
                if (item.KullaniciAdi==cmbKayitliMusteriSil.Text)
                {
                    txtMusteriAd.Text = item.Ad;
                    txtMusteriSoyad.Text = item.Soyad;
                    txtEmail.Text = item.Email;
                    txtKullaniciAdi.Text = item.KullaniciAdi;
                    txtMusteriAdres.Text = item.Adres;
                    txtMusteriEhliyetTipi.Text = item.EhliyetTipi;
                    txtMusteriTc.Text = item.TcKimlik;
                    txtMusteriTel.Text = item.Telefon;
                    txtSifre.Text = item.Sifre;
                    dtMusteriEhliyetTarihi.Value= item.EhliyetYil;
                    dtpMusteriDogumTarihi.Value = item.DogumTarihi;
 
                }
            }
        }
    }
}
