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
    public partial class KiralamaForm : UserControl
    {
        
        public KiralamaForm()
        {
            InitializeComponent();
        }
        public ComboBox comboCek()
        {
            return cmbAracPlakalar;
        }
        public ComboBox comboCek1()
        {
            return cmbKayitliMusteri;
        }
        private void BtnAracKirala_Click(object sender, EventArgs e)
        {
            using (var aracServis = new AracWebServis.AracWebServisSoapClient())
            {
                foreach (var item in IslemlerForm.araclar)
                {
                    if (cmbAracPlakalar.Text == item.Plaka)
                    {
                        foreach (var musteri in IslemlerForm.musteriler)
                        {
                            if (cmbKayitliMusteri.Text==musteri.KullaniciAdi)
                            {
                                
                                var araclar = new AracWebServis.Araclar()
                                {
                                    AracId = item.AracId,
                                    AracAdi = item.AracAdi,
                                    AracKm = item.AracKm,
                                    AracModeli = item.AracModeli,
                                    BagajHacmi = item.BagajHacmi,
                                    GerekenEhliyetYasi = item.GerekenEhliyetYasi,
                                    GunlukKiraBedeli = item.GunlukKiraBedeli,
                                    GunlukKmSiniri = item.GunlukKmSiniri,
                                    KoltukSayisi = item.KoltukSayisi,
                                    MinimumYasSiniri = item.MinimumYasSiniri,
                                    Plaka = item.Plaka,
                                    HavaYastigi = item.HavaYastigi,
                                    YakitTipi = item.YakitTipi,
                                    VitesTipi = item.VitesTipi,
                                    //Musteri = m,

                                    };

                                aracServis.AracGuncelle(araclar);
                            }
                        }
                        
                        
                    }
                }

            }
        }
    }
}
