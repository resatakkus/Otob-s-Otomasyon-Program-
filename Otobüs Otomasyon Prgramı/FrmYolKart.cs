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
    public partial class FrmYolKart : Form
    {
        public FrmYolKart()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand emir;

        void veri_tabanı()
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = OtobüsBilgileri.accdb");
            baglanti.Open();
        }

        void yeni_kisi_ekleme()
        {
            emir = new OleDbCommand("Select * from Yol_Kart", baglanti);
            emir.CommandText = "Insert into Yol_Kart (e_posta,şifre,TCNO,Ad,Soyad,Cinsiyet,Adres,Telefon) values (@e_posta,@şifre,@TCNO,@Ad,@Soyad,@Cinsiyet,@Adres,@Telefon)";
            emir.Parameters.Add("@e_posta", OleDbType.VarChar).Value = txtEPosta.Text;
            emir.Parameters.Add("@şifre", OleDbType.VarChar).Value = txtSifre.Text;
            emir.Parameters.Add("@TCNO", OleDbType.VarChar).Value = txtTCNo.Text;
            emir.Parameters.Add("@Ad", OleDbType.VarChar).Value = txtAd.Text;
            emir.Parameters.Add("@Soyad", OleDbType.VarChar).Value = txtSoyad.Text;
            emir.Parameters.Add("@Cinsiyet", OleDbType.VarChar).Value = cboxCinsiyet.Text;
            emir.Parameters.Add("@Adres", OleDbType.VarChar).Value = txtAdress.Text;
            emir.Parameters.Add("@Telefon", OleDbType.VarChar).Value = txtTelefon.Text;
            emir.ExecuteNonQuery();

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            yeni_kisi_ekleme();
            MessageBox.Show("Üyelik Başarılı Bir Şekilde Yapıldı");
        }

    }
}
