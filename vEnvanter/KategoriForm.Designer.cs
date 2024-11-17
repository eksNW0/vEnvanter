namespace vEnvanter
{
    partial class KategoriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriForm));
            dgvKategoriler = new DataGridView();
            colKategoriID = new DataGridViewTextBoxColumn();
            colKategoriAdi = new DataGridViewTextBoxColumn();
            btnKategoriEkle = new Button();
            btnKategoriSil = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriler.Columns.AddRange(new DataGridViewColumn[] { colKategoriID, colKategoriAdi });
            dgvKategoriler.Location = new Point(14, 15);
            dgvKategoriler.Margin = new Padding(3, 4, 3, 4);
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.Size = new Size(399, 377);
            dgvKategoriler.TabIndex = 0;
            // 
            // colKategoriID
            // 
            colKategoriID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKategoriID.DataPropertyName = "KategoriID";
            colKategoriID.HeaderText = "KategoriID";
            colKategoriID.Name = "colKategoriID";
            // 
            // colKategoriAdi
            // 
            colKategoriAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKategoriAdi.DataPropertyName = "KategoriAdi";
            colKategoriAdi.HeaderText = "Kategori Adı";
            colKategoriAdi.Name = "colKategoriAdi";
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = Color.LightGreen;
            btnKategoriEkle.FlatStyle = FlatStyle.Popup;
            btnKategoriEkle.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKategoriEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnKategoriEkle.Location = new Point(206, 74);
            btnKategoriEkle.Margin = new Padding(3, 4, 3, 4);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(179, 50);
            btnKategoriEkle.TabIndex = 2;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.BackColor = Color.Coral;
            btnKategoriSil.FlatStyle = FlatStyle.Popup;
            btnKategoriSil.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKategoriSil.Location = new Point(206, 16);
            btnKategoriSil.Margin = new Padding(3, 4, 3, 4);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(179, 50);
            btnKategoriSil.TabIndex = 3;
            btnKategoriSil.Text = "Kategori Sil";
            btnKategoriSil.UseVisualStyleBackColor = false;
            btnKategoriSil.Click += btnKategoriSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 171, 171);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(146, 26, 64);
            label1.Location = new Point(24, 420);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 4;
            label1.Text = "Oluşturmak İstediğiniz \r\nKategori Adını Giriniz:\r\n";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(7, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(188, 64);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 171, 171);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(btnKategoriSil);
            panel1.Controls.Add(btnKategoriEkle);
            panel1.Location = new Point(12, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 147);
            panel1.TabIndex = 6;
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 217, 208);
            ClientSize = new Size(425, 581);
            Controls.Add(label1);
            Controls.Add(dgvKategoriler);
            Controls.Add(panel1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KategoriForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KategoriForm";
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKategoriler;
        private Button btnKategoriEkle;
        private Button btnKategoriSil;
        private DataGridViewTextBoxColumn colKategoriID;
        private DataGridViewTextBoxColumn colKategoriAdi;
        private Label label1;
        private RichTextBox richTextBox1;
        private Panel panel1;
    }
}