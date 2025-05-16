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
    public partial class KullaniciYonetimForm : Form
    {
        private int kullaniciId;
        private string rol;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public KullaniciYonetimForm(int kullaniciId, string rol)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.rol = rol;
            KullaniciYukle();
        }

        private void KullaniciYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT kullanici_id, ad, soyad, email, rol, aktif FROM Kullanicilar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewKullanicilar.DataSource = table;
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            if (ekleForm.ShowDialog() == DialogResult.OK)
            {
                KullaniciYukle();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.SelectedRows.Count > 0)
            {
                int kullaniciId = Convert.ToInt32(dataGridViewKullanicilar.SelectedRows[0].Cells["kullanici_id"].Value);

                DialogResult result = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?",
                                                    "Onay",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Kullanicilar SET aktif = 0 WHERE kullanici_id = @KullaniciId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı pasif duruma getirildi!");
                        KullaniciYukle();
                    }
                }
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dataGridViewKullanicilar.SelectedRows[0].Cells["kullanici_id"].Value);
                KullaniciDuzenleForm duzenleForm = new KullaniciDuzenleForm(secilenId);
                if (duzenleForm.ShowDialog() == DialogResult.OK)
                {
                    KullaniciYukle();
                }
            }
        }
    }
}