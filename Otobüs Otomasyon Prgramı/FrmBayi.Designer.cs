namespace Otobüs_Otomasyon_Prgramı
{
    partial class FrmBayi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lwiewSeferler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.btnBiletSatis = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.cmbKoltukNo = new System.Windows.Forms.ComboBox();
            this.txtBiletFiyatı = new System.Windows.Forms.TextBox();
            this.txtKoltukAdet = new System.Windows.Forms.TextBox();
            this.txtBosKoltuk = new System.Windows.Forms.TextBox();
            this.txtOtobüsModel = new System.Windows.Forms.TextBox();
            this.txtOtobüsMarka = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtSeferNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCalisan = new System.Windows.Forms.Label();
            this.lblBayi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnYolKart = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtxtTarih2 = new System.Windows.Forms.MaskedTextBox();
            this.btnTumSeferler = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbBitis = new System.Windows.Forms.ComboBox();
            this.cmbBaslangic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwiewSeferler
            // 
            this.lwiewSeferler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lwiewSeferler.Location = new System.Drawing.Point(379, 178);
            this.lwiewSeferler.Name = "lwiewSeferler";
            this.lwiewSeferler.Size = new System.Drawing.Size(889, 470);
            this.lwiewSeferler.TabIndex = 21;
            this.lwiewSeferler.UseCompatibleStateImageBehavior = false;
            this.lwiewSeferler.View = System.Windows.Forms.View.Details;
            this.lwiewSeferler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lwiewSeferler_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sefer No";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Başlangıç";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bitiş";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sefer Tarihi";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Otobüs Marka";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Otobüs Model";
            this.columnHeader6.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Boş Koltuk";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Koltuk Sayısı";
            this.columnHeader8.Width = 102;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Koltuk Fiyat";
            this.columnHeader9.Width = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtTarih);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTCNo);
            this.groupBox1.Controls.Add(this.btnBiletSatis);
            this.groupBox1.Controls.Add(this.btnRezervasyon);
            this.groupBox1.Controls.Add(this.cmbKoltukNo);
            this.groupBox1.Controls.Add(this.txtBiletFiyatı);
            this.groupBox1.Controls.Add(this.txtKoltukAdet);
            this.groupBox1.Controls.Add(this.txtBosKoltuk);
            this.groupBox1.Controls.Add(this.txtOtobüsModel);
            this.groupBox1.Controls.Add(this.txtOtobüsMarka);
            this.groupBox1.Controls.Add(this.txtBitis);
            this.groupBox1.Controls.Add(this.txtBaslangic);
            this.groupBox1.Controls.Add(this.txtSeferNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(20, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 470);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yolcu Bilgileri";
            // 
            // mtxtTarih
            // 
            this.mtxtTarih.Enabled = false;
            this.mtxtTarih.Location = new System.Drawing.Point(125, 131);
            this.mtxtTarih.Mask = "00/00/0000 90:00";
            this.mtxtTarih.Name = "mtxtTarih";
            this.mtxtTarih.Size = new System.Drawing.Size(209, 26);
            this.mtxtTarih.TabIndex = 24;
            this.mtxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "TC No:";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(125, 324);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(209, 26);
            this.txtTCNo.TabIndex = 22;
            // 
            // btnBiletSatis
            // 
            this.btnBiletSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBiletSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletSatis.Location = new System.Drawing.Point(173, 404);
            this.btnBiletSatis.Name = "btnBiletSatis";
            this.btnBiletSatis.Size = new System.Drawing.Size(161, 50);
            this.btnBiletSatis.TabIndex = 21;
            this.btnBiletSatis.Text = "Bilet Satış";
            this.btnBiletSatis.UseVisualStyleBackColor = false;
            this.btnBiletSatis.Click += new System.EventHandler(this.btnBiletSatis_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyon.Location = new System.Drawing.Point(10, 404);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(152, 50);
            this.btnRezervasyon.TabIndex = 20;
            this.btnRezervasyon.Text = "Rezervasyon";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // cmbKoltukNo
            // 
            this.cmbKoltukNo.FormattingEnabled = true;
            this.cmbKoltukNo.Location = new System.Drawing.Point(125, 356);
            this.cmbKoltukNo.Name = "cmbKoltukNo";
            this.cmbKoltukNo.Size = new System.Drawing.Size(209, 28);
            this.cmbKoltukNo.TabIndex = 19;
            // 
            // txtBiletFiyatı
            // 
            this.txtBiletFiyatı.Enabled = false;
            this.txtBiletFiyatı.Location = new System.Drawing.Point(125, 291);
            this.txtBiletFiyatı.Name = "txtBiletFiyatı";
            this.txtBiletFiyatı.Size = new System.Drawing.Size(209, 26);
            this.txtBiletFiyatı.TabIndex = 18;
            // 
            // txtKoltukAdet
            // 
            this.txtKoltukAdet.Enabled = false;
            this.txtKoltukAdet.Location = new System.Drawing.Point(125, 259);
            this.txtKoltukAdet.Name = "txtKoltukAdet";
            this.txtKoltukAdet.Size = new System.Drawing.Size(209, 26);
            this.txtKoltukAdet.TabIndex = 17;
            // 
            // txtBosKoltuk
            // 
            this.txtBosKoltuk.Enabled = false;
            this.txtBosKoltuk.Location = new System.Drawing.Point(125, 227);
            this.txtBosKoltuk.Name = "txtBosKoltuk";
            this.txtBosKoltuk.Size = new System.Drawing.Size(209, 26);
            this.txtBosKoltuk.TabIndex = 16;
            // 
            // txtOtobüsModel
            // 
            this.txtOtobüsModel.Enabled = false;
            this.txtOtobüsModel.Location = new System.Drawing.Point(125, 195);
            this.txtOtobüsModel.Name = "txtOtobüsModel";
            this.txtOtobüsModel.Size = new System.Drawing.Size(209, 26);
            this.txtOtobüsModel.TabIndex = 15;
            // 
            // txtOtobüsMarka
            // 
            this.txtOtobüsMarka.Enabled = false;
            this.txtOtobüsMarka.Location = new System.Drawing.Point(125, 163);
            this.txtOtobüsMarka.Name = "txtOtobüsMarka";
            this.txtOtobüsMarka.Size = new System.Drawing.Size(209, 26);
            this.txtOtobüsMarka.TabIndex = 14;
            // 
            // txtBitis
            // 
            this.txtBitis.Enabled = false;
            this.txtBitis.Location = new System.Drawing.Point(125, 99);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(209, 26);
            this.txtBitis.TabIndex = 12;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Enabled = false;
            this.txtBaslangic.Location = new System.Drawing.Point(125, 67);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(209, 26);
            this.txtBaslangic.TabIndex = 11;
            // 
            // txtSeferNo
            // 
            this.txtSeferNo.Enabled = false;
            this.txtSeferNo.Location = new System.Drawing.Point(125, 35);
            this.txtSeferNo.Name = "txtSeferNo";
            this.txtSeferNo.Size = new System.Drawing.Size(209, 26);
            this.txtSeferNo.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Koltuk No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Bilet Fiyatı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Koltuk Adet:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Boş Koltuk:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Otobüs Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Otobüs Marka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sefer Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bitiş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Başlangıç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sefer No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCalisan);
            this.groupBox2.Controls.Add(this.lblBayi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(20, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 153);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblCalisan
            // 
            this.lblCalisan.AutoSize = true;
            this.lblCalisan.Location = new System.Drawing.Point(106, 85);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(28, 24);
            this.lblCalisan.TabIndex = 3;
            this.lblCalisan.Text = "---";
            // 
            // lblBayi
            // 
            this.lblBayi.AutoSize = true;
            this.lblBayi.Location = new System.Drawing.Point(106, 44);
            this.lblBayi.Name = "lblBayi";
            this.lblBayi.Size = new System.Drawing.Size(28, 24);
            this.lblBayi.TabIndex = 2;
            this.lblBayi.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Çalışan:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Bayi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnYolKart);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(267, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 153);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnYolKart
            // 
            this.btnYolKart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYolKart.Location = new System.Drawing.Point(18, 44);
            this.btnYolKart.Name = "btnYolKart";
            this.btnYolKart.Size = new System.Drawing.Size(295, 90);
            this.btnYolKart.TabIndex = 1;
            this.btnYolKart.Text = "Yol Kart Üyelik";
            this.btnYolKart.UseVisualStyleBackColor = false;
            this.btnYolKart.Click += new System.EventHandler(this.btnYolKart_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mtxtTarih2);
            this.groupBox4.Controls.Add(this.btnTumSeferler);
            this.groupBox4.Controls.Add(this.btnSorgula);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cmbBitis);
            this.groupBox4.Controls.Add(this.cmbBaslangic);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(603, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(665, 153);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilet Sorgu";
            // 
            // mtxtTarih2
            // 
            this.mtxtTarih2.Location = new System.Drawing.Point(127, 103);
            this.mtxtTarih2.Mask = "00/00/0000 90:00";
            this.mtxtTarih2.Name = "mtxtTarih2";
            this.mtxtTarih2.Size = new System.Drawing.Size(214, 29);
            this.mtxtTarih2.TabIndex = 25;
            this.mtxtTarih2.ValidatingType = typeof(System.DateTime);
            // 
            // btnTumSeferler
            // 
            this.btnTumSeferler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTumSeferler.Location = new System.Drawing.Point(481, 28);
            this.btnTumSeferler.Name = "btnTumSeferler";
            this.btnTumSeferler.Size = new System.Drawing.Size(169, 106);
            this.btnTumSeferler.TabIndex = 7;
            this.btnTumSeferler.Text = "Tüm Seferleri Göster";
            this.btnTumSeferler.UseVisualStyleBackColor = false;
            this.btnTumSeferler.Click += new System.EventHandler(this.btnTumSeferler_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSorgula.Location = new System.Drawing.Point(348, 28);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(127, 106);
            this.btnSorgula.TabIndex = 6;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 24);
            this.label17.TabIndex = 4;
            this.label17.Text = "Tarih:";
            // 
            // cmbBitis
            // 
            this.cmbBitis.FormattingEnabled = true;
            this.cmbBitis.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbBitis.Location = new System.Drawing.Point(127, 64);
            this.cmbBitis.Name = "cmbBitis";
            this.cmbBitis.Size = new System.Drawing.Size(214, 32);
            this.cmbBitis.TabIndex = 3;
            // 
            // cmbBaslangic
            // 
            this.cmbBaslangic.FormattingEnabled = true;
            this.cmbBaslangic.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbBaslangic.Location = new System.Drawing.Point(127, 28);
            this.cmbBaslangic.Name = "cmbBaslangic";
            this.cmbBaslangic.Size = new System.Drawing.Size(214, 32);
            this.cmbBaslangic.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç:";
            // 
            // FrmBayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lwiewSeferler);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBayi";
            this.Text = "Bayi";
            this.Load += new System.EventHandler(this.FrmBayi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwiewSeferler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBiletSatis;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.ComboBox cmbKoltukNo;
        private System.Windows.Forms.TextBox txtBiletFiyatı;
        private System.Windows.Forms.TextBox txtKoltukAdet;
        private System.Windows.Forms.TextBox txtBosKoltuk;
        private System.Windows.Forms.TextBox txtOtobüsModel;
        private System.Windows.Forms.TextBox txtOtobüsMarka;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtSeferNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCalisan;
        private System.Windows.Forms.Label lblBayi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnYolKart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbBitis;
        private System.Windows.Forms.ComboBox cmbBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTumSeferler;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.MaskedTextBox mtxtTarih;
        private System.Windows.Forms.MaskedTextBox mtxtTarih2;

    }
}