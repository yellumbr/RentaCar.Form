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
    public partial class AracEkleForm : UserControl
    {
        public AracEkleForm()
        {
            InitializeComponent();
        }

       

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (var aracSoapClient = new AracWebServiceSoapClient())
                {
                    success = aracSoapClient.AracEkle(new RentaCarAppMusteriService.Araclar()
                    {
                        AracAdi = txtMarka.Text,
                        AracModeli = txtModel.Text,
                        Plaka = txtPlaka.Text,
                        GerekenEhliyetYasi = txtEhliyetYasi.Text,
                        MinimumYasSiniri = txtYasSiniri.Text,
                        GunlukKmSiniri = txtKmSinir.Text,
                        AracKm = txtAracKm.Text,
                        HavaYastigi = bool.Parse(cmbAirBag.Text),
                        BagajHacmi = txtBagajHacmi.Text,
                        KoltukSayisi = txtKoltukSayisi.Text,
                        GunlukKiraBedeli = txtKiraMiktari.Text,
                        YakitTipi = cmbYakıt.Text,
                        VitesTipi = bool.Parse(cmbVites.Text),
                        //AracResmi = txtMusteriEhliyetTipi.Text
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
        }
    }
}
