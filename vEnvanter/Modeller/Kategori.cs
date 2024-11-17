using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vEnvanter.Modeller
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        [Required]
        [MaxLength(100)]
        public string KategoriAdi { get; set; }

        // Navigation Property
        public List<Ürünler> Ürünler { get; set; }
    }
}
