using Npgsql;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int secilenMusteriID = 0;
        List<SepetUrunu> sepetim = new List<SepetUrunu>();
        private void MusterileriYukle()
        {
            // Ad ve Soyad'ı birleştirip çekiyoruz ki listede tam isim görünsün
            // PostgreSQL'de birleştirme operatörü: ||
            string sorgu = "SELECT MusteriID, Ad || ' ' || Soyad AS AdSoyad FROM Musteriler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, Veritabani.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ComboBox'a ayarları veriyoruz
            cmbMusteriSec.DisplayMember = "AdSoyad";   // Ekranda görünecek sütun
            cmbMusteriSec.ValueMember = "MusteriID";   // Arka planda tutulacak ID (Veritabanı için bu lazım)
            cmbMusteriSec.DataSource = dt;             // Veriyi bağla
        }

        // Ürünleri ComboBox'a yükleyen metot
        private void UrunleriYukle()
        {
            string sorgu = "SELECT UrunID, UrunAdi, SatisFiyati FROM Urunler WHERE StokAdedi > 0"; // Sadece stoğu olanlar gelsin
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, Veritabani.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbUrunSec.DisplayMember = "UrunAdi";
            cmbUrunSec.ValueMember = "UrunID";
            cmbUrunSec.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Test bağlantısı
            var baglanti = Veritabani.Baglan();

            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı Başarılı! Veritabanına bağlandık.");
                baglanti.Close();
            }
            Listele();
            UrunListele();
            MusterileriYukle(); // Satış sekmesindeki kutuyu doldur
            UrunleriYukle();    // Satış sekmesindeki kutuyu doldur
            TaksitleriListele();
            DashboardGuncelle();
            GridSusle(dgwMusteriler);
            GridSusle(dgwUrunler);
            GridSusle(dgwTaksitler);
            GridSusle(dgwSepet);

        }
        private void Temizle()
        {
            txtAd.Clear(); txtSoyad.Clear(); txtTelefon.Clear(); txtAdres.Clear();
            secilenMusteriID = 0; // Seçimi sıfırla
        }
        // Bu metodu butonun dışına, class'ın içine yapıştır
        private void Listele()
        {
            string sorgu = "SELECT * FROM Musteriler ORDER BY MusteriID ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, Veritabani.Baglan());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgwMusteriler.DataSource = tablo;
        }
        private void UrunListele()
        {
            string sorgu = "SELECT * FROM Urunler ORDER BY UrunID ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, Veritabani.Baglan());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgwUrunler.DataSource = tablo;
        }
        private void GridSusle(DataGridView dgw)
        {
            // 1. Genel Ayarlar
            dgw.BorderStyle = BorderStyle.None; // Kenarlık çizgilerini kaldır
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); // Satırlara sırayla açık gri renk ver (Okumayı kolaylaştırır)
            dgw.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Sadece yatay çizgiler olsun
            dgw.DefaultCellStyle.SelectionBackColor = Color.SeaGreen; // Seçilince yeşil olsun (Mavi yerine)
            dgw.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgw.BackgroundColor = Color.White; // Arka plan bembeyaz olsun

            // 2. Başlık Ayarları
            dgw.EnableHeadersVisualStyles = false; // Windows'un standart başlığını kapat
            dgw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgw.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); // Koyu Lacivert Başlık
            dgw.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Başlık yazısı beyaz
            dgw.ColumnHeadersHeight = 40; // Başlık biraz yüksek olsun
            dgw.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Yazı tipi modern olsun

            // 3. Boyutlandırma
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Sütunlar ekrana tam sığsın (Altta kaydırma çubuğu çıkmasın)
            dgw.RowHeadersVisible = false; // En soldaki boş gri kutucuğu gizle
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tıklayınca tüm satırı seçsin
        }
        private void DashboardGuncelle()
        {
            var baglanti = Veritabani.Baglan();

            try
            {
                // 1. Toplam Müşteri Sayısı
                NpgsqlCommand cmd1 = new NpgsqlCommand("SELECT COUNT(*) FROM Musteriler", baglanti);
                var sonuc1 = cmd1.ExecuteScalar();
                lblToplamMusteri.Text = "Toplam Müşteri: " + (sonuc1 != null ? sonuc1.ToString() : "0");

                // 2. Toplam Ciro
                NpgsqlCommand cmd2 = new NpgsqlCommand("SELECT COALESCE(SUM(ToplamTutar), 0) FROM Satislar", baglanti);
                var sonuc2 = cmd2.ExecuteScalar();
                lblToplamCiro.Text = "Toplam Ciro: " + (sonuc2 != null ? sonuc2.ToString() : "0") + " ₺";

                // 3. Kritik Stok
                NpgsqlCommand cmd3 = new NpgsqlCommand("SELECT COUNT(*) FROM Urunler WHERE StokAdedi < 5", baglanti);
                string kritikSayi = cmd3.ExecuteScalar().ToString();
                lblKritikStok.Text = "Kritik Stok: " + kritikSayi + " Ürün";

                if (int.Parse(kritikSayi) > 0) lblKritikStok.ForeColor = Color.Red;
                else lblKritikStok.ForeColor = Color.Black;

                // 4. Grafik Doldurma (GÜNCELLENEN KISIM) 🛠️
                NpgsqlCommand cmdGrafik = new NpgsqlCommand("SELECT UrunAdi, StokAdedi FROM Urunler", baglanti);
                NpgsqlDataReader dr = cmdGrafik.ExecuteReader();

                // Önce grafikteki tüm eski serileri siliyoruz (Hatayı çözen satır)
                chartStoklar.Series.Clear();

                // Yeni bir seri oluşturuyoruz
                var seri = chartStoklar.Series.Add("Stoklar");

                while (dr.Read())
                {
                    // Verileri bu yeni seriye ekliyoruz
                    seri.Points.AddXY(dr["UrunAdi"].ToString(), dr["StokAdedi"]);
                }
                dr.Close(); // Okuyucuyu kapatmayı unutmayalım
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Veritabanı bağlantısını açıyoruz
            var baglanti = Veritabani.Baglan();

            try
            {
                // 2. SQL Ekleme Komutunu Hazırlıyoruz
                // Parametreler (@p1, @p2...) kullanmak güvenlik için önemlidir (SQL Injection'ı önler).
                string sorgu = "INSERT INTO Musteriler (Ad, Soyad, Telefon, Adres) VALUES (@p1, @p2, @p3, @p4)";

                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                // 3. Kutucuklardaki verileri SQL komutuna yüklüyoruz
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtTelefon.Text);
                komut.Parameters.AddWithValue("@p4", txtAdres.Text);

                // 4. Komutu çalıştır (Veritabanına gönder)
                komut.ExecuteNonQuery();

                // 5. Kullanıcıya bilgi ver ve kutuları temizle
                MessageBox.Show("Müşteri başarıyla kaydedildi!");

                // Kutuları temizleyelim ki yeni kayıt için hazır olsun
                txtAd.Clear();
                txtSoyad.Clear();
                txtTelefon.Clear();
                txtAdres.Clear();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // 6. İşimiz bitince bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            var baglanti = Veritabani.Baglan();
            try
            {
                string sorgu = "INSERT INTO Urunler (UrunAdi, Kategori, AlisFiyati, SatisFiyati, StokAdedi) VALUES (@p1, @p2, @p3, @p4, @p5)";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", cmbKategori.Text);

                // Sayısal değerleri dönüştürmemiz lazım (Parse işlemi)
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtAlis.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSatis.Text));
                komut.Parameters.AddWithValue("@p5", int.Parse(numStok.Value.ToString()));

                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün stoğa eklendi!");

                // Temizlik
                txtUrunAd.Clear();
                txtAlis.Clear();
                txtSatis.Clear();

                UrunListele(); 
                DashboardGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! Fiyatlara sadece sayı girdiğinden emin ol.\n" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunSec.SelectedIndex == -1) return;

            // Seçilen ürünün ID'sini ve Adını al
            int secilenUrunID = int.Parse(cmbUrunSec.SelectedValue.ToString());
            string urunAdi = cmbUrunSec.Text;
            int adet = (int)numSatisAdet.Value;

            decimal birimFiyat = 0;

            // --- FİYATI VERİTABANINDAN ÇEKME (EN SAĞLAM YOL) ---
            var baglanti = Veritabani.Baglan();
            try
            {
                // Sadece fiyatı soruyoruz
                NpgsqlCommand komut = new NpgsqlCommand("SELECT SatisFiyati FROM Urunler WHERE UrunID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", secilenUrunID);

                // Gelen sonucu decimal'e çeviriyoruz
                birimFiyat = Convert.ToDecimal(komut.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyat çekilirken hata: " + ex.Message);
                return;
            }
            finally
            {
                baglanti.Close();
            }

            // Listeye Ekle (Artık fiyat kesinlikle doğru)
            sepetim.Add(new SepetUrunu
            {
                UrunID = secilenUrunID,
                UrunAdi = urunAdi,
                Adet = adet,
                BirimFiyat = birimFiyat
            });

            // Sepet Tablosunu Güncelle
            SepetiGuncelle();
        }

        private void SepetiGuncelle()
        {
            dgwSepet.DataSource = null; // Önce sıfırla
            dgwSepet.DataSource = sepetim; // Listeyi bağla

            // Grid Makyajı
            dgwSepet.Columns["UrunID"].Visible = false;
            dgwSepet.Columns["BirimFiyat"].DefaultCellStyle.Format = "C2";
            dgwSepet.Columns["ToplamTutar"].DefaultCellStyle.Format = "C2";

            // Genel Toplamı Hesapla ve Ekrana Yaz
            decimal genelToplam = sepetim.Sum(x => x.ToplamTutar);
            lblHesaplananTutar.Text = genelToplam.ToString("C2"); // Etiketi güncelle
        }
        private void TaksitleriListele()
        {
            // SQL Sorgusunda "AS" kullanarak sütunlara Türkçe takma isim veriyoruz
            string sorgu = @"
        SELECT 
            t.TaksitID,
            m.Ad || ' ' || m.Soyad AS ""Müşteri Adı"",  
            t.VadeTarihi AS ""Son Ödeme Tarihi"",
            t.OdenecekTutar AS ""Tutar""
        FROM Taksitler t
        JOIN Satislar s ON t.SatisID = s.SatisID
        JOIN Musteriler m ON s.MusteriID = m.MusteriID
        WHERE t.Durum = FALSE
        ORDER BY t.VadeTarihi ASC";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, Veritabani.Baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwTaksitler.DataSource = dt;

            // --- Sütun Format Ayarları ---

            // 1. TaksitID sütununu gizleyelim (Kullanıcının görmesine gerek yok, arka planda lazım)
            dgwTaksitler.Columns["TaksitID"].Visible = false;

            // 2. Parayı TL formatında göster (Örn: 200,00 ₺)
            dgwTaksitler.Columns["Tutar"].DefaultCellStyle.Format = "C2";

            // 3. Tarihi sadece gün.ay.yıl olarak göster (Saati gizle)
            dgwTaksitler.Columns["Son Ödeme Tarihi"].DefaultCellStyle.Format = "d";

            // 4. Renklendirme kodunu tekrar çağırıyoruz (Kırmızı yapma özelliği gitmesin)
            foreach (DataGridViewRow satir in dgwTaksitler.Rows)
            {
                if (satir.Cells["Son Ödeme Tarihi"].Value != null)
                {
                    DateTime vade = Convert.ToDateTime(satir.Cells["Son Ödeme Tarihi"].Value);
                    if (vade < DateTime.Now.Date)
                    {
                        satir.DefaultCellStyle.BackColor = Color.Red;
                        satir.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Satış Yap")
            {
                MusterileriYukle(); // Müşteri listesini tazele
                UrunleriYukle();    // Ürün listesini tazele
            }
        }

        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {
            TaksitleriListele();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            if (dgwTaksitler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen listeden ödenecek taksidi seçin!");
                return;
            }

            DialogResult cevap = MessageBox.Show("Bu taksidi tahsil etmek istiyor musunuz?", "Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    // İSİM YERİNE SIRA NUMARASI KULLANDIK (Hata Çıkmaz)
                    int taksitID = Convert.ToInt32(dgwTaksitler.SelectedRows[0].Cells[0].Value);
                    decimal tutar = Convert.ToDecimal(dgwTaksitler.SelectedRows[0].Cells[3].Value);

                    var baglanti = Veritabani.Baglan();

                    // SQL Sütun isimleri küçük harf (odenentutar) olarak ayarlandı
                    string sql = "UPDATE taksitler SET durum = true, odenentutar = @tutar WHERE taksitid = @id";

                    NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@tutar", tutar);
                    komut.Parameters.AddWithValue("@id", taksitID);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ödeme başarıyla alındı.");
                    TaksitleriListele(); // Listeyi yenile
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            // PostgreSQL'de büyük/küçük harf duyarsız arama için "ILIKE" kullanılır.
            // % işareti "ne ile başlarsa başlasın, ne ile biterse bitsin" demektir.
            string sorgu = "SELECT * FROM Musteriler WHERE Ad ILIKE @ara OR Soyad ILIKE @ara";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, Veritabani.Baglan());
            da.SelectCommand.Parameters.AddWithValue("@ara", "%" + txtMusteriAra.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwMusteriler.DataSource = dt;
        }

        // Değişkenler (Yazdırılacak verileri burada tutacağız)
        string yazdir_Musteri = "";
        string yazdir_Urun = "";
        string yazdir_Fiyat = "";
        string yazdir_Tarih = DateTime.Now.ToString();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // --- 1. AYARLAR VE TANIMLAMALAR (Değişkenler burada tanımlanıyor) ---
            int y = 50;
            int x = 50;
            int kagitGenisligi = e.PageBounds.Width;

            // Fontlar (Yazı Tipleri)
            Font baslikFont = new Font("Segoe UI", 18, FontStyle.Bold);
            Font altBaslikFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font icerikFont = new Font("Segoe UI", 10);
            Font kucukFont = new Font("Segoe UI", 8, FontStyle.Italic);

            // Fırça ve Kalemler
            SolidBrush firca = new SolidBrush(Color.Black);
            Pen kalem = new Pen(Color.Black, 1);
            Pen griKalem = new Pen(Color.LightGray, 1);

            // Hizalama
            StringFormat sagaYasla = new StringFormat() { Alignment = StringAlignment.Far };
            StringFormat solaYasla = new StringFormat() { Alignment = StringAlignment.Near };

            // --- 2. ÜST BİLGİ (HEADER) ---
            try
            {
                Image logo = Image.FromFile("logo.png");
                e.Graphics.DrawImage(logo, kagitGenisligi - 150, y, 100, 100);
            }
            catch { } // Logo yoksa devam et

            e.Graphics.DrawString("ALAÇAM MOBİLYA LTD. ŞTİ.", baslikFont, firca, x, y);
            y += 35;
            e.Graphics.DrawString("Millet, Cengizhan Cd. 46B, 16270 Yıldırım/Bursa", icerikFont, firca, x, y);
            y += 20;
            e.Graphics.DrawString("Tel: (537) 725 91 47 | Web: shopier.com/alacammobilya", icerikFont, firca, x, y);
            y += 20;
            e.Graphics.DrawString("Vergi Dairesi: Ankara | VKN: 1234567890", icerikFont, firca, x, y);

            y += 50;
            e.Graphics.DrawLine(kalem, x, y, kagitGenisligi - 50, y);
            y += 10;

            e.Graphics.DrawString("Sayın: " + cmbMusteriSec.Text, altBaslikFont, firca, x, y);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToString("dd.MM.yyyy"), icerikFont, firca, kagitGenisligi - 50, y, sagaYasla);
            y += 10;
            e.Graphics.DrawString("Fiş No: " + new Random().Next(10000, 99999), icerikFont, firca, kagitGenisligi - 50, y + 20, sagaYasla);
            y += 40;

            // --- 3. TABLO BAŞLIĞI ---
            Rectangle kutu = new Rectangle(x, y, kagitGenisligi - 100, 30);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, kutu);
            e.Graphics.DrawRectangle(griKalem, kutu);

            y += 7;
            e.Graphics.DrawString("ÜRÜN ADI", new Font("Segoe UI", 9, FontStyle.Bold), firca, x + 10, y);
            e.Graphics.DrawString("ADET", new Font("Segoe UI", 9, FontStyle.Bold), firca, x + 350, y);
            e.Graphics.DrawString("BİRİM FİYAT", new Font("Segoe UI", 9, FontStyle.Bold), firca, x + 450, y);
            e.Graphics.DrawString("TUTAR", new Font("Segoe UI", 9, FontStyle.Bold), firca, kagitGenisligi - 60, y, sagaYasla);

            y += 40;

            // --- 4. ÜRÜN LİSTESİ (SEPET DÖNGÜSÜ) ---
            // Toplam tutarı hesaplamak için değişken
            decimal genelToplam = 0;

            // Eğer sepet boşsa hata vermesin diye kontrol (Opsiyonel)
            if (sepetim.Count > 0)
            {
                foreach (var urun in sepetim)
                {
                    e.Graphics.DrawString(urun.UrunAdi, icerikFont, firca, x + 10, y);
                    e.Graphics.DrawString(urun.Adet.ToString(), icerikFont, firca, x + 360, y);
                    e.Graphics.DrawString(urun.BirimFiyat.ToString("C2"), icerikFont, firca, x + 450, y);
                    e.Graphics.DrawString(urun.ToplamTutar.ToString("C2"), new Font("Segoe UI", 10, FontStyle.Bold), firca, kagitGenisligi - 60, y, sagaYasla);

                    genelToplam += urun.ToplamTutar; // Toplama ekle
                    y += 25; // Aşağı satıra geç
                }
            }
            else
            {
                // Sepet boşsa tekli satışı yazdıralım (Fallback)
                string urunAdi = cmbUrunSec.Text;
                string adet = numSatisAdet.Value.ToString();
                decimal tutar = decimal.Parse(lblHesaplananTutar.Text.Replace("₺", "").Trim());
                genelToplam = tutar;

                e.Graphics.DrawString(urunAdi, icerikFont, firca, x + 10, y);
                e.Graphics.DrawString(adet, icerikFont, firca, x + 360, y);
                e.Graphics.DrawString((tutar / int.Parse(adet)).ToString("C2"), icerikFont, firca, x + 450, y);
                e.Graphics.DrawString(tutar.ToString("C2"), new Font("Segoe UI", 10, FontStyle.Bold), firca, kagitGenisligi - 60, y, sagaYasla);
                y += 25;
            }

            e.Graphics.DrawLine(griKalem, x, y, kagitGenisligi - 50, y);

            // --- 5. TOPLAM VE ALT BİLGİ ---

            y += 50;

            // GENEL TOPLAM YAZISI
            e.Graphics.DrawString("GENEL TOPLAM", altBaslikFont, firca, kagitGenisligi - 350, y);

            // TUTAR RAKAMI (Hesapladığımız genelToplam değişkenini kullanıyoruz)
            e.Graphics.DrawString(genelToplam.ToString("C2"), new Font("Segoe UI", 14, FontStyle.Bold), firca, kagitGenisligi - 60, y - 5, sagaYasla);

            y += 100;

            // İMZA ALANLARI
            e.Graphics.DrawString("Teslim Eden", icerikFont, firca, x + 50, y);
            e.Graphics.DrawString("Teslim Alan", icerikFont, firca, kagitGenisligi - 150, y);

            y += 40;
            e.Graphics.DrawString("( İmza / Kaşe )", kucukFont, firca, x + 50, y);
            e.Graphics.DrawString("( İmza )", kucukFont, firca, kagitGenisligi - 140, y);

            // DİPNOT
            y = e.PageBounds.Height - 100;
            e.Graphics.DrawLine(kalem, x, y, kagitGenisligi - 50, y);
            y += 10;
            e.Graphics.DrawString("Not: Bu belge fatura yerine geçer. Satılan ürünlerde iade süresi 14 gündür.", kucukFont, firca, x, y);
            e.Graphics.DrawString("Bizi tercih ettiğiniz için teşekkür ederiz!", kucukFont, firca, x, y + 15);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            // Kutulardaki verileri değişkenlere alalım
            if (cmbMusteriSec.Text == "" || cmbUrunSec.Text == "")
            {
                MessageBox.Show("Önce seçim yapmalısınız.");
                return;
            }

            yazdir_Musteri = cmbMusteriSec.Text;
            yazdir_Urun = cmbUrunSec.Text + " (" + numSatisAdet.Value + " Adet)";
            yazdir_Fiyat = lblHesaplananTutar.Text;
            yazdir_Tarih = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            // Yazdırma önizleme penceresini aç
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void txtTaksitAra_TextChanged(object sender, EventArgs e)
        {
            // Müşteri adına göre taksitleri filtrele
            string sorgu = @"
        SELECT 
            t.TaksitID,
            m.Ad || ' ' || m.Soyad AS ""Müşteri Adı"",  
            t.VadeTarihi AS ""Son Ödeme Tarihi"",
            t.OdenecekTutar AS ""Tutar""
        FROM Taksitler t
        JOIN Satislar s ON t.SatisID = s.SatisID
        JOIN Musteriler m ON s.MusteriID = m.MusteriID
        WHERE t.Durum = FALSE AND (m.Ad ILIKE @ara OR m.Soyad ILIKE @ara)
        ORDER BY t.VadeTarihi ASC";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, Veritabani.Baglan());
            da.SelectCommand.Parameters.AddWithValue("@ara", "%" + txtTaksitAra.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwTaksitler.DataSource = dt;

            // Grid tasarımını (gizleme/renklendirme) tekrar uygula
            dgwTaksitler.Columns["TaksitID"].Visible = false;
            dgwTaksitler.Columns["Tutar"].DefaultCellStyle.Format = "C2";
            dgwTaksitler.Columns["Son Ödeme Tarihi"].DefaultCellStyle.Format = "d";
        }

        private void dgwMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlığa tıklanırsa hata vermesin
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki bilgileri al
                DataGridViewRow row = dgwMusteriler.Rows[e.RowIndex];

                // ID'yi değişkene atıyoruz (Silme/Güncelleme için lazım)
                secilenMusteriID = int.Parse(row.Cells["MusteriID"].Value.ToString());

                // Kutuları doldur
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenMusteriID == 0) { MessageBox.Show("Lütfen listeden silinecek müşteriyi seçin."); return; }

            DialogResult cevap = MessageBox.Show("Bu müşteriyi silmek istediğine emin misin?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                var baglanti = Veritabani.Baglan();
                try
                {
                    // Müşteriyi SİL
                    NpgsqlCommand komut = new NpgsqlCommand("DELETE FROM Musteriler WHERE MusteriID=@id", baglanti);
                    komut.Parameters.AddWithValue("@id", secilenMusteriID);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Müşteri silindi.");
                    Temizle(); // Kutuları boşalt
                    Listele(); // Listeyi yenile
                }
                catch (Exception)
                {
                    MessageBox.Show("Bu müşteriye ait satış geçmişi var, silemezsiniz! (Önce satışları silmelisiniz)");
                }
                finally { baglanti.Close(); }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenMusteriID == 0) { MessageBox.Show("Lütfen güncellenecek müşteriyi seçin."); return; }

            var baglanti = Veritabani.Baglan();
            try
            {
                string sql = "UPDATE Musteriler SET Ad=@p1, Soyad=@p2, Telefon=@p3, Adres=@p4 WHERE MusteriID=@id";
                NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtTelefon.Text);
                komut.Parameters.AddWithValue("@p4", txtAdres.Text);
                komut.Parameters.AddWithValue("@id", secilenMusteriID);

                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgiler güncellendi.");
                Temizle();
                Listele();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        private void btnSatisiTamamla_Click(object sender, EventArgs e)
        {
            if (sepetim.Count == 0) { MessageBox.Show("Sepet boş!"); return; }

            var baglanti = Veritabani.Baglan();
            NpgsqlTransaction islem = baglanti.BeginTransaction();

            try
            {
                // 1. ADIM: SATIŞ ANA KAYDI
                decimal sepetGenelToplam = sepetim.Sum(x => x.ToplamTutar);
                int yeniSatisID = 0;

                // DÜZELTME: Sütun isimleri resimdeki gibi bitişik (musteriid) yapıldı.
                // satislar tablosundaki sütunlarının da 'musteriid', 'toplamtutar', 'tarih' olduğunu varsayıyorum.
                string sqlSatis = @"INSERT INTO satislar (musteriid, toplamtutar, tarih) 
                            VALUES (@p1, @p2, @p3) RETURNING satisid";

                using (NpgsqlCommand cmdSatis = new NpgsqlCommand(sqlSatis, baglanti))
                {
                    // Combobox'tan alınan değerin int'e çevrilmesi
                    cmdSatis.Parameters.AddWithValue("@p1", int.Parse(cmbMusteriSec.SelectedValue.ToString()));
                    cmdSatis.Parameters.AddWithValue("@p2", sepetGenelToplam);
                    cmdSatis.Parameters.AddWithValue("@p3", DateTime.Now);

                    yeniSatisID = (int)cmdSatis.ExecuteScalar();
                }

                // 2. ADIM: DETAYLAR VE STOK DÜŞME
                foreach (var urun in sepetim)
                {
                    // DÜZELTME: urunid, satisid bitişik yazıldı.
                    string sqlDetay = @"INSERT INTO satisdetaylari (satisid, urunid, adet, fiyat, toplamtutar) 
                                VALUES (@p1, @p2, @p3, @p4, @p5)";

                    using (NpgsqlCommand cmdDetay = new NpgsqlCommand(sqlDetay, baglanti))
                    {
                        cmdDetay.Parameters.AddWithValue("@p1", yeniSatisID);
                        cmdDetay.Parameters.AddWithValue("@p2", urun.UrunID);
                        cmdDetay.Parameters.AddWithValue("@p3", urun.Adet);
                        cmdDetay.Parameters.AddWithValue("@p4", urun.BirimFiyat);
                        cmdDetay.Parameters.AddWithValue("@p5", urun.ToplamTutar);
                        cmdDetay.ExecuteNonQuery();
                    }

                    // DÜZELTME: 'stokadedi' ve 'urunid' resimdeki gibi bitişik yazıldı.
                    string sqlStok = "UPDATE urunler SET stokadedi = stokadedi - @adet WHERE urunid = @id";
                    using (NpgsqlCommand cmdStok = new NpgsqlCommand(sqlStok, baglanti))
                    {
                        cmdStok.Parameters.AddWithValue("@adet", urun.Adet);
                        cmdStok.Parameters.AddWithValue("@id", urun.UrunID);
                        cmdStok.ExecuteNonQuery();
                    }
                }

                // 3. ADIM: TAKSİTLER
                int taksitSayisi = (int)numTaksitSayisi.Value;
                if (taksitSayisi > 0)
                {
                    decimal aylikTutar = sepetGenelToplam / taksitSayisi;

                    for (int i = 1; i <= taksitSayisi; i++)
                    {
                        // DÜZELTME: satisid, vadetarihi, odenecektutar bitişik yazıldı.
                        string sqlTaksit = @"INSERT INTO taksitler (satisid, vadetarihi, odenecektutar, durum) 
                                     VALUES (@p1, @p2, @p3, @p4)";

                        using (NpgsqlCommand cmdTaksit = new NpgsqlCommand(sqlTaksit, baglanti))
                        {
                            cmdTaksit.Parameters.AddWithValue("@p1", yeniSatisID);
                            cmdTaksit.Parameters.AddWithValue("@p2", DateTime.Now.AddMonths(i));
                            cmdTaksit.Parameters.AddWithValue("@p3", aylikTutar);
                            cmdTaksit.Parameters.AddWithValue("@p4", false);
                            cmdTaksit.ExecuteNonQuery();
                        }
                    }
                }

                islem.Commit();
                MessageBox.Show("Satış başarıyla tamamlandı!");

                btnYazdir.PerformClick();
                sepetim.Clear();
                SepetiGuncelle();
                Listele();
                UrunleriYukle();
                UrunListele();
                // Listeleme fonksiyonlarını buraya ekleyebilirsin
            }
            catch (Exception ex)
            {
                islem.Rollback();
                MessageBox.Show("Hata Detayı:\n" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void dgwMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwTaksitler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwTaksitler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    // Sepete eklenecek ürünün şablonu
    public class SepetUrunu
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamTutar { get { return Adet * BirimFiyat; } } // Otomatik hesaplar
    }
}

