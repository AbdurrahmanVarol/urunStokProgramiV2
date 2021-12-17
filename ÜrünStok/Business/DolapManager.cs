using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;

namespace ÜrünStok.Business
{
    public class DolapManager
    {
        DolapDal _dolapDal = new DolapDal();

        public List<Dolap> GetAll(string param = null)
        {
            return _dolapDal.GetAll(param);
        }
        public Dolap Get(string param = null)
        {
            return _dolapDal.Get(param);
        }
        public void Add(Dolap dolap)
        {
            
            _dolapDal.Add(dolap);
        }
        public void Delete(int id)
        {
            _dolapDal.Delete(id);
        }
        public void Update(Dolap dolap)
        {
            _dolapDal.Update(dolap);
        }
    }
}
