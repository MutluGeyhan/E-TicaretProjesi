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
    public partial class YeniTalepForm : Form
    {
        private int kullaniciId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public YeniTalepForm(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKonu.Text) || string.IsNullOrEmpty(txtMesaj.Text))
            {
                MessageBox.Show("Konu ve mesaj alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DestekTalepleri (kullanici_id, konu, mesaj) " +
                              "VALUES (@KullaniciId, @Konu, @Mesaj)";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                    command.Parameters.AddWithValue("@Konu", txtKonu.Text);
                    command.Parameters.AddWithValue("@Mesaj", txtMesaj.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Talebiniz başarıyla gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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