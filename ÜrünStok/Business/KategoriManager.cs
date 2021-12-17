using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;

namespace ÜrünStok.Business
{
    public class KategoriManager
    {
        KategoriDal  _kategoriDal = new KategoriDal();

        public List<Kategori> GetAll(string param = null)
        {
            return _kategoriDal.GetAll(param);
        }
        public Kategori Get(string str = null)
        {
            return _kategoriDal.Get(str);
        }
        public void Add(Kategori kategori)
        {
            _kategoriDal.Add(kategori);
        }
        public void Delete(int id)
        {
            _kategoriDal.Delete(id);
        }
        public void Update(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }
    }
}
