using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string KullaniciSifre { get; set; }
    }
}
