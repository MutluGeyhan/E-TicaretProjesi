namespace Ruina
{
    partial class BakiyeYuklemeForm
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
            this.lblMevcutBakiye = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblMevcutBakiye
            this.lblMevcutBakiye.AutoSize = true;
            this.lblMevcutBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMevcutBakiye.Location = new System.Drawing.Point(20, 20);
            this.lblMevcutBakiye.Name = "lblMevcutBakiye";
            this.lblMevcutBakiye.Size = new System.Drawing.Size(120, 17);
            this.lblMevcutBakiye.TabIndex = 0;
            this.lblMevcutBakiye.Text = "Mevcut Bakiye:";

            // txtMiktar
            this.txtMiktar.Location = new System.Drawing.Point(20, 60);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(200, 23);
            this.txtMiktar.TabIndex = 1;

            // btnYukle
            this.btnYukle.Location = new System.Drawing.Point(20, 100);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(200, 30);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "Silver Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yüklenecek Miktar:";

            // BakiyeYuklemeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblMevcutBakiye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BakiyeYuklemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakiye Yükle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMevcutBakiye;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
    }
}