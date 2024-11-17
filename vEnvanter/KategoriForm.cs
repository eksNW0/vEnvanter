using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vEnvanter.Data;
using vEnvanter.Modeller;

namespace vEnvanter
{
    public partial class KategoriForm : Form
    {
        AppDbContext db = new AppDbContext();
        BindingList<Kategori> klist = new BindingList<Kategori>();

        public KategoriForm()
        {
            klist = new BindingList<Kategori>(db.Kategoriler.ToList());
            InitializeComponent();
            dgvKategoriler.AutoGenerateColumns = false;
            dgvKategoriler.DataSource = klist;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            var yeniKategori = new Modeller.Kategori
            {
                KategoriAdi = richTextBox1.Text
            };

            klist.Add(yeniKategori);
            db.Kategoriler.Add(yeniKategori);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi.");
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (dgvKategoriler.CurrentRow != null)
            {
                int kategoriId = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
                var silinecekKategori = db.Kategoriler.Find(kategoriId);

                klist.Remove(silinecekKategori);
                db.Kategoriler.Remove(silinecekKategori);
                db.SaveChanges();
                MessageBox.Show("Kategori silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçin.");
            }
        }
    }
}
