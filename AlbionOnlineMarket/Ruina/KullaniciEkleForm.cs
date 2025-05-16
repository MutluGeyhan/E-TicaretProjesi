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
    public partial class KullaniciEkleForm : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public KullaniciEkleForm()
        {
            InitializeComponent();
            comboBoxRol.Items.AddRange(new string[] { "admin", "alici", "satici" });
            comboBoxRol.SelectedIndex = 1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kullanicilar (ad, soyad, email, sifre, rol) VALUES (@Ad, @Soyad, @Email, @Sifre, @Rol)";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", txtAd.Text);
                    command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    command.Parameters.AddWithValue("@Rol", comboBoxRol.SelectedItem.ToString());

                    command.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}