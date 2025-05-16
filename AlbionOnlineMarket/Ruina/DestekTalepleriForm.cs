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
    public partial class DestekTalepleriForm : Form
    {
        private int kullaniciId;
        private string rol;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public DestekTalepleriForm(int kullaniciId, string rol)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.rol = rol;
            TalepYukle();
        }

        private void TalepYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT t.talep_id, t.konu, t.olusturma_tarihi, t.durum, " +
                              "k.ad + ' ' + k.soyad AS kullanici " +
                              "FROM DestekTalepleri t " +
                              "INNER JOIN Kullanicilar k ON t.kullanici_id = k.kullanici_id " +
                              "WHERE (@Rol = 'admin' OR t.kullanici_id = @KullaniciId) " +
                              "ORDER BY t.olusturma_tarihi DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                adapter.SelectCommand.Parameters.AddWithValue("@Rol", rol);

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewTalepler.DataSource = table;
            }
        }

        private void btnYeniTalep_Click(object sender, EventArgs e)
        {
            YeniTalepForm yeniTalepForm = new YeniTalepForm(kullaniciId);
            if (yeniTalepForm.ShowDialog() == DialogResult.OK)
            {
                TalepYukle();
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridViewTalepler.SelectedRows.Count > 0)
            {
                int talepId = Convert.ToInt32(dataGridViewTalepler.SelectedRows[0].Cells["talep_id"].Value);
                TalepDetayForm detayForm = new TalepDetayForm(talepId, rol == "admin");
                detayForm.ShowDialog();
                TalepYukle();
            }
            else
            {
                MessageBox.Show("Lütfen bir talep seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}