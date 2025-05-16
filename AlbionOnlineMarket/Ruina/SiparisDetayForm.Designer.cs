namespace Ruina
{
    partial class SiparisDetayForm
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
            this.lblSiparisNo = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.dataGridViewDetaylar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetaylar)).BeginInit();
            this.SuspendLayout();

            // lblSiparisNo
            this.lblSiparisNo.AutoSize = true;
            this.lblSiparisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisNo.Location = new System.Drawing.Point(20, 20);
            this.lblSiparisNo.Name = "lblSiparisNo";
            this.lblSiparisNo.Size = new System.Drawing.Size(52, 17);
            this.lblSiparisNo.TabIndex = 0;
            this.lblSiparisNo.Text = "label1";

            // lblTarih
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(20, 50);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 15);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "label2";

            // lblToplam
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(20, 80);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(38, 15);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "label3";

            // lblDurum
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 110);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(38, 15);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "label4";

            // lblKullanici
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(20, 140);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(38, 15);
            this.lblKullanici.TabIndex = 4;
            this.lblKullanici.Text = "label5";

            // dataGridViewDetaylar
            this.dataGridViewDetaylar.AllowUserToAddRows = false;
            this.dataGridViewDetaylar.AllowUserToDeleteRows = false;
            this.dataGridViewDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetaylar.Location = new System.Drawing.Point(20, 170);
            this.dataGridViewDetaylar.Name = "dataGridViewDetaylar";
            this.dataGridViewDetaylar.ReadOnly = true;
            this.dataGridViewDetaylar.RowTemplate.Height = 25;
            this.dataGridViewDetaylar.Size = new System.Drawing.Size(540, 200);
            this.dataGridViewDetaylar.TabIndex = 5;

            // SiparisDetayForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.dataGridViewDetaylar);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSiparisNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparisDetayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Detayları";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSiparisNo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.DataGridView dataGridViewDetaylar;
    }
}