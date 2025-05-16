namespace Ruina
{
    partial class SiparisYonetimForm
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
            this.dataGridViewSiparisler = new System.Windows.Forms.DataGridView();
            this.comboBoxDurum = new System.Windows.Forms.ComboBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.btnDetayGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            this.SuspendLayout();

            // dataGridViewSiparisler
            this.dataGridViewSiparisler.AllowUserToAddRows = false;
            this.dataGridViewSiparisler.AllowUserToDeleteRows = false;
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.ReadOnly = true;
            this.dataGridViewSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(700, 300);
            this.dataGridViewSiparisler.TabIndex = 0;

            // comboBoxDurum
            this.comboBoxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDurum.FormattingEnabled = true;
            this.comboBoxDurum.Items.AddRange(new string[] {
            "Hazırlanıyor",
            "Kargoda",
            "Teslim Edildi",
            "İptal Edildi"});
            this.comboBoxDurum.Location = new System.Drawing.Point(20, 340);
            this.comboBoxDurum.Name = "comboBoxDurum";
            this.comboBoxDurum.Size = new System.Drawing.Size(200, 23);
            this.comboBoxDurum.TabIndex = 1;

            // btnDurumGuncelle
            this.btnDurumGuncelle.Location = new System.Drawing.Point(240, 340);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(120, 30);
            this.btnDurumGuncelle.TabIndex = 2;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);

            // btnDetayGoster
            this.btnDetayGoster.Location = new System.Drawing.Point(380, 340);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(120, 30);
            this.btnDetayGoster.TabIndex = 3;
            this.btnDetayGoster.Text = "Detay Göster";
            this.btnDetayGoster.UseVisualStyleBackColor = true;
            this.btnDetayGoster.Click += new System.EventHandler(this.btnDetayGoster_Click);

            // SiparisYonetimForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 391);
            this.Controls.Add(this.btnDetayGoster);
            this.Controls.Add(this.btnDurumGuncelle);   
            this.Controls.Add(this.comboBoxDurum);
            this.Controls.Add(this.dataGridViewSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparisYonetimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.ComboBox comboBoxDurum;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Button btnDetayGoster;
    }
}