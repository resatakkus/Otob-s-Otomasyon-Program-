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
    public partial class FrmKullaniciGiris : Form
    {
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand emir;
        OleDbDataReader okuma;

        public static string sube_no, ad_soyad;

        void veritabanı()
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = OtobüsBilgileri.accdb");
            baglanti.Open();
        }

        void calısan_giris()
        {
            emir = new OleDbCommand("Select * from çalışan where Kullanici_adi=@Kullanici_adi and Sifre=@Sifre", baglanti);
            emir.Parameters.Add("@Kullanici_adi", OleDbType.VarChar).Value = txtKullaniciAdi.Text;
            emir.Parameters.Add("@Sifre", OleDbType.VarChar).Value = txtSifre.Text;

            okuma = emir.ExecuteReader();
            if (okuma.Read())
            {
                ad_soyad = okuma["Ad"].ToString() + " " + okuma["Soyad"].ToString();
                sube_no = okuma["calıstıgı_sube"].ToString();

                FrmBayi goruntule = new FrmBayi();
                goruntule.Show();
            }
            else MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre");
        }
        private void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            veritabanı();
            calısan_giris();
        }
    }
}
