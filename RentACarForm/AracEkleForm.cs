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
                using (var aracSoapClient = new AracWebServis.AracWebServisSoapClient())
                {
                    success = aracSoapClient.AracEkle(new AracWebServis.Araclar()
                    {
                        AracAdi = txtMarka.Text,
                        AracKm = Convert.ToInt32(txtAracKm.Text),
                        AracModeli = txtModel.Text,
                        BagajHacmi = Convert.ToInt32(txtBagajHacmi.Text),
                        GerekenEhliyetYasi = Convert.ToInt32(txtEhliyetYasi.Text),
                        GunlukKiraBedeli = Convert.ToInt32(txtKiraMiktari.Text),
                        GunlukKmSiniri = Convert.ToInt32(txtKmSinir.Text),
                        KoltukSayisi = Convert.ToInt32(txtKoltukSayisi.Text),
                        MinimumYasSiniri = Convert.ToInt32(txtYasSiniri),
                        Plaka = txtPlaka.Text,
                        HavaYastigi = cmbAirBag.SelectedText,
                        YakitTipi = cmbYakit.SelectedText,
                        VitesTipi = cmbVites.SelectedText,
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
