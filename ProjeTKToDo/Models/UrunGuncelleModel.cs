using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeTKToDo.Models
{
    public class UrunGuncelleModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün Adı Boş Geçilemez!")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Ürün Markası Boş Geçilemez!")]
        public string Marka { get; set; }
        [Required(ErrorMessage = "Kategori Alanı Boş Geçilemez")]
        public int Kategori { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Fiyatı 0'dan büyük olmalı!")]
        public short? Fiyat { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Stok Sayısı 0'dan büyük olmalı")]
        public short? StokSayisi { get; set; }
    }
}
