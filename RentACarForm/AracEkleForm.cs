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
    public partial class AracEkleForm : UserControl
    {
        public AracEkleForm()
        {
            InitializeComponent();
        }


        public String imageLocation = "", imagename = "";
        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool success=false;
                string message;
                using (var aracSoapClient = new AracWebServis.AracWebServisSoapClient())
                {
                    
                    //var sirket = new AracWebServis.Sirket();
                    var arac = new AracWebServis.Araclar()
                    {
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
                        AracResmi = imagename,
                        SirketId = Form1.yonetici.SirketId
                    };
                    
                    
                    using (var sirketSoapClient = new SirketWebServis.SirketWebServisSoapClient())
                    {
                        foreach (var item in sirketSoapClient.SirketHepsiniSec())
                        {
                            if(item.SirketId == Form1.yonetici.SirketId)
                            {
                                var sirket = new AracWebServis.Sirket()
                                {
                                    SirketAdi = item.SirketAdi,
                                    SirketId = item.SirketId,
                                    Sehir = item.Sehir,
                                    SirketPuani = item.SirketPuani,
                                    Adres = item.Adres,
                                    AracSayisi = item.AracSayisi + 1
                                };
                                
                                if(success = aracSoapClient.AracEkle(arac, sirket))
                                    System.IO.File.Copy(imageLocation, "../RentaCarWeb/Content/images/", true);

                            }
                            message = success ? "done" : "failed";
                        }

                    }
                }
                //MÜŞTERİNİN EKLENİP EKLENMEDİĞİ KONTORL EDİLİR
            }
            catch (Exception ex)//BAŞARISIZ OLURSA MESAJ DÖNER
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }

            IslemlerForm.AracListeDoldur();
        }

        private void TxtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
           

            try
            {
                OpenFileDialog selectImage = new OpenFileDialog();
                selectImage.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if(selectImage.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = selectImage.FileName;
                    imagename = selectImage.SafeFileName;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("" + imagename);
                throw;
            }
        }
    }
}
