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
    public partial class KullaniciDuzenleForm : Form
    {
        private int kullaniciId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public KullaniciDuzenleForm(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            KullaniciBilgileriniYukle();
            comboBoxRol.Items.AddRange(new string[] { "admin", "alici", "satici" });
        }

        private void KullaniciBilgileriniYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ad, soyad, email, rol, aktif FROM Kullanicilar WHERE kullanici_id = @KullaniciId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtAd.Text = reader["ad"].ToString();
                    txtSoyad.Text = reader["soyad"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    comboBoxRol.SelectedItem = reader["rol"].ToString();
                    checkBoxAktif.Checked = Convert.ToBoolean(reader["aktif"]);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Kullanicilar SET ad = @Ad, soyad = @Soyad, " +
                              "email = @Email, rol = @Rol, aktif = @Aktif " +
                              "WHERE kullanici_id = @KullaniciId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ad", txtAd.Text);
                command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Rol", comboBoxRol.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Aktif", checkBoxAktif.Checked);
                command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı bilgileri güncellendi!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}