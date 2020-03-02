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
    public partial class FrmBayi : Form
    {
        public FrmBayi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand emir;
        OleDbDataReader okuma;

        int sayac;
        public static string bayi_adi;

        void veritabanı()
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = OtobüsBilgileri.accdb");
            baglanti.Open();
        }

        void seferler()
        {
            emir = new OleDbCommand("Select * from Sefer", baglanti);

            okuma = emir.ExecuteReader();
            lwiew_sefer_ekleme();
        }

        void lwiew_sefer_ekleme()
        {
            while (okuma.Read())
            {
                lwiewSeferler.Items.Add(okuma["sefer_no"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["başlangıc"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["bitis"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["tarih"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["otobüs_marka"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["otobüs_model"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["otobüs_bos_koltuk"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["otobüs_koltuk"].ToString());
                lwiewSeferler.Items[sayac].SubItems.Add(okuma["fiyat"].ToString());
                sayac++;
            }
        }

        void bayi_bilgisi()
        {
            emir = new OleDbCommand("Select * from Şube where şube_no=@şube_no", baglanti);
            emir.Parameters.Add("@şube_no", OleDbType.VarChar).Value = FrmKullaniciGiris.sube_no;
            okuma = emir.ExecuteReader();
            if (okuma.Read())
            {
                bayi_adi = okuma["şube adı"].ToString();
                lblBayi.Text = okuma["şube adı"].ToString();
            }
            baglanti.Close();
        }

        void bilet_alma_rezerve(string tür)
        {
            emir = new OleDbCommand("Insert into Biletler (koltuk_no,bilet_fiyat,sefer_no,tc_no,tarih,yol_kart," + tür + ",satılan_sube,satan_calısan) values (@koltuk_no,@bilet_fiyat,@sefer_no,@tc_no,@tarih,@yol_kart,@" + tür + ",@satılan_sube,@satan_calısan)", baglanti);
            emir.Parameters.Add("@koltuk_no", OleDbType.VarChar).Value = cmbKoltukNo.Text;
            emir.Parameters.Add("@bilet_fiyat", OleDbType.VarChar).Value = txtBiletFiyatı.Text;
            emir.Parameters.Add("@sefer_no", OleDbType.VarChar).Value = txtSeferNo.Text;
            emir.Parameters.Add("@tc_no", OleDbType.VarChar).Value = txtTCNo.Text;
            emir.Parameters.Add("@tarih", OleDbType.VarChar).Value = DateTime.Now;
            emir.Parameters.Add("@yol_kart", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@" + tür, OleDbType.Boolean).Value = true;
            emir.Parameters.Add("@satılan_sube", OleDbType.VarChar).Value = FrmKullaniciGiris.sube_no;
            emir.Parameters.Add("@satan_calısan", OleDbType.VarChar).Value = FrmKullaniciGiris.ad_soyad;
            emir.ExecuteNonQuery();
        }

        void koltuk_eksiltme()
        {
            int koltuk_adeti = int.Parse(txtBosKoltuk.Text);
            koltuk_adeti--;
            emir = new OleDbCommand("Update Sefer set otobüs_bos_koltuk=@otobüs_bos_koltuk where sefer_no=@sefer_no", baglanti);
            emir.Parameters.Add("@otobüs_bos_koltuk", OleDbType.VarChar).Value = koltuk_adeti;
            emir.Parameters.Add("@sefer_no", OleDbType.VarChar).Value = txtSeferNo.Text;
            emir.ExecuteNonQuery();
            txtBosKoltuk.Text = koltuk_adeti.ToString();
            lwiewSeferler.SelectedItems[0].SubItems[6].Text = koltuk_adeti.ToString();
        }

        void bos_koltuklar()
        {
            cmbKoltukNo.Items.Clear();
            emir = new OleDbCommand("Select * from Biletler where sefer_no=@sefer_no", baglanti);
            emir.Parameters.Add("@sefer_no", OleDbType.VarChar).Value = lwiewSeferler.SelectedItems[0].SubItems[0].Text;
            int otobüs_koltuk_adet = int.Parse(lwiewSeferler.SelectedItems[0].SubItems[7].Text);
            List<int> dolu_koltuklar = new List<int>();

            okuma = emir.ExecuteReader();
            while (okuma.Read()) dolu_koltuklar.Add(int.Parse(okuma["koltuk_no"].ToString()));

            for (int i = 1; i <= otobüs_koltuk_adet; i++)
            {
                bool koltuk_bos = true;

                for (int l = 0; l <= dolu_koltuklar.Count - 1; l++)
                {
                    if (dolu_koltuklar[l].ToString() == i.ToString())
                    { koltuk_bos = false; break; }
                }
                if (koltuk_bos == true) cmbKoltukNo.Items.Add(i.ToString());
            }
            baglanti.Close();
        }

        private void FrmBayi_Load(object sender, EventArgs e)
        {
            lblCalisan.Text = FrmKullaniciGiris.ad_soyad;
            veritabanı();
            seferler();
            bayi_bilgisi();
        }

        private void lwiewSeferler_MouseClick(object sender, MouseEventArgs e)
        {
            txtSeferNo.Text = lwiewSeferler.SelectedItems[0].SubItems[0].Text;
            txtBaslangic.Text = lwiewSeferler.SelectedItems[0].SubItems[1].Text;
            txtBitis.Text = lwiewSeferler.SelectedItems[0].SubItems[2].Text;
            mtxtTarih.Text = lwiewSeferler.SelectedItems[0].SubItems[3].Text;
            txtOtobüsMarka.Text = lwiewSeferler.SelectedItems[0].SubItems[4].Text;
            txtOtobüsModel.Text = lwiewSeferler.SelectedItems[0].SubItems[5].Text;
            txtBosKoltuk.Text = lwiewSeferler.SelectedItems[0].SubItems[6].Text;
            txtKoltukAdet.Text = lwiewSeferler.SelectedItems[0].SubItems[7].Text;
            txtBiletFiyatı.Text = lwiewSeferler.SelectedItems[0].SubItems[8].Text;
            veritabanı();
            bos_koltuklar();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtBosKoltuk.Text) > 0)
            {
                if (txtTCNo.Text != "")
                {
                    veritabanı();
                    bilet_alma_rezerve("rezervasyon");
                    koltuk_eksiltme();

                    cmbKoltukNo.Items.Remove(cmbKoltukNo.SelectedItem);

                    MessageBox.Show("Başarılı Bir Şekilde Rezervasyon Yapıldı");
                }
                else MessageBox.Show("TC NO girmediniz");
            }
            else MessageBox.Show("Boş Koltuk Yok");
        }

        private void btnBiletSatis_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtBosKoltuk.Text) > 0)
            {
                if (txtTCNo.Text != "")
                {
                    veritabanı();
                    bilet_alma_rezerve("satılma");
                    koltuk_eksiltme();

                    cmbKoltukNo.Items.Remove(cmbKoltukNo.SelectedItem);

                    MessageBox.Show("Başarılı Bir Şekilde Satış Yapıldı Yapıldı");
                }
                else MessageBox.Show("TC NO girmediniz");
            }
            else MessageBox.Show("Boş Koltuk Yok");
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            lwiewSeferler.Items.Clear();
            sayac = 0;

            veritabanı();
            if (mtxtTarih2.Text == "  .  .       :")
            {
                emir = new OleDbCommand("Select * from Sefer where başlangıc=@başlangıc and bitis=@bitis", baglanti);
                emir.Parameters.Add("@başlangıc", OleDbType.VarChar).Value = cmbBaslangic.Text;
                emir.Parameters.Add("@bitis", OleDbType.VarChar).Value = cmbBitis.Text;

                okuma = emir.ExecuteReader();
                lwiew_sefer_ekleme();
            }
            else
            {
                emir = new OleDbCommand("Select * from Sefer where başlangıc=@başlangıc and bitis=@bitis and tarih=@tarih", baglanti);
                emir.Parameters.Add("@başlangıc", OleDbType.VarChar).Value = cmbBaslangic.Text;
                emir.Parameters.Add("@bitis", OleDbType.VarChar).Value = cmbBitis.Text;
                emir.Parameters.Add("@tarih", OleDbType.VarChar).Value = mtxtTarih2.Text;

                okuma = emir.ExecuteReader();
                lwiew_sefer_ekleme();
            }

            baglanti.Close();
        }

        private void btnYolKart_Click(object sender, EventArgs e)
        {
            FrmYolKart goruntule = new FrmYolKart();
            goruntule.ShowDialog();
        }

        private void btnTumSeferler_Click(object sender, EventArgs e)
        {
            sayac = 0;
            lwiewSeferler.Items.Clear();
            veritabanı();
            seferler();
            bayi_bilgisi();
        }
    }
}
