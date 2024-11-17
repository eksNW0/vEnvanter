using System.ComponentModel;
using vEnvanter.Data;
using vEnvanter.Modeller;

namespace vEnvanter
{
    public partial class Form1 : Form
    {

        AppDbContext db = new AppDbContext();
        BindingList<�r�nler> ulist = new BindingList<�r�nler>();
        BindingList<Kategori> blist = new BindingList<Kategori>();

        public Form1()
        {
            InitializeComponent();

            ulist = new BindingList<�r�nler>(db.�r�nler.ToList());
            blist = new BindingList<Kategori>(db.Kategoriler.ToList());
            dgvUrunler.AutoGenerateColumns = false;
            //dgvUrunler.DataSource = db.�r�nler.ToList();

            colKategori.DataSource = blist;
            colKategori.DisplayMember = "KategoriAdi";
            colKategori.ValueMember = "KategoriID";

            dgvUrunler.DataSource = ulist;

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            var yeniUrunler = new �r�nler
            {
                UrunAdi = textBox1.Text,
                StokMiktari = int.Parse(textBox2.Text),
                Fiyat = decimal.Parse(textBox3.Text),
                EklemeTarihi = DateTime.Now,
                KategoriID = int.Parse(textBox4.Text)
            };

            ulist.Add(yeniUrunler);

            db.�r�nler.Add(yeniUrunler);
            MessageBox.Show("�r�n eklendi.");
            db.SaveChanges();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int urunId = (int)dgvUrunler.CurrentRow.Cells["colUrunID"].Value;
            var urun = db.�r�nler.Find(urunId);

            if (urun != null)
            {
                urun.UrunAdi = textBox1.Text;
                urun.StokMiktari = int.Parse(textBox2.Text);
                urun.Fiyat = decimal.Parse(textBox3.Text);
                urun.KategoriID = int.Parse(textBox4.Text);


                db.SaveChanges();

                MessageBox.Show("�r�n g�ncellendi.");
            }
            else
            {
                MessageBox.Show("�r�n bulunamad�.");
            }

            dgvUrunler.Invalidate();


        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int urunId = (int)dgvUrunler.CurrentRow.Cells["colUrunID"].Value;
            var urun = db.�r�nler.Find(urunId);

            if (urun != null)
            {
                ulist.Remove(urun);
                db.�r�nler.Remove(urun);
                db.SaveChanges();
                MessageBox.Show("�r�n silindi.");
            }
            else
            {
                MessageBox.Show("�r�n bulunamad�.");
            }

        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            // Formlar�n g�r�n�rl�k durumlar�n� de�i�tir
            KategoriForm kategoriForm = new KategoriForm();
            kategoriForm.Show();
            this.Hide();

            kategoriForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string aramaKelimesi = txtArama.Text.ToLower();

            var sonuclar = db.�r�nler.Where(u => u.UrunAdi.ToLower().Contains(aramaKelimesi)).ToList();
            dgvUrunler.DataSource = sonuclar;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Listelendirme liste = new Listelendirme();
            liste.Show();
        }

        private void dgvUrunler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvUrunler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            �r�nler urun = dgvUrunler.Rows[e.RowIndex].DataBoundItem as �r�nler;
            if (urun != null)
            {
                textBox1.Text = urun.UrunAdi;
                textBox2.Text = urun.StokMiktari.ToString();
                textBox3.Text = urun.Fiyat.ToString();
                textBox4.Text = urun.KategoriID.ToString();


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            var cevap = MessageBox.Show("Oturumu Kapatmak �stedi�inize Emin Misiniz?" ,"Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
            if(cevap == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                var cevap2 = login.ShowDialog();
                if (cevap2 != DialogResult.OK)
                {

                    Application.Exit();
                }
                this.Show();
                
            }



        }
    }
}


