namespace Ruina
{
    partial class SiparislerimForm
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
            this.btnDetay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            this.SuspendLayout();

            // dataGridViewSiparisler
            this.dataGridViewSiparisler.AllowUserToAddRows = false;
            this.dataGridViewSiparisler.AllowUserToDeleteRows = false;
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.ReadOnly = true;
            this.dataGridViewSiparisler.RowTemplate.Height = 25;
            this.dataGridViewSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(540, 250);
            this.dataGridViewSiparisler.TabIndex = 0;

            // btnDetay
            this.btnDetay.Location = new System.Drawing.Point(460, 280);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(100, 30);
            this.btnDetay.TabIndex = 1;
            this.btnDetay.Text = "Detay Göster";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);

            // SiparislerimForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.dataGridViewSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparislerimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişlerim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.Button btnDetay;
    }
}