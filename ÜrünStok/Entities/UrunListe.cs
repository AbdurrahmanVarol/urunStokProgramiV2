using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünStok.Entities
{
    public class UrunListe
    {
        public int UrunId { get; set; }
        public string KategoriAd { get; set; }
        public string KonumAd { get; set; }
        public string UrunAd { get; set; }
        public string DolapAd { get; set; }
        public string RafAd { get; set; }
        public string Kutu { get; set; }
        public string Bolme { get; set; }
        public string DurumAd { get; set; }
        public int UrunAdet { get; set; }
        public int StokMiktari { get; set; }
    }
}
