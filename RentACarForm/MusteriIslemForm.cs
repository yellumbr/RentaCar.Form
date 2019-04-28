using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarForm
{
    public partial class MusteriIslemForm : UserControl
    {
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
                using (var musteriSoapClient = new MusteriWebServiceSoapClient())
                {
                    success = musteriSoapClient.MusteriEkle(new RentaCarAppMusteriService.Musteriler()
                    {
                        Ad = txtMusteriAd.Text,
                        Soyad = txtMusteriSoyad.Text,
                        TcKimlik = txtMusteriTc.Text,
                        Adres = txtMusteriAdres.Text,
                        Telefon = txtMusteriTel.Text,
                        Email = txtEmail.Text,
                        DoğumTarihi = dtpMusteriDogumTarihi.Text,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Sifre = txtSifre.Text,
                        EhliyetYil = dtMusteriEhliyetTarihi.Text,
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

                        cmbKayitliMusteriSil.Items.Add(item.Ad);
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
