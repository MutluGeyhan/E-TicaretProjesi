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
    public partial class UrunDuzenleForm : Form
    {
        private int urunId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public UrunDuzenleForm(int urunId)
        {
            InitializeComponent();
            this.urunId = urunId;
            UrunBilgileriniYukle();
        }

        private void UrunBilgileriniYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT urun_adi, aciklama, fiyat, stok, aktif FROM Urunler WHERE urun_id = @UrunId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UrunId", urunId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtUrunAdi.Text = reader["urun_adi"].ToString();
                    txtAciklama.Text = reader["aciklama"].ToString();
                    txtFiyat.Text = reader["fiyat"].ToString();
                    txtStok.Text = reader["stok"].ToString();
                    checkBoxAktif.Checked = Convert.ToBoolean(reader["aktif"]);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat) || !int.TryParse(txtStok.Text, out int stok))
            {
                MessageBox.Show("Geçersiz fiyat veya stok değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Urunler SET " +
                               "urun_adi = @UrunAdi, " +
                               "aciklama = @Aciklama, " +
                               "fiyat = @Fiyat, " +
                               "stok = @Stok, " +
                               "aktif = @Aktif " +
                               "WHERE urun_id = @UrunId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                command.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                command.Parameters.AddWithValue("@Fiyat", fiyat);
                command.Parameters.AddWithValue("@Stok", stok);
                command.Parameters.AddWithValue("@Aktif", checkBoxAktif.Checked);
                command.Parameters.AddWithValue("@UrunId", urunId);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün bilgileri güncellendi!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}