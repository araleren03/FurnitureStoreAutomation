using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilyaOtomasyonu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Basitçe kod içine gömüyoruz (Okul projesi için yeterli)
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "12345")
            {
                Form1 anaSayfa = new Form1();
                anaSayfa.Show(); // Ana sayfayı aç
                this.Hide();     // Giriş ekranını gizle
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            }
        }
    }
}
