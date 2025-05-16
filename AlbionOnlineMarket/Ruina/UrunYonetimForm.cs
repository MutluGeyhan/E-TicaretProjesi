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
using Ruina.Extensions;

namespace Ruina
{
    public partial class UrunYonetimForm : Form
    {
        private int kullaniciId;
        private string rol;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public UrunYonetimForm(int kullaniciId, string rol)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.rol = rol;
            UrunleriYukle();
        }

        private void UrunleriYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT u.urun_id, u.urun_adi, u.fiyat, u.stok, k.ad + ' ' + k.soyad AS ekleyen " +
                              "FROM Urunler u INNER JOIN Kullanicilar k ON u.ekleyen_kullanici_id = k.kullanici_id " +
                              "WHERE u.aktif = 1";

                if (rol == "satici")
                {
                    query += " AND u.ekleyen_kullanici_id = @KullaniciId";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                if (rol == "satici")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                }

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewUrunler.DataSource = table;
            }
        }

        private void btnYeniUrun_Click(object sender, EventArgs e)
        {
            UrunEkleForm ekleForm = new UrunEkleForm(kullaniciId);
            if (ekleForm.ShowDialog() == DialogResult.OK)
            {
                UrunleriYukle();
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dataGridViewUrunler.SelectedRows[0].Cells["urun_id"].Value);
                UrunDuzenleForm duzenleForm = new UrunDuzenleForm(urunId);
                if (duzenleForm.ShowDialog() == DialogResult.OK)
                {
                    UrunleriYukle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz ürünü seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count > 0)
            {
                int urunId = Convert.ToInt32(dataGridViewUrunler.SelectedRows[0].Cells["urun_id"].Value);

                DialogResult result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?",
                                                    "Onay",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Urunler SET aktif = 0 WHERE urun_id = @UrunId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UrunId", urunId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün pasif duruma getirildi!");
                        UrunleriYukle();
                    }
                }

            }
        }
        private void UrunYonetimForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewUrunler.SelectedRows[0];
            int urunId = Convert.ToInt32(selectedRow.Cells["urun_id"].Value);
            decimal fiyat = Convert.ToDecimal(selectedRow.Cells["fiyat"].Value);
            int stok = Convert.ToInt32(selectedRow.Cells["stok"].Value);
            string urunAdi = selectedRow.Cells["urun_adi"].Value.ToString();

            if (stok < 1)
            {
                MessageBox.Show($"{urunAdi} ürünü stokta kalmamıştır!", "Stok Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1) Bakiyeyi kontrol et
                            decimal bakiye = (decimal)new SqlCommand(
                                "SELECT bakiye FROM Kullanicilar WHERE kullanici_id = @KullaniciId",
                                connection, transaction)
                                .AddParameter("@KullaniciId", kullaniciId)
                                .ExecuteScalar();

                            if (bakiye < fiyat)
                            {
                                MessageBox.Show($"Yetersiz bakiye! Gerekli: {fiyat:N0} Silver, Mevcut: {bakiye:N0} Silver",
                                              "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }

                            // 2) Bakiyeden düş
                            new SqlCommand(
                                "UPDATE Kullanicilar SET bakiye = bakiye - @Fiyat WHERE kullanici_id = @KullaniciId",
                                connection, transaction)
                                .AddParameter("@Fiyat", fiyat)
                                .AddParameter("@KullaniciId", kullaniciId)
                                .ExecuteNonQuery();

                            // 3) Stoktan düş
                            int affectedRows = new SqlCommand(
                                "UPDATE Urunler SET stok = stok - 1 WHERE urun_id = @UrunId AND stok > 0",
                                connection, transaction)
                                .AddParameter("@UrunId", urunId)
                                .ExecuteNonQuery();

                            if (affectedRows == 0)
                            {
                                throw new Exception("Stok güncellenemedi veya tükenmiş!");
                            }

                            // 4) Sipariş oluştur
                            int siparisId = (int)new SqlCommand(
                                "INSERT INTO Siparisler (kullanici_id, toplam_fiyat) OUTPUT INSERTED.siparis_id VALUES (@KullaniciId, @Fiyat)",
                                connection, transaction)
                                .AddParameter("@KullaniciId", kullaniciId)
                                .AddParameter("@Fiyat", fiyat)
                                .ExecuteScalar();

                            // 5) Sipariş detayı ekle
                            new SqlCommand(
                                "INSERT INTO SiparisDetaylari (siparis_id, urun_id, miktar, birim_fiyat, toplam_fiyat) " +
                                "VALUES (@SiparisId, @UrunId, 1, @Fiyat, @Fiyat)",
                                connection, transaction)
                                .AddParameter("@SiparisId", siparisId)
                                .AddParameter("@UrunId", urunId)
                                .AddParameter("@Fiyat", fiyat)
                                .ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show($"Satın alma başarılı!\nSipariş No: {siparisId}\nÜrün: {urunAdi}\nTutar: {fiyat:N0} Silver");
                            UrunleriYukle();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"İşlem sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Veritabanı hatası: {sqlEx.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen hata: {ex.Message}", "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
        }
