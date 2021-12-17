using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;

namespace ÜrünStok.Business
{
    public class UrunListeManager
    {
        UrunListeDal _UrunListeDal = new UrunListeDal();
        public List<UrunListe> GetAll(string tablo,string str = null)
        {
            return _UrunListeDal.GetAll(tablo,str);
        }
        public UrunListe Get(string tablo,string str = null)
        {
            return _UrunListeDal.Get(tablo,str);
        }
    }
}
