using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;

namespace ÜrünStok.Business
{
    public class KullaniciManager
    {
        KullaniciDal _kullaniciDal = new KullaniciDal();

        public List<Kullanici> GetAll(string param = null)
        {
            return _kullaniciDal.GetAll(param);
        }
        public Kullanici Get(string param = null)
        {
            return _kullaniciDal.Get(param);
        }
        public void Add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }
        public void Delete(int id)
        {
            _kullaniciDal.Delete(id);
        }
        public void Update(Kullanici kullanici)
        {
            _kullaniciDal.Update(kullanici);
        }
    }
}
