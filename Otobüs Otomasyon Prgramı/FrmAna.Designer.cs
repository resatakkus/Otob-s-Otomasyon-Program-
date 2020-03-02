namespace Otobüs_Otomasyon_Prgramı
{
    partial class FrmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAna));
            this.btnMerkezGiris = new System.Windows.Forms.Button();
            this.btnBayiGiris = new System.Windows.Forms.Button();
            this.btnInternetSatis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMerkezGiris
            // 
            this.btnMerkezGiris.BackColor = System.Drawing.Color.Teal;
            this.btnMerkezGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMerkezGiris.Location = new System.Drawing.Point(22, 12);
            this.btnMerkezGiris.Name = "btnMerkezGiris";
            this.btnMerkezGiris.Size = new System.Drawing.Size(180, 69);
            this.btnMerkezGiris.TabIndex = 0;
            this.btnMerkezGiris.Text = "Merkez Giriş";
            this.btnMerkezGiris.UseVisualStyleBackColor = false;
            this.btnMerkezGiris.Click += new System.EventHandler(this.btnMerkezGiris_Click);
            // 
            // btnBayiGiris
            // 
            this.btnBayiGiris.BackColor = System.Drawing.Color.Teal;
            this.btnBayiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBayiGiris.Location = new System.Drawing.Point(22, 98);
            this.btnBayiGiris.Name = "btnBayiGiris";
            this.btnBayiGiris.Size = new System.Drawing.Size(180, 69);
            this.btnBayiGiris.TabIndex = 1;
            this.btnBayiGiris.Text = "Bayi Giriş";
            this.btnBayiGiris.UseVisualStyleBackColor = false;
            this.btnBayiGiris.Click += new System.EventHandler(this.btnBayiGiris_Click);
            // 
            // btnInternetSatis
            // 
            this.btnInternetSatis.BackColor = System.Drawing.Color.Teal;
            this.btnInternetSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInternetSatis.Location = new System.Drawing.Point(22, 181);
            this.btnInternetSatis.Name = "btnInternetSatis";
            this.btnInternetSatis.Size = new System.Drawing.Size(180, 69);
            this.btnInternetSatis.TabIndex = 2;
            this.btnInternetSatis.Text = "İnternet Satış";
            this.btnInternetSatis.UseVisualStyleBackColor = false;
            this.btnInternetSatis.Click += new System.EventHandler(this.btnInternetSatis_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(226, 262);
            this.Controls.Add(this.btnInternetSatis);
            this.Controls.Add(this.btnBayiGiris);
            this.Controls.Add(this.btnMerkezGiris);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAna";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMerkezGiris;
        private System.Windows.Forms.Button btnBayiGiris;
        private System.Windows.Forms.Button btnInternetSatis;
    }
}

