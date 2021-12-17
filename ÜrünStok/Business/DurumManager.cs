using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;

namespace ÜrünStok.Business
{
    public class DurumManager
    {
        DurumDal _durumDal = new DurumDal();

        public List<Durum> GetAll(string param = null)
        {
            return _durumDal.GetAll(param);
        }
        public Durum Get(string param = null)
        {
            return _durumDal.Get(param);
        }
        public void Add(Durum durum)
        {
            _durumDal.Add(durum);
        }
        public void Delete(int id)
        {
            _durumDal.Delete(id);
        }
        public void Update(Durum durum)
        {
            _durumDal.Update(durum);
        }
    }
}
