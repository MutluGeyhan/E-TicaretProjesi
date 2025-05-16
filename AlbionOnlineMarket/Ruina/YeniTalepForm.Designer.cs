namespace Ruina
{
    partial class YeniTalepForm
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
            this.lblKonu = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblKonu
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(20, 20);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(36, 15);
            this.lblKonu.TabIndex = 0;
            this.lblKonu.Text = "Konu:";

            // txtKonu
            this.txtKonu.Location = new System.Drawing.Point(20, 40);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(400, 23);
            this.txtKonu.TabIndex = 1;

            // lblMesaj
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(20, 80);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(39, 15);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Mesaj:";

            // txtMesaj
            this.txtMesaj.Location = new System.Drawing.Point(20, 100);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(400, 150);
            this.txtMesaj.TabIndex = 3;

            // btnGonder
            this.btnGonder.Location = new System.Drawing.Point(320, 260);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 30);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);

            // YeniTalepForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.lblKonu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YeniTalepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Destek Talebi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnGonder;
    }
}