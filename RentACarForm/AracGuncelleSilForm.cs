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
    public partial class AracGuncelleSilForm : UserControl
    {
        public AracGuncelleSilForm()
        {
            InitializeComponent();
        }
        public ComboBox comboCek()
        {
            return cmbPlaka;
        }
        private void labelControl4_Click(object sender, EventArgs e)
        {

        }


        private void btnAracBilgiGetir_Click(object sender, EventArgs e)
        {
            foreach (var item in IslemlerForm.araclar)
            {
                if (item.Plaka == cmbPlaka.Text)
                {
                    txtAracKm.Text = item.AracKm.ToString();
                    txtBagajHacmi.Text = item.BagajHacmi.ToString();
                    txtEhliyetYasi.Text = item.GerekenEhliyetYasi.ToString();
                    txtKiraMiktari.Text = item.GunlukKiraBedeli.ToString();
                    txtKmSinir.Text = item.GunlukKmSiniri.ToString();
                    txtKoltukSayisi.Text = item.KoltukSayisi.ToString();
                    txtMarka.Text = item.AracAdi;
                    txtModel.Text = item.AracModeli;
                    txtPlaka.Text = item.Plaka;
                    txtYasSiniri.Text = item.MinimumYasSiniri.ToString();
                    cmbAirBag.Text = item.HavaYastigi;
                    cmbVites.Text = item.VitesTipi;
                    cmbYakit.Text = item.YakitTipi;
                    
                }
            }
        }

        private void btnAracDuzenle_Click(object sender, EventArgs e)
        {
            using (var aracServis = new AracWebServis.AracWebServisSoapClient())
            {
                foreach (var item in IslemlerForm.araclar)
                {
                    if (cmbPlaka.Text == item.Plaka)
                    {

                        var arac = new AracWebServis.Araclar()
                        {
                            AracId = item.AracId,
                            AracAdi = txtMarka.Text,
                            AracKm = Convert.ToInt32(txtAracKm.Text),
                            AracModeli = txtModel.Text,
                            BagajHacmi = Convert.ToInt32(txtBagajHacmi.Text),
                            GerekenEhliyetYasi = Convert.ToInt32(txtEhliyetYasi.Text),
                            GunlukKiraBedeli = Convert.ToInt32(txtKiraMiktari.Text),
                            GunlukKmSiniri = Convert.ToInt32(txtKmSinir.Text),
                            KoltukSayisi = Convert.ToInt32(txtKoltukSayisi.Text),
                            MinimumYasSiniri = Convert.ToInt32(txtYasSiniri.Text),
                            Plaka = txtPlaka.Text,
                            HavaYastigi = cmbAirBag.Text,
                            YakitTipi = cmbYakit.Text,
                            VitesTipi = cmbVites.Text,


                        };

                        aracServis.AracGuncelle(arac);
                    }
                }

            }
            IslemlerForm.AracListeDoldur();
        }

        private void BtnAracSil_Click(object sender, EventArgs e)
        {
            bool success = false;
            string message;
            try
            {
                using (var aracServis = new AracWebServis.AracWebServisSoapClient())
                {
                    foreach (var arac in IslemlerForm.araclar)
                    {
                        if (arac.Plaka == cmbPlaka.Text)
                        {
                             using (var sirketSoapClient = new SirketWebServis.SirketWebServisSoapClient())
                            {
                                foreach (var item in sirketSoapClient.SirketHepsiniSec())
                                {
                                    if (item.SirketId == Form1.yonetici.SirketId)
                                    {
                                        var sirket = new AracWebServis.Sirket()
                                        {
                                            SirketAdi = item.SirketAdi,
                                            SirketId = item.SirketId,
                                            Sehir = item.Sehir,
                                            SirketPuani = item.SirketPuani,
                                            Adres = item.Adres,
                                            AracSayisi = item.AracSayisi -1
                                        };

                                        success = aracServis.AracIdSil(arac.AracId, sirket);
                                            

                                    }
                                    message = success ? "done" : "failed";
                                }

                            }


                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
            IslemlerForm.AracListeDoldur();
        }
    }
}
