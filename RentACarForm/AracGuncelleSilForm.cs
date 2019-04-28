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

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
       

        private void btnAracBilgiGetir_Click(object sender, EventArgs e)
        {
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
                        if(item.Plaka==cmbPlaka.Text)
                        {
                            txtMarka.Text = item.AracAdi;
                            txtModel.Text = item.AracModeli;
                            txtYasSiniri.Text = item.MinimumYasSiniri;
                            cmbYakit.Text = item.YakitTipi;
                            cmbVites.Text = item.VitesTipi;
                            txtPlaka.Text = item.Plaka;
                            txtAracKm.Text = item.AracKm;
                            txtKoltukSayisi.Text = item.KoltukSayisi;
                            cmbAirBag.Text = item.HavaYastigi;
                            txtBagajHacmi.Text = item.BagajHacmi;
                            txtKmSinir.Text = item.GunlukKmSiniri;
                            txtKiraMiktari.Text = item.GunlukKiraBedeli;
                            txtEhliyetYasi.Text = item.GerekenEhliyetYasi;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void btnAracDuzenle_Click(object sender, EventArgs e)
        {
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
                        araclar.(arac);
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
