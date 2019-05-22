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
