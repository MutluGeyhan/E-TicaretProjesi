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
    public partial class SiparisYonetimForm : Form
    {
        private int kullaniciId;
        private string rol;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public SiparisYonetimForm(int kullaniciId, string rol)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.rol = rol;
            SiparisleriYukle();
        }

        private void SiparisleriYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT s.siparis_id, k.ad + ' ' + k.soyad AS musteri, " +
                               "s.siparis_tarihi, s.toplam_fiyat, s.durum " +
                               "FROM Siparisler s " +
                               "INNER JOIN Kullanicilar k ON s.kullanici_id = k.kullanici_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSiparisler.DataSource = table;
            }
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSiparisler.SelectedRows.Count > 0)
            {
                int siparisId = Convert.ToInt32(dataGridViewSiparisler.SelectedRows[0].Cells["siparis_id"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Siparisler SET durum = @Durum WHERE siparis_id = @SiparisId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Durum", comboBoxDurum.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@SiparisId", siparisId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sipariş durumu güncellendi!");
                    SiparisleriYukle();
                }
            }
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            if (dataGridViewSiparisler.SelectedRows.Count > 0)
            {
                int siparisId = Convert.ToInt32(dataGridViewSiparisler.SelectedRows[0].Cells["siparis_id"].Value);
                SiparisDetayForm detayForm = new SiparisDetayForm(siparisId);
                detayForm.ShowDialog();
            }
        }
    }
}