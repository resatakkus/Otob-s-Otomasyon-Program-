using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otobüs_Otomasyon_Prgramı
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void btnMerkezGiris_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.ShowDialog();
        }

        private void btnBayiGiris_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.ShowDialog();
        }

        private void btnInternetSatis_Click(object sender, EventArgs e)
        {
            FrmİnternetSatis frm = new FrmİnternetSatis();
            frm.ShowDialog();
        }
    }
}
