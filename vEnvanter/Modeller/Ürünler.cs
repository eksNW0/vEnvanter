using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vEnvanter.Modeller
{
    public class Ürünler
    {
        [Key]
        public int UrunID { get; set; }

        [Required]
        [MaxLength(100)]
        public string UrunAdi { get; set; }
        public int StokMiktari { get; set; }

        [Column(TypeName = "decimal(18.2)")]
        public decimal Fiyat { get; set; }

        public DateTime EklemeTarihi { get; set; }

        // Navigation Property
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
    }
}
