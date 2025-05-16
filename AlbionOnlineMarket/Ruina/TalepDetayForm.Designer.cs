namespace Ruina
{
    partial class TalepDetayForm
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
        this.lblTalepNo = new System.Windows.Forms.Label();
        this.lblKonu = new System.Windows.Forms.Label();
        this.lblTarih = new System.Windows.Forms.Label();
        this.lblDurum = new System.Windows.Forms.Label();
        this.lblKullanici = new System.Windows.Forms.Label();
        this.txtMesaj = new System.Windows.Forms.TextBox();
        this.txtCevap = new System.Windows.Forms.TextBox();
        this.lblMesaj = new System.Windows.Forms.Label();
        this.lblCevap = new System.Windows.Forms.Label();
        this.btnKaydet = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblTalepNo
        this.lblTalepNo.AutoSize = true;
        this.lblTalepNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.lblTalepNo.Location = new System.Drawing.Point(20, 20);
        this.lblTalepNo.Name = "lblTalepNo";
        this.lblTalepNo.Size = new System.Drawing.Size(52, 17);
        this.lblTalepNo.TabIndex = 0;
        this.lblTalepNo.Text = "label1";

        // lblKonu
        this.lblKonu.AutoSize = true;
        this.lblKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.lblKonu.Location = new System.Drawing.Point(20, 50);
        this.lblKonu.Name = "lblKonu";
        this.lblKonu.Size = new System.Drawing.Size(41, 15);
        this.lblKonu.TabIndex = 1;
        this.lblKonu.Text = "label2";

        // lblTarih
        this.lblTarih.AutoSize = true;
        this.lblTarih.Location = new System.Drawing.Point(20, 80);
        this.lblTarih.Name = "lblTarih";
        this.lblTarih.Size = new System.Drawing.Size(38, 15);
        this.lblTarih.TabIndex = 2;
        this.lblTarih.Text = "label3";

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

        // txtMesaj
        this.txtMesaj.Location = new System.Drawing.Point(20, 170);
        this.txtMesaj.Multiline = true;
        this.txtMesaj.Name = "txtMesaj";
        this.txtMesaj.ReadOnly = true;
        this.txtMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtMesaj.Size = new System.Drawing.Size(500, 100);
        this.txtMesaj.TabIndex = 5;

        // txtCevap
        this.txtCevap.Location = new System.Drawing.Point(20, 300);
        this.txtCevap.Multiline = true;
        this.txtCevap.Name = "txtCevap";
        this.txtCevap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtCevap.Size = new System.Drawing.Size(500, 100);
        this.txtCevap.TabIndex = 6;

        // lblMesaj
        this.lblMesaj.AutoSize = true;
        this.lblMesaj.Location = new System.Drawing.Point(20, 150);
        this.lblMesaj.Name = "lblMesaj";
        this.lblMesaj.Size = new System.Drawing.Size(85, 15);
        this.lblMesaj.TabIndex = 7;
        this.lblMesaj.Text = "Kullanıcı Mesajı:";

        // lblCevap
        this.lblCevap.AutoSize = true;
        this.lblCevap.Location = new System.Drawing.Point(20, 280);
        this.lblCevap.Name = "lblCevap";
        this.lblCevap.Size = new System.Drawing.Size(42, 15);
        this.lblCevap.TabIndex = 8;
        this.lblCevap.Text = "Cevap:";

        // btnKaydet
        this.btnKaydet.Location = new System.Drawing.Point(420, 410);
        this.btnKaydet.Name = "btnKaydet";
        this.btnKaydet.Size = new System.Drawing.Size(100, 30);
        this.btnKaydet.TabIndex = 9;
        this.btnKaydet.Text = "Kaydet";
        this.btnKaydet.UseVisualStyleBackColor = true;
        this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

        // TalepDetayForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(544, 451);
        this.Controls.Add(this.btnKaydet);
        this.Controls.Add(this.lblCevap);
        this.Controls.Add(this.lblMesaj);
        this.Controls.Add(this.txtCevap);
        this.Controls.Add(this.txtMesaj);
        this.Controls.Add(this.lblKullanici);
        this.Controls.Add(this.lblDurum);
        this.Controls.Add(this.lblTarih);
        this.Controls.Add(this.lblKonu);
        this.Controls.Add(this.lblTalepNo);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "TalepDetayForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Talep Detayları";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTalepNo;
    private System.Windows.Forms.Label lblKonu;
    private System.Windows.Forms.Label lblTarih;
    private System.Windows.Forms.Label lblDurum;
    private System.Windows.Forms.Label lblKullanici;
    private System.Windows.Forms.TextBox txtMesaj;
    private System.Windows.Forms.TextBox txtCevap;
    private System.Windows.Forms.Label lblMesaj;
    private System.Windows.Forms.Label lblCevap;
    private System.Windows.Forms.Button btnKaydet;
}
}