using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otobüs_Otomasyon_Prgramı
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand emir;
        OleDbDataReader okuma;

        void veri_tabanı()
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = OtobüsBilgileri.accdb");
            baglanti.Open();
        }

        void giris_kontrol()
        {
            emir = new OleDbCommand("Select * from Merkez where kullanici_ıd=@kullanici_ıd and sifre=@sifre", baglanti);
            emir.Parameters.Add("@kullanici_ıd", OleDbType.VarChar).Value = txtKullaniciAdi.Text;
            emir.Parameters.Add("@sifre", OleDbType.VarChar).Value = txtSifre.Text;

            okuma = emir.ExecuteReader();
            if (okuma.Read())
            {
                FrmMerkez goruntule = new FrmMerkez();
                goruntule.Show();
            }
            else MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");

            baglanti.Close();
        }

        private void ckdSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdSifre.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            giris_kontrol();
        }
    }
}
