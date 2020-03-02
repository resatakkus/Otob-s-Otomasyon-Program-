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
    public partial class FrmYeniSefer : Form
    {
        public FrmYeniSefer()
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

        void yeni_sefer()
        {
            emir = new OleDbCommand("Insert into Sefer (başlangıc,bitis,tarih,otobüs_marka,otobüs_model,otobüs_bos_koltuk,otobüs_koltuk,fiyat) values (@başlangıc,@bitis,@tarih,@otobüs_marka,@otobüs_model,@otobüs_bos_koltuk,@otobüs_koltuk,@fiyat)", baglanti);
            emir.Parameters.Add("@başlnagıc", OleDbType.VarChar).Value = txtBaslangicGuzergahi.Text;
            emir.Parameters.Add("@bitiş", OleDbType.VarChar).Value = txtBitisGuzergahi.Text;
            emir.Parameters.Add("@tarih", OleDbType.VarChar).Value = mtxtTarih.Text;
            emir.Parameters.Add("@otobüs_marka", OleDbType.VarChar).Value = txtOMarkasi.Text;
            emir.Parameters.Add("@otobüs_model", OleDbType.VarChar).Value = txtOModeli.Text;
            emir.Parameters.Add("@otobüs_bos_koltuk", OleDbType.VarChar).Value = txtKoltukAdeti.Text;
            emir.Parameters.Add("@otobüs_koltuk", OleDbType.VarChar).Value = txtKoltukAdeti.Text;
            emir.Parameters.Add("@fiyat", OleDbType.VarChar).Value = txtBiletFiyati.Text;
            emir.ExecuteNonQuery();

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            yeni_sefer();
            MessageBox.Show("Yeni Sefer Oluşturuldu.");
        }
    }
}
