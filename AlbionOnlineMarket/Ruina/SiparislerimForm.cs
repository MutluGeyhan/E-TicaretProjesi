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
    public partial class SiparislerimForm : Form
    {
        private int kullaniciId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public SiparislerimForm(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            SiparisleriYukle();
        }

        private void SiparisleriYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT s.siparis_id, s.siparis_tarihi, s.toplam_fiyat, s.durum " +
                              "FROM Siparisler s WHERE s.kullanici_id = @KullaniciId " +
                              "ORDER BY s.siparis_tarihi DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewSiparisler.DataSource = table;
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridViewSiparisler.SelectedRows.Count > 0)
            {
                int siparisId = Convert.ToInt32(dataGridViewSiparisler.SelectedRows[0].Cells["siparis_id"].Value);
                SiparisDetayForm detayForm = new SiparisDetayForm(siparisId);
                detayForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir sipariş seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}