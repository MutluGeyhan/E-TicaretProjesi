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
    public partial class BakiyeYuklemeForm : Form
    {
        private int kullaniciId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_MarketOnline;Trusted_Connection=True;";

        public BakiyeYuklemeForm(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            lblMevcutBakiye.Text = $"Mevcut Bakiye: {BakiyeGetir():N0} Silver";
        }

        private decimal BakiyeGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT bakiye FROM Kullanicilar WHERE kullanici_id = @KullaniciId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                connection.Open();
                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMiktar.Text, out decimal miktar) && miktar > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Kullanicilar SET bakiye = bakiye + @Miktar WHERE kullanici_id = @KullaniciId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Miktar", miktar);
                    command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show($"{miktar:N0} Silver yüklendi!\nYeni Bakiye: {BakiyeGetir():N0} Silver");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Geçersiz miktar!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}