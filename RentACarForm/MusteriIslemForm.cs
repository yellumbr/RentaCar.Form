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
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
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
        private async void btnMusteriEkle_Click(object sender, EventArgs e)
        {

            bool success = false;
           
            


            using (var client = new HttpClient())
            {
                // Setup basics
                client.BaseAddress = new Uri("http://localhost:54205/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // Create post body object
                Kullanici kullanici = new Kullanici()
                {
                    Ad = txtMusteriAd.Text,
                    Soyad = txtMusteriSoyad.Text,
                    TcKimlik = txtMusteriTc.Text,
                    Adres = txtMusteriAdres.Text,
                    Telefon = txtMusteriTel.Text,
                    Email = txtEmail.Text,
                    DogumTarihi = dtpMusteriDogumTarihi.Value.Date,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Parola = txtSifre.Text,
                    KullaniciTipi = "M"
                    

                };

                Musteri musteri = new Musteri()
                {
                    KaraListe = false,
                    Ceza = 0,
                    EhliyetTipi = txtMusteriEhliyetTipi.Text,
                    EhliyetTarihi = dtMusteriEhliyetTarihi.Value.Date
                };

                // Serialize C# object to Json Object
                var donusturulmusKullanici = JsonConvert.SerializeObject(kullanici);
                var donusturulmusMusteri = JsonConvert.SerializeObject(musteri);
                // Json object to System.Net.Http content type
                var Kullanici = new StringContent(donusturulmusKullanici, Encoding.UTF8, "application/json");
                var Musteri = new StringContent(donusturulmusMusteri, Encoding.UTF8, "application/json");

                // Post Request to the URI
                var resultKullanici = await client.PostAsync("api/Kullanici", Kullanici);

                var resultMusteri = await client.PostAsync("api/Musteri", Musteri);
                // Check for result
                if (resultKullanici.IsSuccessStatusCode && resultMusteri.IsSuccessStatusCode)
                {
                    success = true;
                }
            }
            var message = success ? "done" : "failed";
            // Inform user
            MessageBox.Show("Operation " + message);
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {

          

        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            


        }

        private void CmbKayitliMusteriSil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
