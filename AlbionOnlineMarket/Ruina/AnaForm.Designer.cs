namespace Ruina
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.btnSiparisYonetimi = new System.Windows.Forms.Button();
            this.btnSiparislerim = new System.Windows.Forms.Button();
            this.btnDestekTalepleri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnKullaniciYonetimi
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(30, 80);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(150, 40);
            this.btnKullaniciYonetimi.TabIndex = 0;
            this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.UseVisualStyleBackColor = true;
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);

            // btnUrunYonetimi
            this.btnUrunYonetimi.Location = new System.Drawing.Point(200, 80);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size = new System.Drawing.Size(150, 40);
            this.btnUrunYonetimi.TabIndex = 1;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);

            // btnSiparisYonetimi
            this.btnSiparisYonetimi.Location = new System.Drawing.Point(30, 140);
            this.btnSiparisYonetimi.Name = "btnSiparisYonetimi";
            this.btnSiparisYonetimi.Size = new System.Drawing.Size(150, 40);
            this.btnSiparisYonetimi.TabIndex = 2;
            this.btnSiparisYonetimi.Text = "Sipariş Yönetimi";
            this.btnSiparisYonetimi.UseVisualStyleBackColor = true;
            this.btnSiparisYonetimi.Click += new System.EventHandler(this.btnSiparisYonetimi_Click);

            // btnSiparislerim
            this.btnSiparislerim.Location = new System.Drawing.Point(200, 140);
            this.btnSiparislerim.Name = "btnSiparislerim";
            this.btnSiparislerim.Size = new System.Drawing.Size(150, 40);
            this.btnSiparislerim.TabIndex = 3;
            this.btnSiparislerim.Text = "Siparişlerim";
            this.btnSiparislerim.UseVisualStyleBackColor = true;
            this.btnSiparislerim.Click += new System.EventHandler(this.btnSiparislerim_Click);

            // btnDestekTalepleri
            this.btnDestekTalepleri.Location = new System.Drawing.Point(30, 200);
            this.btnDestekTalepleri.Name = "btnDestekTalepleri";
            this.btnDestekTalepleri.Size = new System.Drawing.Size(150, 40);
            this.btnDestekTalepleri.TabIndex = 4;
            this.btnDestekTalepleri.Text = "Destek Talepleri";
            this.btnDestekTalepleri.UseVisualStyleBackColor = true;
            this.btnDestekTalepleri.Click += new System.EventHandler(this.btnDestekTalepleri_Click);

            // btnCikis
            this.btnCikis.Location = new System.Drawing.Point(200, 200);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 40);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

            // lblKullanici
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.Location = new System.Drawing.Point(30, 20);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(57, 20);
            this.lblKullanici.TabIndex = 6;
            this.lblKullanici.Text = "label1";

            // lblRol
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRol.Location = new System.Drawing.Point(30, 50);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(46, 17);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "label2";

            // btnBakiye
            this.btnBakiye.BackColor = System.Drawing.Color.Gold;
            this.btnBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBakiye.ForeColor = System.Drawing.Color.Black;
            this.btnBakiye.Location = new System.Drawing.Point(30, 260);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(150, 40);
            this.btnBakiye.TabIndex = 8;
            this.btnBakiye.Text = "💰 Bakiye Yükle";
            this.btnBakiye.UseVisualStyleBackColor = false;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);

            // AnaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.btnBakiye);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDestekTalepleri);
            this.Controls.Add(this.btnSiparislerim);
            this.Controls.Add(this.btnSiparisYonetimi);
            this.Controls.Add(this.btnUrunYonetimi);
            this.Controls.Add(this.btnKullaniciYonetimi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albion Market Online - Ana Menü";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnKullaniciYonetimi;
        private System.Windows.Forms.Button btnUrunYonetimi;
        private System.Windows.Forms.Button btnSiparisYonetimi;
        private System.Windows.Forms.Button btnSiparislerim;
        private System.Windows.Forms.Button btnDestekTalepleri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnBakiye;
    }
}