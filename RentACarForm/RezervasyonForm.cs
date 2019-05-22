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
           
           
        }
        private void LstRezervasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)sender;
            selectedId = (Convert.ToInt32(selectedItem.SubItems[0]));
        }
    }
}
