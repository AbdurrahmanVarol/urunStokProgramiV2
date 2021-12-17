using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünStok
{
    interface IUrunler
    {
        string Ad { get; set; }
        int Adet { get; set; }
        int Stok { get; set; }
        string Konum{ get; set; }
        string Tür { get; set; }
        string Durum { get; set; }


    }
    class ÜrünOfis : IUrunler
    {
        public string Ad { get; set; }
        public int Adet { get; set; }
        public int Stok { get; set; }
        public string Konum { get; set; }
        public string Tür { get; set; }
        public string Durum { get; set; }
        public string Dolap { get; set; }
        public string Raf { get; set; }
    }
    class KutuluÜrünOfis : IUrunler
    {
        public string Ad { get; set; }
        public int Adet { get; set; }
        public int Stok { get; set; }
        public string Konum { get; set; }
        public string Tür { get; set; }
        public string Durum { get; set; }
        public string RafId { get; set; }
        public string kutuId { get; set; }
    }

    class kutu
    {

    }

}
