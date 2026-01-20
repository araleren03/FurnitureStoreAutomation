namespace MobilyaOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartStoklar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblKritikStok = new System.Windows.Forms.Label();
            this.lblToplamCiro = new System.Windows.Forms.Label();
            this.lblToplamMusteri = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.lblSatis = new System.Windows.Forms.Label();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.lblAlis = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSatisiTamamla = new System.Windows.Forms.Button();
            this.dgwSepet = new System.Windows.Forms.DataGridView();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lblHesaplananTutar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.numTaksitSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.numSatisAdet = new System.Windows.Forms.NumericUpDown();
            this.lblAdet = new System.Windows.Forms.Label();
            this.cmbUrunSec = new System.Windows.Forms.ComboBox();
            this.lblSecilenUrun = new System.Windows.Forms.Label();
            this.cmbMusteriSec = new System.Windows.Forms.ComboBox();
            this.lblSecilenMusteri = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTaksitAra = new System.Windows.Forms.TextBox();
            this.lblTaksitArama = new System.Windows.Forms.Label();
            this.btnTumunuGoster = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.dgwTaksitler = new System.Windows.Forms.DataGridView();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStoklar)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaksitSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisAdet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaksitler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 624);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.pictureBox2);
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.chartStoklar);
            this.tabPage5.Controls.Add(this.lblKritikStok);
            this.tabPage5.Controls.Add(this.lblToplamCiro);
            this.tabPage5.Controls.Add(this.lblToplamMusteri);
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(889, 583);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Ana Sayfa";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 32);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // chartStoklar
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStoklar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStoklar.Legends.Add(legend1);
            this.chartStoklar.Location = new System.Drawing.Point(400, 7);
            this.chartStoklar.Name = "chartStoklar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStoklar.Series.Add(series1);
            this.chartStoklar.Size = new System.Drawing.Size(448, 515);
            this.chartStoklar.TabIndex = 3;
            this.chartStoklar.Text = "chart1";
            // 
            // lblKritikStok
            // 
            this.lblKritikStok.AutoSize = true;
            this.lblKritikStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKritikStok.Location = new System.Drawing.Point(58, 139);
            this.lblKritikStok.Name = "lblKritikStok";
            this.lblKritikStok.Size = new System.Drawing.Size(98, 32);
            this.lblKritikStok.TabIndex = 2;
            this.lblKritikStok.Text = "label3";
            // 
            // lblToplamCiro
            // 
            this.lblToplamCiro.AutoSize = true;
            this.lblToplamCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCiro.Location = new System.Drawing.Point(58, 82);
            this.lblToplamCiro.Name = "lblToplamCiro";
            this.lblToplamCiro.Size = new System.Drawing.Size(98, 32);
            this.lblToplamCiro.TabIndex = 1;
            this.lblToplamCiro.Text = "label2";
            // 
            // lblToplamMusteri
            // 
            this.lblToplamMusteri.AutoSize = true;
            this.lblToplamMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMusteri.Location = new System.Drawing.Point(58, 24);
            this.lblToplamMusteri.Name = "lblToplamMusteri";
            this.lblToplamMusteri.Size = new System.Drawing.Size(98, 32);
            this.lblToplamMusteri.TabIndex = 0;
            this.lblToplamMusteri.Text = "label1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.txtMusteriAra);
            this.tabPage1.Controls.Add(this.dgwMusteriler);
            this.tabPage1.Controls.Add(this.btnKaydet);
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.lblAdres);
            this.tabPage1.Controls.Add(this.lblTelefon);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.lblSoyad);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.lblAd);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 583);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Müşteriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.Location = new System.Drawing.Point(148, 465);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 66);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(148, 374);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 66);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(99, 182);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(221, 34);
            this.txtTelefon.TabIndex = 21;
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(337, 36);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(435, 34);
            this.txtMusteriAra.TabIndex = 20;
            this.txtMusteriAra.TextChanged += new System.EventHandler(this.txtMusteriAra_TextChanged);
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.Location = new System.Drawing.Point(337, 86);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.RowHeadersWidth = 51;
            this.dgwMusteriler.RowTemplate.Height = 24;
            this.dgwMusteriler.Size = new System.Drawing.Size(434, 476);
            this.dgwMusteriler.TabIndex = 19;
            this.dgwMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellClick);
            this.dgwMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellContentClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(148, 288);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(123, 66);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Müşteri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(99, 228);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(221, 33);
            this.txtAdres.TabIndex = 17;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(29, 232);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(66, 28);
            this.lblAdres.TabIndex = 16;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(16, 185);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(78, 28);
            this.lblTelefon.TabIndex = 14;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(99, 132);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(221, 34);
            this.txtSoyad.TabIndex = 13;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(25, 136);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(71, 28);
            this.lblSoyad.TabIndex = 12;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 86);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(221, 34);
            this.txtAd.TabIndex = 11;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(54, 90);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(41, 28);
            this.lblAd.TabIndex = 10;
            this.lblAd.Text = "Ad:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgwUrunler);
            this.tabPage2.Controls.Add(this.btnUrunKaydet);
            this.tabPage2.Controls.Add(this.numStok);
            this.tabPage2.Controls.Add(this.lblStok);
            this.tabPage2.Controls.Add(this.txtSatis);
            this.tabPage2.Controls.Add(this.lblSatis);
            this.tabPage2.Controls.Add(this.txtAlis);
            this.tabPage2.Controls.Add(this.lblAlis);
            this.tabPage2.Controls.Add(this.cmbKategori);
            this.tabPage2.Controls.Add(this.txtUrunAd);
            this.tabPage2.Controls.Add(this.lblKategori);
            this.tabPage2.Controls.Add(this.lblUrunAd);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Location = new System.Drawing.Point(388, 25);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.RowHeadersWidth = 51;
            this.dgwUrunler.RowTemplate.Height = 24;
            this.dgwUrunler.Size = new System.Drawing.Size(427, 484);
            this.dgwUrunler.TabIndex = 11;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(149, 286);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(136, 72);
            this.btnUrunKaydet.TabIndex = 10;
            this.btnUrunKaydet.Text = "Ürünü Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // numStok
            // 
            this.numStok.Location = new System.Drawing.Point(126, 226);
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(110, 34);
            this.numStok.TabIndex = 9;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(8, 232);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(112, 28);
            this.lblStok.TabIndex = 8;
            this.lblStok.Text = "Stok Adedi:";
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(126, 181);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(217, 34);
            this.txtSatis.TabIndex = 7;
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(6, 181);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(109, 28);
            this.lblSatis.TabIndex = 6;
            this.lblSatis.Text = "Satış Fiyatı:";
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(126, 134);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(217, 34);
            this.txtAlis.TabIndex = 5;
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(16, 134);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(99, 28);
            this.lblAlis.TabIndex = 4;
            this.lblAlis.Text = "Alış Fiyatı:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Koltuk",
            "Yatak",
            "Masa"});
            this.cmbKategori.Location = new System.Drawing.Point(126, 84);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(217, 36);
            this.cmbKategori.TabIndex = 3;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(126, 28);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(217, 34);
            this.txtUrunAd.TabIndex = 2;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(26, 84);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(91, 28);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(26, 28);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(94, 28);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "Ürün Adı:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSatisiTamamla);
            this.tabPage3.Controls.Add(this.dgwSepet);
            this.tabPage3.Controls.Add(this.btnYazdir);
            this.tabPage3.Controls.Add(this.btnSepeteEkle);
            this.tabPage3.Controls.Add(this.lblHesaplananTutar);
            this.tabPage3.Controls.Add(this.lblToplam);
            this.tabPage3.Controls.Add(this.numTaksitSayisi);
            this.tabPage3.Controls.Add(this.lblTaksit);
            this.tabPage3.Controls.Add(this.numSatisAdet);
            this.tabPage3.Controls.Add(this.lblAdet);
            this.tabPage3.Controls.Add(this.cmbUrunSec);
            this.tabPage3.Controls.Add(this.lblSecilenUrun);
            this.tabPage3.Controls.Add(this.cmbMusteriSec);
            this.tabPage3.Controls.Add(this.lblSecilenMusteri);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(889, 583);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Satış Yap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSatisiTamamla
            // 
            this.btnSatisiTamamla.Location = new System.Drawing.Point(376, 277);
            this.btnSatisiTamamla.Name = "btnSatisiTamamla";
            this.btnSatisiTamamla.Size = new System.Drawing.Size(127, 69);
            this.btnSatisiTamamla.TabIndex = 13;
            this.btnSatisiTamamla.Text = "Sepeti Onayla";
            this.btnSatisiTamamla.UseVisualStyleBackColor = true;
            this.btnSatisiTamamla.Click += new System.EventHandler(this.btnSatisiTamamla_Click);
            // 
            // dgwSepet
            // 
            this.dgwSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSepet.Location = new System.Drawing.Point(522, 25);
            this.dgwSepet.Name = "dgwSepet";
            this.dgwSepet.RowHeadersWidth = 51;
            this.dgwSepet.RowTemplate.Height = 24;
            this.dgwSepet.Size = new System.Drawing.Size(333, 398);
            this.dgwSepet.TabIndex = 12;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(376, 202);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(127, 69);
            this.btnSepeteEkle.TabIndex = 10;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lblHesaplananTutar
            // 
            this.lblHesaplananTutar.AutoSize = true;
            this.lblHesaplananTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesaplananTutar.Location = new System.Drawing.Point(173, 202);
            this.lblHesaplananTutar.Name = "lblHesaplananTutar";
            this.lblHesaplananTutar.Size = new System.Drawing.Size(83, 29);
            this.lblHesaplananTutar.TabIndex = 9;
            this.lblHesaplananTutar.Text = "0.00 ₺";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(8, 205);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(155, 28);
            this.lblToplam.TabIndex = 8;
            this.lblToplam.Text = "TOPLAM TUTAR:";
            // 
            // numTaksitSayisi
            // 
            this.numTaksitSayisi.Location = new System.Drawing.Point(132, 161);
            this.numTaksitSayisi.Name = "numTaksitSayisi";
            this.numTaksitSayisi.Size = new System.Drawing.Size(126, 34);
            this.numTaksitSayisi.TabIndex = 7;
            this.numTaksitSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Location = new System.Drawing.Point(8, 161);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(118, 28);
            this.lblTaksit.TabIndex = 6;
            this.lblTaksit.Text = "Taksit Sayısı:";
            // 
            // numSatisAdet
            // 
            this.numSatisAdet.Location = new System.Drawing.Point(132, 113);
            this.numSatisAdet.Name = "numSatisAdet";
            this.numSatisAdet.Size = new System.Drawing.Size(126, 34);
            this.numSatisAdet.TabIndex = 5;
            this.numSatisAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(72, 115);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(58, 28);
            this.lblAdet.TabIndex = 4;
            this.lblAdet.Text = "Adet:";
            // 
            // cmbUrunSec
            // 
            this.cmbUrunSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunSec.FormattingEnabled = true;
            this.cmbUrunSec.Location = new System.Drawing.Point(132, 69);
            this.cmbUrunSec.Name = "cmbUrunSec";
            this.cmbUrunSec.Size = new System.Drawing.Size(199, 36);
            this.cmbUrunSec.TabIndex = 3;
            // 
            // lblSecilenUrun
            // 
            this.lblSecilenUrun.AutoSize = true;
            this.lblSecilenUrun.Location = new System.Drawing.Point(35, 73);
            this.lblSecilenUrun.Name = "lblSecilenUrun";
            this.lblSecilenUrun.Size = new System.Drawing.Size(94, 28);
            this.lblSecilenUrun.TabIndex = 2;
            this.lblSecilenUrun.Text = "Ürün Seç:";
            // 
            // cmbMusteriSec
            // 
            this.cmbMusteriSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriSec.FormattingEnabled = true;
            this.cmbMusteriSec.Location = new System.Drawing.Point(132, 25);
            this.cmbMusteriSec.Name = "cmbMusteriSec";
            this.cmbMusteriSec.Size = new System.Drawing.Size(199, 36);
            this.cmbMusteriSec.TabIndex = 1;
            // 
            // lblSecilenMusteri
            // 
            this.lblSecilenMusteri.AutoSize = true;
            this.lblSecilenMusteri.Location = new System.Drawing.Point(15, 28);
            this.lblSecilenMusteri.Name = "lblSecilenMusteri";
            this.lblSecilenMusteri.Size = new System.Drawing.Size(117, 28);
            this.lblSecilenMusteri.TabIndex = 0;
            this.lblSecilenMusteri.Text = "Müşteri Seç:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtTaksitAra);
            this.tabPage4.Controls.Add(this.lblTaksitArama);
            this.tabPage4.Controls.Add(this.btnTumunuGoster);
            this.tabPage4.Controls.Add(this.btnOdemeAl);
            this.tabPage4.Controls.Add(this.dgwTaksitler);
            this.tabPage4.Controls.Add(this.lblBilgi);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(889, 583);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Taksit Ödeme";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTaksitAra
            // 
            this.txtTaksitAra.Location = new System.Drawing.Point(590, 74);
            this.txtTaksitAra.Name = "txtTaksitAra";
            this.txtTaksitAra.Size = new System.Drawing.Size(270, 34);
            this.txtTaksitAra.TabIndex = 5;
            this.txtTaksitAra.TextChanged += new System.EventHandler(this.txtTaksitAra_TextChanged);
            // 
            // lblTaksitArama
            // 
            this.lblTaksitArama.AutoSize = true;
            this.lblTaksitArama.Location = new System.Drawing.Point(538, 77);
            this.lblTaksitArama.Name = "lblTaksitArama";
            this.lblTaksitArama.Size = new System.Drawing.Size(46, 28);
            this.lblTaksitArama.TabIndex = 4;
            this.lblTaksitArama.Text = "Ara:";
            // 
            // btnTumunuGoster
            // 
            this.btnTumunuGoster.Location = new System.Drawing.Point(543, 342);
            this.btnTumunuGoster.Name = "btnTumunuGoster";
            this.btnTumunuGoster.Size = new System.Drawing.Size(138, 71);
            this.btnTumunuGoster.TabIndex = 3;
            this.btnTumunuGoster.Text = "Listeyi Yenile";
            this.btnTumunuGoster.UseVisualStyleBackColor = true;
            this.btnTumunuGoster.Click += new System.EventHandler(this.btnTumunuGoster_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Location = new System.Drawing.Point(543, 213);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(138, 71);
            this.btnOdemeAl.TabIndex = 2;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = true;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // dgwTaksitler
            // 
            this.dgwTaksitler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTaksitler.Location = new System.Drawing.Point(20, 65);
            this.dgwTaksitler.Name = "dgwTaksitler";
            this.dgwTaksitler.RowHeadersWidth = 51;
            this.dgwTaksitler.RowTemplate.Height = 24;
            this.dgwTaksitler.Size = new System.Drawing.Size(499, 504);
            this.dgwTaksitler.TabIndex = 1;
            this.dgwTaksitler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTaksitler_CellClick);
            this.dgwTaksitler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTaksitler_CellContentClick);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(16, 26);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(275, 28);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "- Ödenmemiş Taksitler Listesi -";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(376, 352);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(127, 71);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Text = "Son Satışı Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 646);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobilya Mağaza Yönetim Sistemi v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStoklar)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaksitSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisAdet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaksitler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgwMusteriler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.NumericUpDown numSatisAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.ComboBox cmbUrunSec;
        private System.Windows.Forms.Label lblSecilenUrun;
        private System.Windows.Forms.ComboBox cmbMusteriSec;
        private System.Windows.Forms.Label lblSecilenMusteri;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label lblHesaplananTutar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.NumericUpDown numTaksitSayisi;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTumunuGoster;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.DataGridView dgwTaksitler;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblKritikStok;
        private System.Windows.Forms.Label lblToplamCiro;
        private System.Windows.Forms.Label lblToplamMusteri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStoklar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTaksitAra;
        private System.Windows.Forms.Label lblTaksitArama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwSepet;
        private System.Windows.Forms.Button btnSatisiTamamla;
        private System.Windows.Forms.Button btnYazdir;
    }
}

