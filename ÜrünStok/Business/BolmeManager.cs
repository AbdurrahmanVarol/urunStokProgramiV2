using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;

namespace ÜrünStok.Business
{
    public class BolmeManager
    {
        BolmeDal _bolmeDal = new BolmeDal();

        public List<Bolme> GetAll(string param = null)
        {
            return _bolmeDal.GetAll(param);
        }
        public Bolme Get(string param = null)
        {
            return _bolmeDal.Get(param);
        }
        public void Add(Bolme bolme)
        {

            _bolmeDal.Add(bolme);
        }
        public void Delete(int id)
        {
            _bolmeDal.Delete(id);
        }
        public void Update(Bolme bolme)
        {
            _bolmeDal.Update(bolme);
        }
    }
}
