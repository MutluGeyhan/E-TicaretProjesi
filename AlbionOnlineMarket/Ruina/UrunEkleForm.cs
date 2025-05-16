using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ruina
{
    public partial class UrunEkleForm : Form
    {
        private int kullaniciId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public UrunEkleForm(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) ||
                string.IsNullOrEmpty(txtStok.Text))
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat) || !int.TryParse(txtStok.Text, out int stok))
            {
                MessageBox.Show("Geçersiz fiyat veya stok değeri!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Urunler (urun_adi, aciklama, fiyat, stok, ekleyen_kullanici_id) " +
                              "VALUES (@UrunAdi, @Aciklama, @Fiyat, @Stok, @KullaniciId)";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                    command.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    command.Parameters.AddWithValue("@Fiyat", fiyat);
                    command.Parameters.AddWithValue("@Stok", stok);
                    command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}