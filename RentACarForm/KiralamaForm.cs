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
            
            
            
        }

        private void KiralamaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
