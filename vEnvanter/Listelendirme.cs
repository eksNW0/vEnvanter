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
    public partial class Listelendirme : Form
    {
        AppDbContext db = new AppDbContext();
        BindingList<Kategori> kategoris = new BindingList<Kategori>();
        public Listelendirme()
        {
            kategoris = new BindingList<Kategori>(db.Kategoriler.ToList());
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kategoris;
        }
    }
}
