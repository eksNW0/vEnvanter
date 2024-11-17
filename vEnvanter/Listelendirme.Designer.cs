namespace vEnvanter
{
    partial class Listelendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listelendirme));
            dataGridView1 = new DataGridView();
            colKategori = new DataGridViewTextBoxColumn();
            colKategorilerinAdi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colKategori, colKategorilerinAdi });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(285, 426);
            dataGridView1.TabIndex = 0;
            // 
            // colKategori
            // 
            colKategori.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKategori.DataPropertyName = "KategoriID";
            colKategori.HeaderText = "Kategori ID";
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            // 
            // colKategorilerinAdi
            // 
            colKategorilerinAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKategorilerinAdi.DataPropertyName = "KategoriAdi";
            colKategorilerinAdi.HeaderText = "Kategori Adı";
            colKategorilerinAdi.Name = "colKategorilerinAdi";
            colKategorilerinAdi.ReadOnly = true;
            // 
            // Listelendirme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 450);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Listelendirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liste";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colKategorilerinAdi;
    }
}