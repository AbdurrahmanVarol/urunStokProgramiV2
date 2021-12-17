using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünStok.Entities
{
    class UrunHangar
    {
        public int UrunId { get; set; }
        public int KategoriId { get; set; }
        public string UrunAd { get; set; }
        public int KonumId { get; set; }
        public int DurumId { get; set; }
        public int UrunAdet { get; set; }
        public int StokMiktari { get; set; }
    }
}
