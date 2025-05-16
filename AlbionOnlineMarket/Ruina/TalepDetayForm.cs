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
    public partial class TalepDetayForm : Form
    {
        private int talepId;
        private bool adminYetkisi;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public TalepDetayForm(int talepId, bool adminYetkisi)
        {
            InitializeComponent();
            this.talepId = talepId;
            this.adminYetkisi = adminYetkisi;
            TalepYukle();
        }

        private void TalepYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT t.konu, t.mesaj, t.olusturma_tarihi, t.durum, t.cevap, " +
                              "k.ad + ' ' + k.soyad AS kullanici " +
                              "FROM DestekTalepleri t " +
                              "INNER JOIN Kullanicilar k ON t.kullanici_id = k.kullanici_id " +
                              "WHERE t.talep_id = @TalepId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TalepId", talepId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblTalepNo.Text = "Talep No: " + talepId;
                        lblKonu.Text = "Konu: " + reader["konu"].ToString();
                        lblTarih.Text = "Tarih: " + Convert.ToDateTime(reader["olusturma_tarihi"]).ToString("g");
                        lblDurum.Text = "Durum: " + reader["durum"].ToString();
                        lblKullanici.Text = "Kullanıcı: " + reader["kullanici"].ToString();

                        txtMesaj.Text = reader["mesaj"].ToString();
                        txtCevap.Text = reader["cevap"] != DBNull.Value ? reader["cevap"].ToString() : "";

                        // Admin değilse cevap alanını readonly yap
                        txtCevap.ReadOnly = !adminYetkisi;
                        btnKaydet.Visible = adminYetkisi;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCevap.Text))
            {
                MessageBox.Show("Cevap alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE DestekTalepleri SET cevap = @Cevap, durum = 'Çözüldü', " +
                               "cevaplama_tarihi = GETDATE() WHERE talep_id = @TalepId";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Cevap", txtCevap.Text);
                    command.Parameters.AddWithValue("@TalepId", talepId);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cevap başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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