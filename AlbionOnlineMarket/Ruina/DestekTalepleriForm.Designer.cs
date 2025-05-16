namespace Ruina
{
    partial class DestekTalepleriForm
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
            this.dataGridViewTalepler = new System.Windows.Forms.DataGridView();
            this.btnYeniTalep = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalepler)).BeginInit();
            this.SuspendLayout();

            // dataGridViewTalepler
            this.dataGridViewTalepler.AllowUserToAddRows = false;
            this.dataGridViewTalepler.AllowUserToDeleteRows = false;
            this.dataGridViewTalepler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTalepler.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewTalepler.Name = "dataGridViewTalepler";
            this.dataGridViewTalepler.ReadOnly = true;
            this.dataGridViewTalepler.RowTemplate.Height = 25;
            this.dataGridViewTalepler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTalepler.Size = new System.Drawing.Size(640, 250);
            this.dataGridViewTalepler.TabIndex = 0;

            // btnYeniTalep
            this.btnYeniTalep.Location = new System.Drawing.Point(20, 280);
            this.btnYeniTalep.Name = "btnYeniTalep";
            this.btnYeniTalep.Size = new System.Drawing.Size(100, 30);
            this.btnYeniTalep.TabIndex = 1;
            this.btnYeniTalep.Text = "Yeni Talep";
            this.btnYeniTalep.UseVisualStyleBackColor = true;
            this.btnYeniTalep.Click += new System.EventHandler(this.btnYeniTalep_Click);

            // btnDetay
            this.btnDetay.Location = new System.Drawing.Point(560, 280);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(100, 30);
            this.btnDetay.TabIndex = 2;
            this.btnDetay.Text = "Detay Göster";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);

            // DestekTalepleriForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 321);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnYeniTalep);
            this.Controls.Add(this.dataGridViewTalepler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DestekTalepleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destek Talepleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalepler)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewTalepler;
        private System.Windows.Forms.Button btnYeniTalep;
        private System.Windows.Forms.Button btnDetay;
    }
}