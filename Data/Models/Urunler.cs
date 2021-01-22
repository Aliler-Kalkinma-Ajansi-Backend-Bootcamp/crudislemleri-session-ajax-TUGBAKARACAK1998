using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Urunler
    {
        public int UrunId { get; set; }
        public int? UrunKategori { get; set; }
        public string Urunad { get; set; }
        public string UrunMarka { get; set; }
        public short? UrunFiyat { get; set; }
        public short? UrunStokSayisi { get; set; }

        public virtual Kategoriler UrunKategoriNavigation { get; set; }
    }
}
