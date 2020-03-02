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
    public partial class FrmMerkez : Form
    {
        public FrmMerkez()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbDataAdapter adaptör;
        OleDbCommand emir;
        OleDbDataReader okuma;
        DataTable tablo;

        void veri_tabanı()
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = OtobüsBilgileri.accdb");
            baglanti.Open();
        }

        void subeler()
        {
            adaptör = new OleDbDataAdapter("Select * from Şube", baglanti);
            tablo = new DataTable();
            adaptör.Fill(tablo);
            cmbSube.ValueMember = "şube_no";
            cmbSube.DisplayMember = "şube adı";
            cmbSube.DataSource = tablo;
        }

        void subeler2()
        {
            adaptör = new OleDbDataAdapter("Select * from Şube", baglanti);
            tablo = new DataTable();
            adaptör.Fill(tablo);
            cmbSube2.ValueMember = "şube_no";
            cmbSube2.DisplayMember = "şube adı";
            cmbSube2.DataSource = tablo;
            baglanti.Close();
        }

        void calısanlar()
        {
            emir = new OleDbCommand("Select * from çalışan where calıstıgı_sube=@calıstıgı_sube", baglanti);
            emir.Parameters.Add("@calıstıgı_sube", OleDbType.VarChar).Value = cmbSube.SelectedValue.ToString();
            tablo = new DataTable();
            tablo.Columns.Add("kullanici_eposta");
            tablo.Columns.Add("Ad_Soyad");
            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                DataRow satır = tablo.NewRow();
                satır["kullanici_eposta"] = okuma["eposta"].ToString();
                satır["Ad_Soyad"] = okuma["Ad"].ToString() + " " + okuma["Soyad"].ToString();
                tablo.Rows.Add(satır);
            }
            cmbCalisanAdSoyad.ValueMember = "kullanici_eposta";
            cmbCalisanAdSoyad.DisplayMember = "Ad_Soyad";
            cmbCalisanAdSoyad.DataSource = tablo;
            baglanti.Close();
        }

        void calısan_bilgisi()
        {
            emir = new OleDbCommand("Select * from çalışan where eposta=@eposta", baglanti);
            emir.Parameters.Add("@eposta", OleDbType.VarChar).Value = cmbCalisanAdSoyad.SelectedValue.ToString();
            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                txtEPosta.Text = cmbCalisanAdSoyad.SelectedValue.ToString();
                txtKullaniciAdi.Text = okuma["Kullanici_adi"].ToString();
                txtSifre.Text = okuma["Sifre"].ToString();
                txtTelefon.Text = okuma["telefon"].ToString();
                txtCalistigi.Text = cmbSube.SelectedValue.ToString();
            }
            baglanti.Close();
        }

        void sube_kazanc()
        {
            emir = new OleDbCommand("Select * from Biletler where satılma=@satılma and satılan_sube=@satılan_sube", baglanti);
            emir.Parameters.Add("@satılma", OleDbType.Boolean).Value = true;
            emir.Parameters.Add("@satılan_sube", OleDbType.VarChar).Value = cmbSube2.SelectedValue.ToString();
            double toplam_kazanc = 0;
            double aylık_kazanc = 0;
            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                DateTime bilet_tarihi = DateTime.Parse(okuma["tarih"].ToString());

                if (DateTime.Now.Year == bilet_tarihi.Year && DateTime.Now.Month == bilet_tarihi.Month) aylık_kazanc += double.Parse(okuma["bilet_fiyat"].ToString());

                toplam_kazanc += double.Parse(okuma["bilet_fiyat"].ToString());
            }
            baglanti.Close();
            txtYapilanKar.Text = toplam_kazanc.ToString();
            txtYapilanAylikKar.Text = aylık_kazanc.ToString();
        }

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri_tabanı();
            calısanlar();
        }

        private void cmbCalisanAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri_tabanı();
            calısan_bilgisi();
        }

        private void cmbSube2_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri_tabanı();
            sube_kazanc();
        }

        private void btnYeniSefer_Click(object sender, EventArgs e)
        {
            FrmYeniSefer frm = new FrmYeniSefer();
            frm.ShowDialog();
        }

        private void FrmMerkez_Load(object sender, EventArgs e)
        {
            veri_tabanı();
            subeler();
            subeler2();
        }
    }
}
