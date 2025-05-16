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
    public partial class SiparisDetayForm : Form
    {
        private int siparisId;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public SiparisDetayForm(int siparisId)
        {
            InitializeComponent();
            this.siparisId = siparisId;
            DetaylariYukle();
        }

        private void DetaylariYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Sipariş bilgileri
                string siparisQuery = "SELECT s.siparis_tarihi, s.toplam_fiyat, s.durum, " +
                                     "k.ad + ' ' + k.soyad AS kullanici " +
                                     "FROM Siparisler s " +
                                     "INNER JOIN Kullanicilar k ON s.kullanici_id = k.kullanici_id " +
                                     "WHERE s.siparis_id = @SiparisId";

                SqlCommand siparisCommand = new SqlCommand(siparisQuery, connection);
                siparisCommand.Parameters.AddWithValue("@SiparisId", siparisId);

                // Sipariş detayları
                string detayQuery = "SELECT u.urun_adi, sd.miktar, sd.birim_fiyat, sd.toplam_fiyat " +
                                    "FROM SiparisDetaylari sd " +
                                    "INNER JOIN Urunler u ON sd.urun_id = u.urun_id " +
                                    "WHERE sd.siparis_id = @SiparisId";

                SqlDataAdapter detayAdapter = new SqlDataAdapter(detayQuery, connection);
                detayAdapter.SelectCommand.Parameters.AddWithValue("@SiparisId", siparisId);
                DataTable detayTable = new DataTable();

                try
                {
                    connection.Open();

                    // Sipariş bilgilerini yükle
                    SqlDataReader reader = siparisCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        lblSiparisNo.Text = "Sipariş No: " + siparisId;
                        lblTarih.Text = "Tarih: " + reader["siparis_tarihi"].ToString();
                        lblToplam.Text = "Toplam: " + reader["toplam_fiyat"].ToString() + " TL";
                        lblDurum.Text = "Durum: " + reader["durum"].ToString();
                        lblKullanici.Text = "Kullanıcı: " + reader["kullanici"].ToString();
                    }
                    reader.Close();

                    // Sipariş detaylarını yükle
                    detayAdapter.Fill(detayTable);
                    dataGridViewDetaylar.DataSource = detayTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}