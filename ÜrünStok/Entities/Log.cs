using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünStok.Entities
{
    public class Log
    {
        public int LogId { get; set; }
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string KullaniciAd { get; set; }
        public int YetkiId { get; set; }
        public string Islem { get; set; }
        public string Tarih { get; set; }
    }
}
