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
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Email ve şifre alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT kullanici_id, ad, soyad, rol FROM Kullanicilar WHERE email=@Email AND sifre=@Sifre AND aktif=1";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Sifre", sifre);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int kullaniciId = reader.GetInt32(0);
                        string ad = reader.GetString(1);
                        string soyad = reader.GetString(2);
                        string rol = reader.GetString(3);

                        this.Hide();
                        AnaForm anaForm = new AnaForm(kullaniciId, rol, ad + " " + soyad);
                        anaForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz email veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.ShowDialog();
        }
    }
}