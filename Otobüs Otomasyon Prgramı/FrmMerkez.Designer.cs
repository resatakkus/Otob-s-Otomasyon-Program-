namespace Otobüs_Otomasyon_Prgramı
{
    partial class FrmMerkez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMerkez));
            this.btnYeniSefer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYapilanAylikKar = new System.Windows.Forms.TextBox();
            this.txtYapilanKar = new System.Windows.Forms.TextBox();
            this.cmbSube2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCalistigi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.cmbCalisanAdSoyad = new System.Windows.Forms.ComboBox();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYeniSefer
            // 
            this.btnYeniSefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYeniSefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniSefer.Location = new System.Drawing.Point(534, 12);
            this.btnYeniSefer.Name = "btnYeniSefer";
            this.btnYeniSefer.Size = new System.Drawing.Size(99, 516);
            this.btnYeniSefer.TabIndex = 5;
            this.btnYeniSefer.Text = "Yeni Sefer";
            this.btnYeniSefer.UseVisualStyleBackColor = false;
            this.btnYeniSefer.Click += new System.EventHandler(this.btnYeniSefer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYapilanAylikKar);
            this.groupBox2.Controls.Add(this.txtYapilanKar);
            this.groupBox2.Controls.Add(this.cmbSube2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışan Bilgileri";
            // 
            // txtYapilanAylikKar
            // 
            this.txtYapilanAylikKar.Location = new System.Drawing.Point(231, 132);
            this.txtYapilanAylikKar.Name = "txtYapilanAylikKar";
            this.txtYapilanAylikKar.Size = new System.Drawing.Size(247, 31);
            this.txtYapilanAylikKar.TabIndex = 10;
            // 
            // txtYapilanKar
            // 
            this.txtYapilanKar.Location = new System.Drawing.Point(231, 95);
            this.txtYapilanKar.Name = "txtYapilanKar";
            this.txtYapilanKar.Size = new System.Drawing.Size(247, 31);
            this.txtYapilanKar.TabIndex = 9;
            // 
            // cmbSube2
            // 
            this.cmbSube2.FormattingEnabled = true;
            this.cmbSube2.Location = new System.Drawing.Point(231, 56);
            this.cmbSube2.Name = "cmbSube2";
            this.cmbSube2.Size = new System.Drawing.Size(247, 33);
            this.cmbSube2.TabIndex = 7;
            this.cmbSube2.SelectedIndexChanged += new System.EventHandler(this.cmbSube2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Yapılan Aylık Kar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Yapılan Kar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Şube:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCalistigi);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.txtEPosta);
            this.groupBox1.Controls.Add(this.cmbCalisanAdSoyad);
            this.groupBox1.Controls.Add(this.cmbSube);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 331);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Bilgileri";
            // 
            // txtCalistigi
            // 
            this.txtCalistigi.Location = new System.Drawing.Point(231, 281);
            this.txtCalistigi.Name = "txtCalistigi";
            this.txtCalistigi.Size = new System.Drawing.Size(247, 31);
            this.txtCalistigi.TabIndex = 13;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(231, 244);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(247, 31);
            this.txtTelefon.TabIndex = 12;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(231, 207);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(247, 31);
            this.txtSifre.TabIndex = 11;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(231, 170);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(247, 31);
            this.txtKullaniciAdi.TabIndex = 10;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(231, 133);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(247, 31);
            this.txtEPosta.TabIndex = 9;
            // 
            // cmbCalisanAdSoyad
            // 
            this.cmbCalisanAdSoyad.FormattingEnabled = true;
            this.cmbCalisanAdSoyad.Location = new System.Drawing.Point(231, 94);
            this.cmbCalisanAdSoyad.Name = "cmbCalisanAdSoyad";
            this.cmbCalisanAdSoyad.Size = new System.Drawing.Size(247, 33);
            this.cmbCalisanAdSoyad.TabIndex = 8;
            this.cmbCalisanAdSoyad.SelectedIndexChanged += new System.EventHandler(this.cmbCalisanAdSoyad_SelectedIndexChanged);
            // 
            // cmbSube
            // 
            this.cmbSube.FormattingEnabled = true;
            this.cmbSube.Location = new System.Drawing.Point(231, 56);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Size = new System.Drawing.Size(247, 33);
            this.cmbSube.TabIndex = 7;
            this.cmbSube.SelectedIndexChanged += new System.EventHandler(this.cmbSube_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Çalıştığı Şube:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Posta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çalışan Ad ve Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube:";
            // 
            // FrmMerkez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(651, 538);
            this.Controls.Add(this.btnYeniSefer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMerkez";
            this.Text = "Merkez";
            this.Load += new System.EventHandler(this.FrmMerkez_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniSefer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYapilanAylikKar;
        private System.Windows.Forms.TextBox txtYapilanKar;
        private System.Windows.Forms.ComboBox cmbSube2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCalistigi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.ComboBox cmbCalisanAdSoyad;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}