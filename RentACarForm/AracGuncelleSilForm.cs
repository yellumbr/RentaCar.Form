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
        List<Araclar> araclar = new List<Araclar>();//Musterilerin LİSTESİ ÇEKİLİR
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
            foreach (var item in araclar)
            {
                if(item.Plaka==cmbPlaka.Text)
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
                 
                }
            }
        }

        private void btnAracDuzenle_Click(object sender, EventArgs e)
        {
            using (var aracServis = new AracWebServis.AracWebServisSoapClient())
            {
                foreach (var item in araclar)
                {
                    if (cmbPlaka.Text == item.Plaka)
                    {
                     
                        var araclar = new AracWebServis.Araclar()
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
                            MinimumYasSiniri = Convert.ToInt32(txtYasSiniri),
                            Plaka = txtPlaka.Text,
                            HavaYastigi = cmbAirBag.SelectedText,
                            YakitTipi=cmbYakit.SelectedText,
                            VitesTipi=cmbVites.SelectedText,
                            
                        };

                        aracServis.AracGuncelle(araclar);
                    }
                }

            }
        }

        private void BtnAracSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (var aracServis = new AracWebServis.AracWebServisSoapClient())
                {
                    foreach (var item in araclar)
                    {
                        if (item.Plaka == cmbPlaka.Text)
                        {
                            aracServis.AracIdSil(item.AracId);
                            araclar.Remove(item);
                        }
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
