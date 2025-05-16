namespace Ruina
{
    partial class UrunDuzenleForm
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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblUrunAdi
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(20, 20);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 15);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı:";

            // txtUrunAdi
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 17);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 23);
            this.txtUrunAdi.TabIndex = 1;

            // lblAciklama
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 50);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(59, 15);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "Açıklama:";

            // txtAciklama
            this.txtAciklama.Location = new System.Drawing.Point(120, 47);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 60);
            this.txtAciklama.TabIndex = 3;

            // lblFiyat
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(20, 120);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 15);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "Fiyat:";

            // txtFiyat
            this.txtFiyat.Location = new System.Drawing.Point(120, 117);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 23);
            this.txtFiyat.TabIndex = 5;

            // lblStok
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(20, 150);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(33, 15);
            this.lblStok.TabIndex = 6;
            this.lblStok.Text = "Stok:";

            // txtStok
            this.txtStok.Location = new System.Drawing.Point(120, 147);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(200, 23);
            this.txtStok.TabIndex = 7;

            // checkBoxAktif
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(120, 180);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(50, 19);
            this.checkBoxAktif.TabIndex = 8;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(120, 210);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 30);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // UrunDuzenleForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.Button btnKaydet;
    }
}