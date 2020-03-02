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
    public partial class FrmİnternetSatis : Form
    {
        public FrmİnternetSatis()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand emir;
        OleDbDataReader okuma;

        int sayac;
        int tc_no;
        string bilet_no;

        void veritabanı()
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = OtobüsBilgileri.accdb");
            baglanti.Open();
        }

        void seferler()
        {
            emir = new OleDbCommand("Select * from Sefer", baglanti);
            okuma = emir.ExecuteReader();
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

            baglanti.Close();
        }

        void kullanıcı_giris()
        {
            emir = new OleDbCommand("Select * from Yol_Kart", baglanti);
            emir.CommandText = "Select * from Yol_Kart where e_posta=@e_posta";
            emir.Parameters.Add("@e_posta", OleDbType.VarChar).Value = txtEPosta.Text;
            okuma = emir.ExecuteReader();
            if (okuma.Read())
            {
                if (okuma["şifre"].ToString() == txtSifre.Text)
                {
                    MessageBox.Show("Hoş Geldin " + okuma["Ad"].ToString() + " " + okuma["Soyad"].ToString());
                    tc_no = int.Parse(okuma["TCNO"].ToString());
                    btnBiletSatis.Enabled = true;
                    btnRezervasyon.Enabled = true;
                }
                else MessageBox.Show("Yanlış Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Böyle Bir E-posta Kayıtlarda Yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void bilet_alma_rezerve(string tür)
        {
            emir = new OleDbCommand("Insert into Biletler (koltuk_no,bilet_fiyat,sefer_no,tc_no,tarih,yol_kart," + tür + ") values (@koltuk_no,@bilet_fiyat,@sefer_no,@tc_no,@tarih,yol_kart,@" + tür + ")", baglanti);
            emir.Parameters.Add("@koltuk_no", OleDbType.VarChar).Value = cmbKoltukNo.Text;
            emir.Parameters.Add("@bilet_fiyat", OleDbType.VarChar).Value = txtBiletFiyatı.Text;
            emir.Parameters.Add("@sefer_no", OleDbType.VarChar).Value = txtSeferNo.Text;
            emir.Parameters.Add("@tc_no", OleDbType.VarChar).Value = tc_no;
            emir.Parameters.Add("@tarih", OleDbType.VarChar).Value = DateTime.Now;
            emir.Parameters.Add("@yol_kart", OleDbType.Boolean).Value = true;
            emir.Parameters.Add("@" + tür, OleDbType.Boolean).Value = true;
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

        void bilet_no_sorgulama()
        {
            emir = new OleDbCommand("Select * from Biletler where sefer_no=@sefer_no and tc_no=@tc_no", baglanti);
            emir.Parameters.Add("@sefer_no", OleDbType.VarChar).Value = txtSeferNo.Text;
            emir.Parameters.Add("@tc_no", OleDbType.VarChar).Value = tc_no;
            okuma = emir.ExecuteReader();
            if (okuma.Read()) bilet_no = okuma["bilet_no"].ToString();

            baglanti.Close();
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

        private void FrmİnternetSatis_Load(object sender, EventArgs e)
        {
            veritabanı();
            seferler();
        }

        private void lwiewSeferler_Click(object sender, EventArgs e)
        {
            txtSeferNo.Text = lwiewSeferler.SelectedItems[0].SubItems[0].Text;
            txtBaslangic.Text = lwiewSeferler.SelectedItems[0].SubItems[1].Text;
            txtBitis.Text = lwiewSeferler.SelectedItems[0].SubItems[2].Text;
            txtSeferTarihi.Text = lwiewSeferler.SelectedItems[0].SubItems[3].Text;
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
                veritabanı();
                bilet_alma_rezerve("rezervasyon");
                koltuk_eksiltme();
                bilet_no_sorgulama();

                cmbKoltukNo.Items.Remove(cmbKoltukNo.SelectedItem);

                MessageBox.Show("Başarılı Bir Şekilde Rezervasyon Yapıldı Bilet No : " + bilet_no);
            }
            else MessageBox.Show("Boş Koltuk Yok");
        }

        private void btnBiletSatis_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtBosKoltuk.Text) > 0)
            {
                veritabanı();
                bilet_alma_rezerve("satılma");
                koltuk_eksiltme();
                bilet_no_sorgulama();

                cmbKoltukNo.Items.Remove(cmbKoltukNo.SelectedItem);

                MessageBox.Show("Başarılı Bir Şekilde Bilet Satın Alındı Yapıldı Bilet No : " + bilet_no);
            }
            else MessageBox.Show("Boş Koltuk Yok");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            veritabanı();
            kullanıcı_giris();
        }
    }
}
