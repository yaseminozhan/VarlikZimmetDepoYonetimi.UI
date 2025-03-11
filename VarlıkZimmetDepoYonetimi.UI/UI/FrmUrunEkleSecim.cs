using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlıkZimmetDepoYonetimi.UI.BL_business_;
using VarlıkZimmetDepoYonetimi.UI.Entities;

namespace VarlıkZimmetDepoYonetimi.UI
{
    public partial class FrmUrunEkleSecim : Form
    {
        public MyDBContext _context;
        public FrmUrunEkleSecim()
        {
            InitializeComponent();
            _context = new MyDBContext();
        }
        /// <summary>
        /// burada kullanıcıya iki seçenek sunuluyor barkodlu ürün mü girilecek yoksa barkodsuz ürün mü. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (RbtnBarkodluUrun.Checked) //eğer barkodlu ürün seçildiyse
            {
                FRMBarkodluUrunEkleGuncelle barkodluUrunlerForm = new FRMBarkodluUrunEkleGuncelle();
                barkodluUrunlerForm.ShowDialog(); //ürün ekleme formunu aç
            }
            else if (RbtnBarkodsuzUrun.Checked) //eğer barkodsuz ürün seçildiye
            {
                FrmBarkodsuzUrunEkleGuncelle barkodsuzUrunlerForm = new FrmBarkodsuzUrunEkleGuncelle();
                barkodsuzUrunlerForm.ShowDialog();
            }


            if (rbtnZimmetAtama.Checked) //zimmet atama seçildiyse
            {
                FRMZimmetAta frmZimmet = new FRMZimmetAta();
                frmZimmet.ShowDialog();
            }

        }

       
    }
}
