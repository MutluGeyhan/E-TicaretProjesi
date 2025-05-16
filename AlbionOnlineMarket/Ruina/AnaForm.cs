using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ruina
{
    public partial class AnaForm : Form
    {
        private int kullaniciId;
        private string rol;
        private string kullaniciAdi;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Albion_Market_Online;Trusted_Connection=True;";

        public AnaForm(int kullaniciId, string rol, string kullaniciAdi)
        {
                InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.rol = rol;
            this.kullaniciAdi = kullaniciAdi;

            lblKullanici.Text = kullaniciAdi;
            lblRol.Text = "Rol: " + rol;

            RolYetkilendirme();
        }

        private void RolYetkilendirme()
        {
            switch (rol)
            {
                case "admin":
                    btnKullaniciYonetimi.Visible = true;
                    btnUrunYonetimi.Visible = true;
                    btnSiparisYonetimi.Visible = true;
                    btnSiparislerim.Visible = true;
                    btnDestekTalepleri.Visible = true;
                    break;

                case "satici":
                    btnKullaniciYonetimi.Visible = false;
                    btnUrunYonetimi.Visible = true;
                    btnSiparisYonetimi.Visible = true;
                    btnSiparislerim.Visible = false;
                    btnDestekTalepleri.Visible = true;
                    break;

                case "alici":
                    btnKullaniciYonetimi.Visible = false;
                    btnUrunYonetimi.Visible = false;
                    btnSiparisYonetimi.Visible = false;
                    btnSiparislerim.Visible = true;
                    btnDestekTalepleri.Visible = true;
                    break;
            }
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            KullaniciYonetimForm kullaniciForm = new KullaniciYonetimForm(kullaniciId, rol);
            kullaniciForm.ShowDialog();
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            UrunYonetimForm urunForm = new UrunYonetimForm(kullaniciId, rol);
            urunForm.ShowDialog();
        }

        private void btnSiparisYonetimi_Click(object sender, EventArgs e)
        {
            SiparisYonetimForm siparisForm = new SiparisYonetimForm(kullaniciId, rol);
            siparisForm.ShowDialog();
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            SiparislerimForm siparislerimForm = new SiparislerimForm(kullaniciId);
            siparislerimForm.ShowDialog();
        }

        private void btnDestekTalepleri_Click(object sender, EventArgs e)
        {
            DestekTalepleriForm destekForm = new DestekTalepleriForm(kullaniciId, rol);
            destekForm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBakiye_Click(object sender, EventArgs e)
        {
            BakiyeYuklemeForm bakiyeForm = new BakiyeYuklemeForm(kullaniciId);
            bakiyeForm.ShowDialog();
        }
    }
}