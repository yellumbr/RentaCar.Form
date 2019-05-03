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
    public partial class RezervasyonForm : UserControl
    {
        int selectedId;
        public RezervasyonForm()
        {

            InitializeComponent();
        }

        public ListView listCek()
        {
            return lstRezervasyon;
        }
        private void RezervasyonForm_Load(object sender, EventArgs e)
        {


        }

        private void BtnRezerveKirala_Click(object sender, EventArgs e)
        {
            IslemlerForm.AracListeDoldur();

            using (var aracServis = new AracWebServis.AracWebServisSoapClient())
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
                                AracSayisi = item.AracSayisi - 1
                            };
                            aracServis.AracIdSil(selectedId, sirket);
                        }
                    }

                }
                lstRezervasyon.Items.Remove(lstRezervasyon.SelectedItems[0]);
            }
           
        }
        private void LstRezervasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)sender;
            selectedId = (Convert.ToInt32(selectedItem.SubItems[0]));
        }
    }
}
