namespace vEnvanter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvUrunler = new DataGridView();
            colUrunId = new DataGridViewTextBoxColumn();
            colUrunAdi = new DataGridViewTextBoxColumn();
            colStokMiktari = new DataGridViewTextBoxColumn();
            colFiyat = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewComboBoxColumn();
            btnUrunEkle = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnUrunSil = new Button();
            btnUrunGuncelle = new Button();
            btnKategoriler = new Button();
            txtArama = new TextBox();
            btnArama = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dgvUrunler.BackgroundColor = Color.FromArgb(238, 245, 255);
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Columns.AddRange(new DataGridViewColumn[] { colUrunId, colUrunAdi, colStokMiktari, colFiyat, colKategori });
            dgvUrunler.GridColor = Color.FromArgb(228, 224, 225);
            dgvUrunler.Location = new Point(24, 12);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.Size = new Size(753, 321);
            dgvUrunler.TabIndex = 0;
            dgvUrunler.DataError += dgvUrunler_DataError;
            dgvUrunler.RowEnter += dgvUrunler_RowEnter;
            // 
            // colUrunId
            // 
            colUrunId.DataPropertyName = "UrunID";
            colUrunId.HeaderText = "Ürün ID";
            colUrunId.Name = "colUrunId";
            colUrunId.Visible = false;
            // 
            // colUrunAdi
            // 
            colUrunAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUrunAdi.DataPropertyName = "UrunAdi";
            dataGridViewCellStyle1.BackColor = Color.FromArgb(180, 212, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(23, 107, 135);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            colUrunAdi.DefaultCellStyle = dataGridViewCellStyle1;
            colUrunAdi.HeaderText = "Ürün Adı";
            colUrunAdi.Name = "colUrunAdi";
            // 
            // colStokMiktari
            // 
            colStokMiktari.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStokMiktari.DataPropertyName = "StokMiktari";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(134, 182, 246);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(23, 107, 135);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            colStokMiktari.DefaultCellStyle = dataGridViewCellStyle2;
            colStokMiktari.HeaderText = "Stok Miktarı";
            colStokMiktari.Name = "colStokMiktari";
            // 
            // colFiyat
            // 
            colFiyat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFiyat.DataPropertyName = "Fiyat";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(180, 212, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(23, 107, 135);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            colFiyat.DefaultCellStyle = dataGridViewCellStyle3;
            colFiyat.HeaderText = "Fiyat";
            colFiyat.Name = "colFiyat";
            // 
            // colKategori
            // 
            colKategori.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKategori.DataPropertyName = "KategoriID";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(134, 182, 246);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(23, 107, 135);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(134, 182, 246);
            colKategori.DefaultCellStyle = dataGridViewCellStyle4;
            colKategori.HeaderText = "Kategori";
            colKategori.Name = "colKategori";
            colKategori.Resizable = DataGridViewTriState.True;
            colKategori.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.FromArgb(23, 107, 135);
            btnUrunEkle.FlatStyle = FlatStyle.Popup;
            btnUrunEkle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunEkle.ForeColor = Color.FromArgb(238, 245, 255);
            btnUrunEkle.Location = new Point(597, 344);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(114, 148);
            btnUrunEkle.TabIndex = 1;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(134, 182, 246);
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(187, 22);
            label1.TabIndex = 3;
            label1.Text = "Ürün Bilgilerini Gir:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(360, 92);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 6;
            // 
            // btnUrunSil
            // 
            btnUrunSil.BackColor = Color.FromArgb(255, 127, 62);
            btnUrunSil.FlatStyle = FlatStyle.Popup;
            btnUrunSil.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunSil.ForeColor = Color.FromArgb(0, 50, 133);
            btnUrunSil.Location = new Point(6, 127);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(205, 70);
            btnUrunSil.TabIndex = 9;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = false;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.BackColor = Color.FromArgb(255, 127, 62);
            btnUrunGuncelle.FlatStyle = FlatStyle.Popup;
            btnUrunGuncelle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUrunGuncelle.ForeColor = Color.FromArgb(0, 50, 133);
            btnUrunGuncelle.Location = new Point(6, 14);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(205, 70);
            btnUrunGuncelle.TabIndex = 10;
            btnUrunGuncelle.Text = "Ürün Bilgilerini Güncelle";
            btnUrunGuncelle.UseVisualStyleBackColor = false;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnKategoriler
            // 
            btnKategoriler.BackColor = Color.FromArgb(255, 127, 62);
            btnKategoriler.FlatStyle = FlatStyle.Popup;
            btnKategoriler.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKategoriler.ForeColor = Color.FromArgb(0, 50, 133);
            btnKategoriler.Location = new Point(7, 240);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Size = new Size(205, 70);
            btnKategoriler.TabIndex = 11;
            btnKategoriler.Text = "Kategoriler";
            btnKategoriler.UseVisualStyleBackColor = false;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(22, 54);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(229, 23);
            txtArama.TabIndex = 12;
            // 
            // btnArama
            // 
            btnArama.BackColor = Color.FromArgb(172, 135, 197);
            btnArama.FlatStyle = FlatStyle.Popup;
            btnArama.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnArama.ForeColor = Color.FromArgb(255, 229, 229);
            btnArama.Location = new Point(22, 84);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(229, 40);
            btnArama.TabIndex = 13;
            btnArama.Text = "Ürünü Ara";
            btnArama.UseVisualStyleBackColor = false;
            btnArama.Click += btnArama_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(26, 56);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 15;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 16;
            label3.Text = "Stok Miktarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(304, 56);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 17;
            label4.Text = "Fiyat: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(282, 94);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 18;
            label5.Text = "Kategori:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(377, 118);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(165, 15);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kategori ve ID'lerini Görüntüle";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(134, 182, 246);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(24, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 148);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 221, 174);
            panel2.Controls.Add(btnKategoriler);
            panel2.Controls.Add(btnUrunGuncelle);
            panel2.Controls.Add(btnUrunSil);
            panel2.Location = new Point(783, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 321);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(117, 106, 182);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnArama);
            panel3.Controls.Add(txtArama);
            panel3.Location = new Point(717, 344);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 148);
            panel3.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(255, 229, 229);
            label6.Location = new Point(22, 17);
            label6.Name = "label6";
            label6.Size = new Size(98, 22);
            label6.TabIndex = 14;
            label6.Text = "Ürün Ara:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(134, 182, 246);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(24, 498);
            panel4.Name = "panel4";
            panel4.Size = new Size(567, 62);
            panel4.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 10);
            label8.Name = "label8";
            label8.Size = new Size(241, 15);
            label8.TabIndex = 1;
            label8.Text = "Sayın \"admin\" Hoşgeldiniz. İyi Günler Dileriz.\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(13, 39);
            label7.Name = "label7";
            label7.Size = new Size(205, 15);
            label7.TabIndex = 0;
            label7.Text = "vEnvanter v1.0 - Tüm Hakları Saklıdır.\r\n";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(117, 106, 182);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(717, 499);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 61);
            panel5.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(172, 135, 197);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.FromArgb(255, 229, 229);
            button1.Location = new Point(22, 9);
            button1.Name = "button1";
            button1.Size = new Size(229, 44);
            button1.TabIndex = 0;
            button1.Text = "Oturumu Kapat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 212, 255);
            ClientSize = new Size(1006, 568);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnUrunEkle);
            Controls.Add(dgvUrunler);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vEnvanter";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUrunler;
        private Button btnUrunEkle;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnUrunSil;
        private Button btnUrunGuncelle;
        private Button btnKategoriler;
        private TextBox txtArama;
        private Button btnArama;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private DataGridViewTextBoxColumn colUrunId;
        private DataGridViewTextBoxColumn colUrunAdi;
        private DataGridViewTextBoxColumn colStokMiktari;
        private DataGridViewTextBoxColumn colFiyat;
        private DataGridViewComboBoxColumn colKategori;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Panel panel5;
        private Button button1;
    }
}
