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
           
        }

        private void BtnAracSil_Click(object sender, EventArgs e)
        {
           
        }
    }
}
