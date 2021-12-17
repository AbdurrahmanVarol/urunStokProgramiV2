using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünStok.Entities
{
    public class Kullanici
    {
        public int KullaniciId{ get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public int KullaniciYetki { get; set; }

    }
}
