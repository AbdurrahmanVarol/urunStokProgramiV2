using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;

namespace ÜrünStok.Business
{
    public class KutuManager
    {
        KutuDal _kutuDal = new KutuDal();

        public List<Kutu> GetAll(string param = null)
        {
            return _kutuDal.GetAll(param);
        }
        public Kutu Get(string param = null)
        {
            return _kutuDal.Get(param);
        }
        public void Add(Kutu kutu)
        {
            _kutuDal.Add(kutu);
        }
        public void Delete(int id)
        {
            _kutuDal.Delete(id);
        }
        public void Update(Kutu kutu)
        {
            _kutuDal.Update(kutu);
        }
    }
}
